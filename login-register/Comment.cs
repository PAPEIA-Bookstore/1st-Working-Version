﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace login_register
{
    public class Comment
    {
        private int Id;
        private string Username;
        private string Isbn;
        private string Text;
        private bool Is_reply;
        private int Parent;
        private DateTime Time;

        public Comment(string username, string isbn, string text, bool is_reply, int parent, DateTime time)
        {
            //this.Id = id;
            this.Username = username;
            this.Isbn = isbn;
            this.Text = text;
            this.Is_reply = is_reply;
            this.Parent = parent;
            this.Time = time;
        }
        
        public int getID()
        {
            return this.Id;
        }
        public string getUsername()
        {
            return this.Username;
        }
        public string getIsbn()
        {
            return this.Isbn;
        }
        public string getText()
        {
            return this.Text;
        }
        public DateTime getTime()
        {
            return Time;
        }
        public void InsertComment_toDB()
        {
            string query = "INSERT INTO comments(username, isbn, text, is_reply, parent, time) VALUES (@username, @isbn, @text, @is_reply, @parent, @timestamp)";

            using (var connection = DBHandler.OpenConnection())
            {
                using (var command = new NpgsqlCommand(query, connection))
                {
                    // Add parameter to the query
                    command.Parameters.AddWithValue("username", User.GetUsername());
                    command.Parameters.AddWithValue("isbn", this.Isbn);
                    command.Parameters.AddWithValue("text", this.Text);
                    command.Parameters.AddWithValue("is_reply", this.Is_reply);
                    command.Parameters.AddWithValue("parent", this.Parent);
                    command.Parameters.AddWithValue("timestamp", this.Time);

                    // Execute the command
                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine($"Rows affected: {rowsAffected}");
                }
            }
            MessageBox.Show("You comment has been posted!", "Thank you", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static List<Comment[]> getPairs(Book book)
        {
            List < Comment[] > pairs = new List<Comment[]>();
            //παίρνει το καρτεσιανό γινόμενο από το σχόλιο και την απάντηση ,όταν υπάρχει απάντηση
            string query = "select * from comments as comm left outer join comments as ans on comm.id = ans.parent where ans.id is not null and comm.isbn='"+book.isbn+ "' and comm.is_reply = false";
            using NpgsqlConnection connection = DBHandler.OpenConnection();
            using NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
            using NpgsqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Comment comm = new Comment(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetBoolean(4),reader.GetInt16(5),reader.GetDateTime(6));
                comm.Id = reader.GetInt16(0);
                Comment ans = new Comment(reader.GetString(8), reader.GetString(9), reader.GetString(10), reader.GetBoolean(11), reader.GetInt16(12), reader.GetDateTime(13));
                ans.Id = reader.GetInt16(7);
                Comment[] pair = { comm, ans };
                pairs.Add(pair); //πίνακας 2 αντικειμένων, ερώτησης-απάντησης
            }
            return pairs; // επιστρέφεται η λίστα των ζευγών
        }
        public static List<Comment> getComments(Book book) //comments που δεν έχουν απάντηση
        {
            List<Comment> comments = new List<Comment>();

            string query = "select * from comments as comm left outer join comments as ans on comm.id = ans.parent where ans.id is null and comm.isbn='"+book.isbn+ "' and comm.is_reply = false";
            using NpgsqlConnection connection = DBHandler.OpenConnection();
            using NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
            using NpgsqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Comment comm = new Comment(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetBoolean(4), reader.GetInt16(5), reader.GetDateTime(6));
                comm.Id = reader.GetInt16(0);
                comments.Add(comm);
            }
                return comments;
        }
    }
}
