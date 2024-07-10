namespace login_register
{
    partial class AuthorPage
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
            profCover = new PictureBox();
            scroll_panel2 = new Panel();
            statisticsPanel = new FlowLayoutPanel();
            statisticsContainer = new RichTextBox();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            authorNameLabel = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label4 = new Label();
            AddBookButton = new Button();
            plot_richTextBox = new RichTextBox();
            label1 = new Label();
            label3 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            title_label = new Label();
            title_textBox = new TextBox();
            isbn_label = new Label();
            isbn_textBox = new TextBox();
            category_label = new Label();
            comboBox1 = new ComboBox();
            price_label = new Label();
            price_textBox = new TextBox();
            cover_label = new Label();
            cover_textBox = new TextBox();
            label2 = new Label();
            authorUsernameLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)profCover).BeginInit();
            scroll_panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // profCover
            // 
            profCover.Dock = DockStyle.Top;
            profCover.Image = Properties.Resources.profCover;
            profCover.Location = new Point(0, 0);
            profCover.Margin = new Padding(3, 4, 3, 4);
            profCover.Name = "profCover";
            profCover.Size = new Size(1455, 147);
            profCover.SizeMode = PictureBoxSizeMode.StretchImage;
            profCover.TabIndex = 6;
            profCover.TabStop = false;
            // 
            // scroll_panel2
            // 
            scroll_panel2.AutoScroll = true;
            scroll_panel2.Controls.Add(statisticsPanel);
            scroll_panel2.Controls.Add(statisticsContainer);
            scroll_panel2.Controls.Add(label5);
            scroll_panel2.Controls.Add(pictureBox2);
            scroll_panel2.Controls.Add(authorNameLabel);
            scroll_panel2.Controls.Add(pictureBox1);
            scroll_panel2.Controls.Add(panel1);
            scroll_panel2.Controls.Add(label2);
            scroll_panel2.Controls.Add(authorUsernameLabel);
            scroll_panel2.Dock = DockStyle.Bottom;
            scroll_panel2.ForeColor = Color.PapayaWhip;
            scroll_panel2.Location = new Point(0, 144);
            scroll_panel2.Margin = new Padding(3, 4, 3, 4);
            scroll_panel2.Name = "scroll_panel2";
            scroll_panel2.Size = new Size(1455, 763);
            scroll_panel2.TabIndex = 14;
            // 
            // statisticsPanel
            // 
            statisticsPanel.AutoScroll = true;
            statisticsPanel.BackColor = Color.FromArgb(73, 60, 52);
            statisticsPanel.FlowDirection = FlowDirection.TopDown;
            statisticsPanel.Location = new Point(30, 723);
            statisticsPanel.Name = "statisticsPanel";
            statisticsPanel.Size = new Size(1378, 300);
            statisticsPanel.TabIndex = 23;
            // 
            // statisticsContainer
            // 
            statisticsContainer.BackColor = Color.FromArgb(73, 60, 52);
            statisticsContainer.BorderStyle = BorderStyle.None;
            statisticsContainer.Font = new Font("Candara", 16.2782612F, FontStyle.Regular, GraphicsUnit.Point, 161);
            statisticsContainer.ForeColor = Color.PapayaWhip;
            statisticsContainer.Location = new Point(30, 710);
            statisticsContainer.Name = "statisticsContainer";
            statisticsContainer.Size = new Size(519, 350);
            statisticsContainer.TabIndex = 21;
            statisticsContainer.Text = "";
            statisticsContainer.TextChanged += statisticsContainer_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(73, 60, 52);
            label5.Font = new Font("Candara", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.PapayaWhip;
            label5.Location = new Point(14, 665);
            label5.Name = "label5";
            label5.Size = new Size(188, 42);
            label5.TabIndex = 20;
            label5.Text = "Your Books";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(73, 60, 52);
            pictureBox2.Location = new Point(0, 645);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1455, 432);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // authorNameLabel
            // 
            authorNameLabel.AutoSize = true;
            authorNameLabel.Font = new Font("Candara", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            authorNameLabel.ForeColor = Color.PapayaWhip;
            authorNameLabel.Location = new Point(158, 34);
            authorNameLabel.Name = "authorNameLabel";
            authorNameLabel.Size = new Size(166, 42);
            authorNameLabel.TabIndex = 2;
            authorNameLabel.Text = "Full Name";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(13, 34);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 127);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(73, 60, 52);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(AddBookButton);
            panel1.Controls.Add(plot_richTextBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Location = new Point(537, 9);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(871, 609);
            panel1.TabIndex = 11;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.PapayaWhip;
            label4.Location = new Point(53, 365);
            label4.Name = "label4";
            label4.Size = new Size(57, 28);
            label4.TabIndex = 19;
            label4.Text = "Plot:";
            // 
            // AddBookButton
            // 
            AddBookButton.BackColor = Color.FromArgb(73, 60, 52);
            AddBookButton.FlatStyle = FlatStyle.Flat;
            AddBookButton.Font = new Font("Candara", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddBookButton.ForeColor = Color.FromArgb(186, 252, 203);
            AddBookButton.Location = new Point(309, 503);
            AddBookButton.Margin = new Padding(3, 4, 3, 4);
            AddBookButton.Name = "AddBookButton";
            AddBookButton.Size = new Size(234, 71);
            AddBookButton.TabIndex = 18;
            AddBookButton.Text = "ADD BOOK";
            AddBookButton.UseVisualStyleBackColor = false;
            AddBookButton.Click += AddBookButton_Click;
            // 
            // plot_richTextBox
            // 
            plot_richTextBox.BackColor = Color.PapayaWhip;
            plot_richTextBox.BorderStyle = BorderStyle.None;
            plot_richTextBox.Font = new Font("Candara", 12F);
            plot_richTextBox.Location = new Point(165, 286);
            plot_richTextBox.Margin = new Padding(3, 4, 3, 4);
            plot_richTextBox.Name = "plot_richTextBox";
            plot_richTextBox.Size = new Size(599, 193);
            plot_richTextBox.TabIndex = 17;
            plot_richTextBox.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.PapayaWhip;
            label1.Location = new Point(247, 9);
            label1.Name = "label1";
            label1.Size = new Size(397, 42);
            label1.TabIndex = 8;
            label1.Text = "Add a Book to the Library";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.PapayaWhip;
            label3.Location = new Point(53, 884);
            label3.Name = "label3";
            label3.Size = new Size(62, 28);
            label3.TabIndex = 16;
            label3.Text = "Plot :";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(73, 60, 52);
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.6851215F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.3158455F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.6831951F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.3158455F));
            tableLayoutPanel1.Controls.Add(title_label, 0, 0);
            tableLayoutPanel1.Controls.Add(title_textBox, 1, 0);
            tableLayoutPanel1.Controls.Add(isbn_label, 0, 1);
            tableLayoutPanel1.Controls.Add(isbn_textBox, 1, 1);
            tableLayoutPanel1.Controls.Add(category_label, 0, 2);
            tableLayoutPanel1.Controls.Add(comboBox1, 1, 2);
            tableLayoutPanel1.Controls.Add(price_label, 2, 0);
            tableLayoutPanel1.Controls.Add(price_textBox, 3, 0);
            tableLayoutPanel1.Controls.Add(cover_label, 2, 1);
            tableLayoutPanel1.Controls.Add(cover_textBox, 3, 1);
            tableLayoutPanel1.Location = new Point(49, 71);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(734, 195);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // title_label
            // 
            title_label.Anchor = AnchorStyles.Left;
            title_label.AutoSize = true;
            title_label.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            title_label.ForeColor = Color.PapayaWhip;
            title_label.Location = new Point(3, 18);
            title_label.Name = "title_label";
            title_label.Size = new Size(60, 28);
            title_label.TabIndex = 7;
            title_label.Text = "Title:";
            // 
            // title_textBox
            // 
            title_textBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            title_textBox.BackColor = Color.PapayaWhip;
            title_textBox.Font = new Font("Candara", 12F);
            title_textBox.Location = new Point(118, 16);
            title_textBox.Margin = new Padding(3, 4, 3, 4);
            title_textBox.Name = "title_textBox";
            title_textBox.Size = new Size(245, 31);
            title_textBox.TabIndex = 1;
            // 
            // isbn_label
            // 
            isbn_label.Anchor = AnchorStyles.Left;
            isbn_label.AutoSize = true;
            isbn_label.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            isbn_label.ForeColor = Color.PapayaWhip;
            isbn_label.Location = new Point(3, 82);
            isbn_label.Name = "isbn_label";
            isbn_label.Size = new Size(65, 28);
            isbn_label.TabIndex = 15;
            isbn_label.Text = "ISBN:";
            // 
            // isbn_textBox
            // 
            isbn_textBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            isbn_textBox.BackColor = Color.PapayaWhip;
            isbn_textBox.Font = new Font("Candara", 12F);
            isbn_textBox.Location = new Point(118, 80);
            isbn_textBox.Margin = new Padding(3, 4, 3, 4);
            isbn_textBox.Name = "isbn_textBox";
            isbn_textBox.Size = new Size(245, 31);
            isbn_textBox.TabIndex = 14;
            // 
            // category_label
            // 
            category_label.Anchor = AnchorStyles.Left;
            category_label.AutoSize = true;
            category_label.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            category_label.ForeColor = Color.PapayaWhip;
            category_label.Location = new Point(3, 147);
            category_label.Name = "category_label";
            category_label.Size = new Size(106, 28);
            category_label.TabIndex = 9;
            category_label.Text = "Category:";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Left;
            comboBox1.BackColor = Color.PapayaWhip;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Candara", 14.25F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Horror", "Science Fiction", "Romance", "Mystery" });
            comboBox1.Location = new Point(118, 143);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(244, 36);
            comboBox1.TabIndex = 16;
            // 
            // price_label
            // 
            price_label.Anchor = AnchorStyles.Left;
            price_label.AutoSize = true;
            price_label.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            price_label.ForeColor = Color.PapayaWhip;
            price_label.Location = new Point(369, 18);
            price_label.Name = "price_label";
            price_label.Size = new Size(66, 28);
            price_label.TabIndex = 13;
            price_label.Text = "Price:";
            // 
            // price_textBox
            // 
            price_textBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            price_textBox.BackColor = Color.PapayaWhip;
            price_textBox.Font = new Font("Candara", 12F);
            price_textBox.Location = new Point(484, 16);
            price_textBox.Margin = new Padding(3, 4, 3, 4);
            price_textBox.Name = "price_textBox";
            price_textBox.Size = new Size(247, 31);
            price_textBox.TabIndex = 12;
            // 
            // cover_label
            // 
            cover_label.Anchor = AnchorStyles.Left;
            cover_label.AutoSize = true;
            cover_label.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cover_label.ForeColor = Color.PapayaWhip;
            cover_label.Location = new Point(369, 82);
            cover_label.Name = "cover_label";
            cover_label.Size = new Size(75, 28);
            cover_label.TabIndex = 11;
            cover_label.Text = "Cover:";
            // 
            // cover_textBox
            // 
            cover_textBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cover_textBox.BackColor = Color.PapayaWhip;
            cover_textBox.Font = new Font("Candara", 12F);
            cover_textBox.Location = new Point(484, 80);
            cover_textBox.Margin = new Padding(3, 4, 3, 4);
            cover_textBox.Name = "cover_textBox";
            cover_textBox.Size = new Size(247, 31);
            cover_textBox.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.PapayaWhip;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(73, 60, 52);
            label2.Location = new Point(158, 134);
            label2.Name = "label2";
            label2.Size = new Size(105, 28);
            label2.TabIndex = 4;
            label2.Text = "Author ✔";
            // 
            // authorUsernameLabel
            // 
            authorUsernameLabel.AutoSize = true;
            authorUsernameLabel.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            authorUsernameLabel.ForeColor = Color.PapayaWhip;
            authorUsernameLabel.Location = new Point(158, 80);
            authorUsernameLabel.Name = "authorUsernameLabel";
            authorUsernameLabel.Size = new Size(131, 28);
            authorUsernameLabel.TabIndex = 6;
            authorUsernameLabel.Text = "@username";
            // 
            // AuthorPage
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Tan;
            ClientSize = new Size(1455, 907);
            Controls.Add(scroll_panel2);
            Controls.Add(profCover);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AuthorPage";
            Text = "AuthorPage";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)profCover).EndInit();
            scroll_panel2.ResumeLayout(false);
            scroll_panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox profCover;
        private Panel scroll_panel2;
        private PictureBox pictureBox2;
        private Label authorNameLabel;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button AddBookButton;
        private RichTextBox plot_richTextBox;
        private Label label1;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel1;
        private Label cover_label;
        private TextBox cover_textBox;
        private Label isbn_label;
        private TextBox isbn_textBox;
        private Label price_label;
        private TextBox price_textBox;
        private Label category_label;
        private Label title_label;
        private TextBox title_textBox;
        private Label label2;
        private Label authorUsernameLabel;
        private Label label4;
        private ComboBox comboBox1;
        private Label label5;
        private RichTextBox statisticsContainer;
        private FlowLayoutPanel statisticsPanel;
    }
}