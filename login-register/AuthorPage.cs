using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using static System.Reflection.Metadata.BlobBuilder;

namespace login_register
{
    public partial class AuthorPage : Form
    {
        List<Control> fields;

        //Both pulled from first query
        Hashtable books;
        public AuthorPage()
        {
            //Author profile
            InitializeComponent();
            pictureBox1.Load(User.GetProfilePic());
            authorNameLabel.Text = User.GetFullName();
            authorUsernameLabel.Text = "@" + User.GetUsername();

            //Book input fields
            fields = new List<Control>() { cover_textBox, isbn_textBox, price_textBox, title_textBox, plot_richTextBox, comboBox1 };

            books = new Hashtable();

            NpgsqlConnection connection = DBHandler.OpenConnection();
            NpgsqlCommand command = DBHandler.GetCommand(connection);
            command.CommandText = "SELECT * FROM books WHERE author = @author;";
            command.Parameters.AddWithValue("author", User.GetFullName());
            NpgsqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    books.Add(reader.GetString(0), reader.GetString(1));    //Fetch author's books in (ISBN, title) pairs
                }
                reader.Close();

                command.CommandText = "SELECT * FROM book_statistics;";
                NpgsqlDataReader reader2 = command.ExecuteReader();
                if (reader2.HasRows)
                {
                    while (reader2.Read())
                    {
                        //Get their statistics from book_statistics
                        if (books.ContainsKey(reader2.GetString(0)))
                        {
                            string title = books[reader2.GetString(0)].ToString();

                            RichTextBox richTextBox = new RichTextBox();
                            richTextBox.BackColor = Color.FromArgb(73, 60, 52);
                            richTextBox.BorderStyle = BorderStyle.None;
                            richTextBox.Font = new Font("Candara", 16.2782612F, FontStyle.Regular, GraphicsUnit.Point, 161);
                            richTextBox.ForeColor = Color.PapayaWhip;
                            richTextBox.Size = new Size(300, 100);
                            richTextBox.ScrollBars = RichTextBoxScrollBars.None;
                            
                            int length = statisticsContainer.Text.Length;
                            int titleLength = title.Length;
                            richTextBox.Text = statisticsContainer.Text + title + "\nRating: " + reader2.GetFloat(1).ToString("0.0") + "\nSales: " + reader2.GetInt32(2).ToString() + "\n";
                            richTextBox.Select(length, titleLength);
                            richTextBox.SelectionFont = new Font(statisticsContainer.Font, FontStyle.Bold);

                            statisticsPanel.Controls.Add(richTextBox);

                            //length = statisticsContainer.Text.Length;
                            
                            //statisticsContainer.Text = statisticsContainer.Text + title + "\nRating: " + reader2.GetFloat(1).ToString("0.0") + "\nSales: " + reader2.GetInt32(2).ToString() + "\n\n";
                            //statisticsContainer.Select(length, titleLength);
                            //statisticsContainer.SelectionFont = new Font(statisticsContainer.Font, FontStyle.Bold);
                        }
                    }

                }
                reader2.Close();

            }
            else
            {
                statisticsContainer.Text = "You haven't published any books";
                //No books were found
            }
            //reader.Close();
            DBHandler.CloseConnection(connection, command);

            //FillSalesChart();
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            if (fields.Any(fields => String.IsNullOrWhiteSpace(fields.Text)))
            {
                MessageBox.Show("Please complete all required fields!", "Publication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string isbn = isbn_textBox.Text;
                string title = title_textBox.Text;
                string author = User.GetFullName(); //o user είναι ο συγγραφέας του βιβλίου
                string plot = plot_richTextBox.Text;
                float price = float.Parse(price_textBox.Text, CultureInfo.InvariantCulture.NumberFormat);
                string cover = cover_textBox.Text;

                Book book = new Book(isbn, title, author, plot, comboBox1.Text, price, cover);
                book.InsertBook_toDB();
                MessageBox.Show("You have successfully published a book!", "Book Published", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cover_textBox.Clear();
                isbn_textBox.Clear();
                price_textBox.Clear();
                title_textBox.Clear();
                plot_richTextBox.Clear();
                comboBox1.Text = String.Empty;

            }


        }

        private void statisticsContainer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
