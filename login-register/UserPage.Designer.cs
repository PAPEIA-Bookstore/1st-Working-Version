namespace login_register
{
    partial class UserPage
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
            fullNameLabel = new Label();
            pictureBox1 = new PictureBox();
            usernameLabel = new Label();
            profCover = new PictureBox();
            shelfPanel = new FlowLayoutPanel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)profCover).BeginInit();
            SuspendLayout();
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Font = new Font("Candara", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fullNameLabel.ForeColor = Color.PapayaWhip;
            fullNameLabel.Location = new Point(169, 304);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(246, 42);
            fullNameLabel.TabIndex = 0;
            fullNameLabel.Text = "Name Surname";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(34, 304);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(127, 127);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameLabel.ForeColor = Color.PapayaWhip;
            usernameLabel.Location = new Point(169, 350);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(131, 28);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "@username";
            // 
            // profCover
            // 
            profCover.Image = Properties.Resources.profCover;
            profCover.Location = new Point(0, -4);
            profCover.Margin = new Padding(3, 4, 3, 4);
            profCover.Name = "profCover";
            profCover.Size = new Size(1455, 276);
            profCover.SizeMode = PictureBoxSizeMode.StretchImage;
            profCover.TabIndex = 4;
            profCover.TabStop = false;
            // 
            // shelfPanel
            // 
            shelfPanel.AutoScroll = true;
            shelfPanel.FlowDirection = FlowDirection.TopDown;
            shelfPanel.Location = new Point(54, 573);
            shelfPanel.Name = "shelfPanel";
            shelfPanel.Size = new Size(1359, 270);
            shelfPanel.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 21.913044F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 161);
            label1.ForeColor = Color.PapayaWhip;
            label1.Location = new Point(43, 528);
            label1.Name = "label1";
            label1.Size = new Size(168, 42);
            label1.TabIndex = 6;
            label1.Text = "Your Shelf";
            label1.Click += label1_Click;
            // 
            // UserPage
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(1275, 764);
            Controls.Add(label1);
            Controls.Add(shelfPanel);
            Controls.Add(profCover);
            Controls.Add(usernameLabel);
            Controls.Add(fullNameLabel);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserPage";
            Text = "UserPage";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)profCover).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label fullNameLabel;
        private PictureBox pictureBox1;
        private Label usernameLabel;
        private PictureBox profCover;
        private FlowLayoutPanel shelfPanel;
        private Label label1;
    }
}