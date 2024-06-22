using Npgsql;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace login_register
{
    public class Book
    {
        public string isbn { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string plot { get; set; }
        public string category { get; set; }
        public float price { get; set; }
        public string cover { get; set; }//link

        //constructor of book object
        public Book(string isbn, string title, string author, string plot, string category , float price, string cover)
        {
            this.isbn = isbn;
            this.title = title;
            this.author = author;
            this.plot = plot;
            this.category = category;
            this.price = price;
            this.cover = cover;
        }
        public void InsertBook_toDB()
        {
            // string price1 = this.price.ToString(CultureInfo.InvariantCulture);
            NpgsqlConnection connection = DBHandler.OpenConnection();
            NpgsqlCommand command = DBHandler.GetCommand(connection);
            command.CommandText = "INSERT INTO books VALUES (@isbn,@title,@author,@plot,@category,@price,@cover);";
            command.Parameters.AddWithValue("isbn", this.isbn);
            command.Parameters.AddWithValue("title", this.title);
            command.Parameters.AddWithValue("author", this.author);
            command.Parameters.AddWithValue("plot", this.plot);
            command.Parameters.AddWithValue("category",this.category);
            command.Parameters.AddWithValue("price", this.price);
            command.Parameters.AddWithValue("cover", this.cover);
            command.ExecuteNonQuery();
            DBHandler.CloseConnection(connection, command);
        }

    }
}
