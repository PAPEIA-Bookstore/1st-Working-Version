namespace login_register
{
    partial class TransactionPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            paymentButton = new Button();
            label1 = new Label();
            label2 = new Label();
            TopLabel = new Label();
            label4 = new Label();
            label5 = new Label();
            label9 = new Label();
            panel1 = new Panel();
            titleTextBox = new TextBox();
            authorTextBox = new TextBox();
            isbnTextBox = new TextBox();
            priceTextBox = new TextBox();
            cardNumberTextBox = new TextBox();
            cardOwnerTextBox = new TextBox();
            CVVTextBox = new TextBox();
            expirationDateTextBox = new TextBox();
            label3 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            postalCodeTextBox = new TextBox();
            cityTextBox = new TextBox();
            roadNumberTextBox = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // paymentButton
            // 
            paymentButton.BackColor = Color.FromArgb(73, 60, 52);
            paymentButton.FlatStyle = FlatStyle.Flat;
            paymentButton.Font = new Font("Candara", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            paymentButton.ForeColor = Color.PapayaWhip;
            paymentButton.Location = new Point(1086, 750);
            paymentButton.Margin = new Padding(3, 4, 3, 4);
            paymentButton.Name = "paymentButton";
            paymentButton.Size = new Size(246, 51);
            paymentButton.TabIndex = 0;
            paymentButton.Text = "Complete Payment";
            paymentButton.UseVisualStyleBackColor = false;
            paymentButton.Click += Payment_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 14.25F, FontStyle.Bold);
            label1.ForeColor = Color.PapayaWhip;
            label1.Location = new Point(13, 14);
            label1.Name = "label1";
            label1.Size = new Size(56, 28);
            label1.TabIndex = 1;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Candara", 14.25F, FontStyle.Bold);
            label2.ForeColor = Color.PapayaWhip;
            label2.Location = new Point(390, 15);
            label2.Name = "label2";
            label2.Size = new Size(81, 28);
            label2.TabIndex = 2;
            label2.Text = "Author";
            // 
            // TopLabel
            // 
            TopLabel.AutoSize = true;
            TopLabel.BackColor = Color.PapayaWhip;
            TopLabel.Font = new Font("Candara", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TopLabel.ForeColor = Color.FromArgb(73, 60, 52);
            TopLabel.Location = new Point(69, 43);
            TopLabel.Name = "TopLabel";
            TopLabel.Size = new Size(193, 42);
            TopLabel.TabIndex = 3;
            TopLabel.Text = "Transaction";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Candara", 14.25F, FontStyle.Bold);
            label4.ForeColor = Color.PapayaWhip;
            label4.Location = new Point(666, 15);
            label4.Name = "label4";
            label4.Size = new Size(59, 28);
            label4.TabIndex = 4;
            label4.Text = "ISBN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Candara", 14.25F, FontStyle.Bold);
            label5.ForeColor = Color.PapayaWhip;
            label5.Location = new Point(1015, 15);
            label5.Name = "label5";
            label5.Size = new Size(62, 28);
            label5.TabIndex = 5;
            label5.Text = "Price";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Candara", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(73, 60, 52);
            label9.Location = new Point(69, 266);
            label9.Name = "label9";
            label9.Size = new Size(137, 28);
            label9.TabIndex = 10;
            label9.Text = "Card Details:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(73, 60, 52);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(71, 118);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1261, 52);
            panel1.TabIndex = 12;
            // 
            // titleTextBox
            // 
            titleTextBox.BackColor = Color.White;
            titleTextBox.BorderStyle = BorderStyle.FixedSingle;
            titleTextBox.Font = new Font("Candara", 12F);
            titleTextBox.Location = new Point(71, 165);
            titleTextBox.Margin = new Padding(3, 4, 3, 4);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(391, 31);
            titleTextBox.TabIndex = 13;
            // 
            // authorTextBox
            // 
            authorTextBox.BackColor = Color.White;
            authorTextBox.BorderStyle = BorderStyle.FixedSingle;
            authorTextBox.Font = new Font("Candara", 12F);
            authorTextBox.Location = new Point(461, 165);
            authorTextBox.Margin = new Padding(3, 4, 3, 4);
            authorTextBox.Name = "authorTextBox";
            authorTextBox.Size = new Size(279, 31);
            authorTextBox.TabIndex = 14;
            // 
            // isbnTextBox
            // 
            isbnTextBox.BackColor = Color.White;
            isbnTextBox.BorderStyle = BorderStyle.FixedSingle;
            isbnTextBox.Font = new Font("Candara", 12F);
            isbnTextBox.Location = new Point(737, 165);
            isbnTextBox.Margin = new Padding(3, 4, 3, 4);
            isbnTextBox.Name = "isbnTextBox";
            isbnTextBox.Size = new Size(349, 31);
            isbnTextBox.TabIndex = 15;
            // 
            // priceTextBox
            // 
            priceTextBox.BackColor = Color.White;
            priceTextBox.BorderStyle = BorderStyle.FixedSingle;
            priceTextBox.Font = new Font("Candara", 12F);
            priceTextBox.Location = new Point(1086, 165);
            priceTextBox.Margin = new Padding(3, 4, 3, 4);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(245, 31);
            priceTextBox.TabIndex = 16;
            // 
            // cardNumberTextBox
            // 
            cardNumberTextBox.BackColor = Color.White;
            cardNumberTextBox.Font = new Font("Candara", 12F);
            cardNumberTextBox.Location = new Point(231, 304);
            cardNumberTextBox.Margin = new Padding(3, 4, 3, 4);
            cardNumberTextBox.MaxLength = 16;
            cardNumberTextBox.Name = "cardNumberTextBox";
            cardNumberTextBox.Size = new Size(379, 31);
            cardNumberTextBox.TabIndex = 17;
            // 
            // cardOwnerTextBox
            // 
            cardOwnerTextBox.BackColor = Color.White;
            cardOwnerTextBox.CharacterCasing = CharacterCasing.Upper;
            cardOwnerTextBox.Font = new Font("Candara", 12F);
            cardOwnerTextBox.Location = new Point(231, 341);
            cardOwnerTextBox.Margin = new Padding(3, 4, 3, 4);
            cardOwnerTextBox.Name = "cardOwnerTextBox";
            cardOwnerTextBox.Size = new Size(379, 31);
            cardOwnerTextBox.TabIndex = 18;
            // 
            // CVVTextBox
            // 
            CVVTextBox.BackColor = Color.White;
            CVVTextBox.Font = new Font("Candara", 12F);
            CVVTextBox.Location = new Point(231, 377);
            CVVTextBox.Margin = new Padding(3, 4, 3, 4);
            CVVTextBox.MaxLength = 3;
            CVVTextBox.Name = "CVVTextBox";
            CVVTextBox.PasswordChar = '*';
            CVVTextBox.Size = new Size(101, 31);
            CVVTextBox.TabIndex = 19;
            // 
            // expirationDateTextBox
            // 
            expirationDateTextBox.BackColor = Color.White;
            expirationDateTextBox.Font = new Font("Candara", 12F);
            expirationDateTextBox.Location = new Point(500, 377);
            expirationDateTextBox.Margin = new Padding(3, 4, 3, 4);
            expirationDateTextBox.MaxLength = 5;
            expirationDateTextBox.Name = "expirationDateTextBox";
            expirationDateTextBox.Size = new Size(110, 31);
            expirationDateTextBox.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Candara", 12F);
            label3.Location = new Point(110, 309);
            label3.Name = "label3";
            label3.Size = new Size(121, 24);
            label3.TabIndex = 21;
            label3.Text = "Card Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Candara", 12F);
            label6.Location = new Point(121, 345);
            label6.Name = "label6";
            label6.Size = new Size(110, 24);
            label6.TabIndex = 22;
            label6.Text = "Card Owner";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Candara", 12F);
            label7.Location = new Point(136, 383);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.No;
            label7.Size = new Size(94, 24);
            label7.TabIndex = 23;
            label7.Text = "CVV Digits";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Candara", 12F);
            label8.Location = new Point(360, 383);
            label8.Name = "label8";
            label8.Size = new Size(139, 24);
            label8.TabIndex = 24;
            label8.Text = "Expiration Date";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Candara", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(73, 60, 52);
            label11.Location = new Point(71, 451);
            label11.Name = "label11";
            label11.Size = new Size(99, 28);
            label11.TabIndex = 25;
            label11.Text = "Address:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Candara", 12F);
            label12.Location = new Point(121, 570);
            label12.Name = "label12";
            label12.RightToLeft = RightToLeft.No;
            label12.Size = new Size(109, 24);
            label12.TabIndex = 32;
            label12.Text = "Postal Code";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Candara", 12F);
            label13.Location = new Point(185, 532);
            label13.Name = "label13";
            label13.Size = new Size(41, 24);
            label13.TabIndex = 31;
            label13.Text = "City";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Candara", 12F);
            label14.Location = new Point(99, 494);
            label14.Name = "label14";
            label14.Size = new Size(131, 24);
            label14.TabIndex = 30;
            label14.Text = "Road, Number";
            // 
            // postalCodeTextBox
            // 
            postalCodeTextBox.BackColor = Color.White;
            postalCodeTextBox.Font = new Font("Candara", 12F);
            postalCodeTextBox.Location = new Point(231, 565);
            postalCodeTextBox.Margin = new Padding(3, 4, 3, 4);
            postalCodeTextBox.MaxLength = 5;
            postalCodeTextBox.Name = "postalCodeTextBox";
            postalCodeTextBox.Size = new Size(101, 31);
            postalCodeTextBox.TabIndex = 28;
            // 
            // cityTextBox
            // 
            cityTextBox.BackColor = Color.White;
            cityTextBox.Font = new Font("Candara", 12F);
            cityTextBox.Location = new Point(231, 528);
            cityTextBox.Margin = new Padding(3, 4, 3, 4);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(379, 31);
            cityTextBox.TabIndex = 27;
            // 
            // roadNumberTextBox
            // 
            roadNumberTextBox.BackColor = Color.White;
            roadNumberTextBox.Font = new Font("Candara", 12F);
            roadNumberTextBox.Location = new Point(231, 491);
            roadNumberTextBox.Margin = new Padding(3, 4, 3, 4);
            roadNumberTextBox.Name = "roadNumberTextBox";
            roadNumberTextBox.Size = new Size(379, 31);
            roadNumberTextBox.TabIndex = 26;
            // 
            // TransactionPage
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(1455, 907);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(postalCodeTextBox);
            Controls.Add(cityTextBox);
            Controls.Add(roadNumberTextBox);
            Controls.Add(label11);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(expirationDateTextBox);
            Controls.Add(CVVTextBox);
            Controls.Add(cardOwnerTextBox);
            Controls.Add(cardNumberTextBox);
            Controls.Add(priceTextBox);
            Controls.Add(isbnTextBox);
            Controls.Add(authorTextBox);
            Controls.Add(titleTextBox);
            Controls.Add(panel1);
            Controls.Add(label9);
            Controls.Add(TopLabel);
            Controls.Add(paymentButton);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "TransactionPage";
            Text = "TransactionPage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button paymentButton;
        private Label label1;
        private Label label2;
        private Label TopLabel;
        private Label label4;
        private Label label5;
        private Label label9;
        private Panel panel1;
        private TextBox titleTextBox;
        private TextBox authorTextBox;
        private TextBox isbnTextBox;
        private TextBox priceTextBox;
        private TextBox cardNumberTextBox;
        private TextBox cardOwnerTextBox;
        private TextBox CVVTextBox;
        private TextBox expirationDateTextBox;
        private Label label3;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox postalCodeTextBox;
        private TextBox cityTextBox;
        private TextBox roadNumberTextBox;
    }
}