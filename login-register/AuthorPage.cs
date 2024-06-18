using System;
using System.Collections;
using System.Collections.Generic;
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

        public AuthorPage()
        {
            InitializeComponent();
            pictureBox1.Load(User.GetProfilePic());
            authorNameLabel.Text = User.GetFullName();
            authorUsernameLabel.Text = "@" + User.GetUsername();



            List<List<string>> Books = new List<List<string>>();
            List<String> B = new List<string>();
            List<String> n = new List<string>();

            // MessageBox.Show("The search bar is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            NpgsqlConnection connection = DBHandler.OpenConnection();
            NpgsqlCommand command = DBHandler.GetCommand(connection);
            command.CommandText = "SELECT * FROM books WHERE author like \'" + User.GetFullName() + "\';" ;
            NpgsqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    String x = reader.GetString(0) ;
                    B.Add(x);
                    String p = reader.GetString(1);
                    n.Add(p);
                }


                foreach (String y in B)
                {
                    reader.Close();
                    command.CommandText = "select * from book_statistics WHERE isbn like \'" + y + "\';";
                    NpgsqlDataReader reader2 = command.ExecuteReader();
                    if (reader2.HasRows)
                    {
                        while (reader2.Read())
                        {
                            String f = n.First() ;
                            //String x = (reader.GetString(0), reader.GetString(1), reader.GetString(2));
                            label6.Text = label6.Text + "Title : " + f +" rating : " + reader.GetInt16(1).ToString() + " sales : " + reader.GetInt32(2).ToString() + System.Environment.NewLine;
                            //label6.Text = label6.Text + "Title : " + reader.GetString(0) + " rating : " + reader.GetString(1) + " sales : " + reader.GetString(2);
                            n.RemoveAt(0);
                        }

                    }
                    reader2.Close();
                }
            }
            else
            {
                label6.Text = "No books found";
                //No books were found
            }
            //reader.Close();
            DBHandler.CloseConnection(connection, command);


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isbn_textBox.TextLength < 1 || title_textBox.TextLength < 1 || plot_richTextBox.TextLength < 1 || price_textBox.TextLength < 1 || cover_textBox.TextLength < 1)
            {
                MessageBox.Show("Please complete all required fields!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            }


        }

    }
}
