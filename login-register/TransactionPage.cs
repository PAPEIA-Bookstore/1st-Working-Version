using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_register
{
    public partial class TransactionPage : Form
    {
        private Book book;
        List<TextBox> paymentFields;
        List<TextBox> addressFields;

        public TransactionPage(Book book)
        {
            InitializeComponent();
            this.book = book;
            titleTextBox.Text = book.title;
            authorTextBox.Text = book.author;
            isbnTextBox.Text = book.isbn;
            priceTextBox.Text = book.price.ToString() + "€";
            paymentFields = new List<TextBox>() { cardNumberTextBox, cardOwnerTextBox, CVVTextBox, expirationDateTextBox };
            addressFields = new List<TextBox>() { roadNumberTextBox, cityTextBox, postalCodeTextBox };
        }

        private void Payment_Click(object sender, EventArgs e)
        {

            if (paymentFields.Any(paymentFields => String.IsNullOrWhiteSpace(paymentFields.Text)))
            {
                MessageBox.Show("Please fill in all the payment fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (addressFields.Any(addressFields => String.IsNullOrWhiteSpace(addressFields.Text)))
            {
                MessageBox.Show("Please fill in all your address details!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Chech that input is correct
                bool RegMatchCardNo, RegMatchCVV, RegMatchExpiry, RegMatchCity, RegMatchPostalCode;
                RegMatchCardNo = Regex.IsMatch(cardNumberTextBox.Text, GLOBALS.cardREGEX);
                RegMatchCVV = Regex.IsMatch(CVVTextBox.Text, GLOBALS.CVVREGEX);
                RegMatchExpiry = Regex.IsMatch(expirationDateTextBox.Text, GLOBALS.expDateREGEX);
                RegMatchCity = Regex.IsMatch(cityTextBox.Text, GLOBALS.cityREGEX);
                RegMatchPostalCode = Regex.IsMatch(postalCodeTextBox.Text, GLOBALS.postalCodeREGEX);

                if (RegMatchCardNo)
                {
                    if (RegMatchCVV)
                    {
                        if (RegMatchExpiry)
                        {
                            if (RegMatchCity)
                            {
                                if (RegMatchPostalCode)
                                {
                                    DateTime time = DateTime.Now;
                                    string price = book.price.ToString(CultureInfo.InvariantCulture);
                                    NpgsqlConnection connection = DBHandler.OpenConnection();
                                    NpgsqlCommand command = DBHandler.GetCommand(connection);
                                    command.CommandText = "INSERT INTO transactions(username,time,price,isbn) VALUES('" + User.GetUsername() + "','" + time.ToString() + "'," + price + ",'" + book.isbn + "');";
                                    command.ExecuteNonQuery();
                                    MessageBox.Show("Transaction Successful!", "Thank you for choosing us", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    DBHandler.CloseConnection(connection, command);

                                }
                                else
                                {
                                    MessageBox.Show("Please enter a valid postal code", "Incorrect Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    postalCodeTextBox.Clear();
                                    postalCodeTextBox.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please enter a valid city name", "Incorrect Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                cityTextBox.Clear();
                                cityTextBox.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid expiration date", "Incorrect Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            expirationDateTextBox.Clear();
                            expirationDateTextBox.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid CVV", "Incorrect Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        CVVTextBox.Clear();
                        CVVTextBox.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid card number", "Incorrect Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cardNumberTextBox.Clear();
                    cardNumberTextBox.Focus();
                }

            }

        }
    }
}
   

