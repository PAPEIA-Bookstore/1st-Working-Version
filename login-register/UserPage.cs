using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_register
{
    public partial class UserPage : Form
    {
        public UserPage()
        {
            InitializeComponent();
            pictureBox1.Load(User.GetProfilePic());
            fullNameLabel.Text = User.GetFullName();
            usernameLabel.Text = "@" + User.GetUsername();

            FetchBookCovers();
        }

        private void AddBookToShelf(string bookCover)
        {
            //Create picture box
            PictureBox picBox;
            picBox = new PictureBox();
            picBox.Name = String.Format("BookPanel{0}", bookCover);
            picBox.Size = new Size(150, 225);
            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
            picBox.Load(bookCover);

            shelfPanel.Controls.Add(picBox);
        }

        private void FetchBookCovers()
        {
            NpgsqlConnection connection = DBHandler.OpenConnection();
            NpgsqlCommand command = DBHandler.GetCommand(connection);

            command.CommandText = "SELECT isbn FROM transactions WHERE username = @username";
            command.Parameters.AddWithValue("username", User.GetUsername());
            NpgsqlDataReader isbnReader = command.ExecuteReader();

            List<string> ISBNs = new List<string>();

            if (isbnReader.HasRows)
            {
                while (isbnReader.Read())
                {
                    ISBNs.Add(isbnReader.GetString(0));

                }
            }
            isbnReader.Close();
            command.Dispose();

            foreach (string isbn in ISBNs)
            {
                using (NpgsqlCommand coverCommand = DBHandler.GetCommand(connection))
                {
                    coverCommand.CommandText = "SELECT cover FROM books WHERE isbn = @isbn";
                    coverCommand.Parameters.AddWithValue("isbn", isbn);

                    using (NpgsqlDataReader coverReader = coverCommand.ExecuteReader())
                    {
                        if (coverReader.HasRows)
                        {
                            if (coverReader.Read())
                            {
                                AddBookToShelf(coverReader.GetString(0));
                            }
                        }
                    }
                }

            }

            connection.Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
