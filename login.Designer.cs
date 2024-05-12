namespace Hotel_Management_System
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            panel1 = new Panel();
            label7 = new Label();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            picEyeHide = new PictureBox();
            picEyeShow = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picEyeHide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picEyeShow).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 69, 202);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(320, 450);
            panel1.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(131, 434);
            label7.Name = "label7";
            label7.Size = new Size(46, 14);
            label7.TabIndex = 2;
            label7.Text = "v 0.1.0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Imprint MT Shadow", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            label6.Location = new Point(44, 303);
            label6.Name = "label6";
            label6.Size = new Size(227, 56);
            label6.TabIndex = 1;
            label6.Text = "Hotel Management\r\nSystem";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(65, 43);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(186, 226);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.White;
            txtUserName.Font = new Font("Maiandra GD", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtUserName.Location = new Point(445, 172);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(236, 30);
            txtUserName.TabIndex = 1;
            txtUserName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.Font = new Font("Maiandra GD", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.Location = new Point(445, 258);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '⚫';
            txtPassword.Size = new Size(236, 30);
            txtPassword.TabIndex = 2;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 69, 202);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.FromArgb(0, 69, 202);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 126, 222);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Maiandra GD", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(480, 328);
            button1.Name = "button1";
            button1.Size = new Size(168, 40);
            button1.TabIndex = 3;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(751, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Lucida Fax", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(520, 83);
            label1.Name = "label1";
            label1.Size = new Size(94, 32);
            label1.TabIndex = 5;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(445, 143);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 6;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(509, 140);
            label3.Name = "label3";
            label3.Size = new Size(13, 15);
            label3.TabIndex = 7;
            label3.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(501, 222);
            label4.Name = "label4";
            label4.Size = new Size(13, 15);
            label4.TabIndex = 9;
            label4.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(445, 225);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 8;
            label5.Text = "Password";
            // 
            // picEyeHide
            // 
            picEyeHide.BackColor = Color.Transparent;
            picEyeHide.Image = (Image)resources.GetObject("picEyeHide.Image");
            picEyeHide.Location = new Point(649, 260);
            picEyeHide.Name = "picEyeHide";
            picEyeHide.Size = new Size(28, 26);
            picEyeHide.SizeMode = PictureBoxSizeMode.Zoom;
            picEyeHide.TabIndex = 10;
            picEyeHide.TabStop = false;
            picEyeHide.Click += picEyeHide_Click;
            // 
            // picEyeShow
            // 
            picEyeShow.BackColor = Color.Transparent;
            picEyeShow.Image = (Image)resources.GetObject("picEyeShow.Image");
            picEyeShow.Location = new Point(649, 260);
            picEyeShow.Name = "picEyeShow";
            picEyeShow.Size = new Size(28, 26);
            picEyeShow.SizeMode = PictureBoxSizeMode.Zoom;
            picEyeShow.TabIndex = 11;
            picEyeShow.TabStop = false;
            picEyeShow.Visible = false;
            picEyeShow.Click += picEyeShow_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(picEyeShow);
            Controls.Add(picEyeHide);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "login";
            Load += login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picEyeHide).EndInit();
            ((System.ComponentModel.ISupportInitialize)picEyeShow).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox2;
        private Label label7;
        private Label label6;
        private PictureBox picEyeHide;
        private PictureBox picEyeShow;
    }
}