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
            statusStrip1 = new StatusStrip();
            tsProgressBar = new ToolStripProgressBar();
            lblAtatus = new ToolStripStatusLabel();
            process1 = new System.Diagnostics.Process();
            linkLabel1 = new LinkLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picEyeHide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picEyeShow).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 165, 172);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(366, 600);
            panel1.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Rockwell", 9F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(150, 579);
            label7.Name = "label7";
            label7.Size = new Size(55, 18);
            label7.TabIndex = 2;
            label7.Text = "v 0.1.0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            label6.Location = new Point(50, 404);
            label6.Name = "label6";
            label6.Size = new Size(257, 74);
            label6.TabIndex = 1;
            label6.Text = "Hotel Management\r\nSystem";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(74, 57);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(213, 301);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.White;
            txtUserName.Font = new Font("Maiandra GD", 12F, FontStyle.Bold);
            txtUserName.Location = new Point(509, 229);
            txtUserName.Margin = new Padding(3, 4, 3, 4);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "User name";
            txtUserName.Size = new Size(269, 39);
            txtUserName.TabIndex = 1;
            txtUserName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.Font = new Font("Maiandra GD", 9.75F, FontStyle.Bold);
            txtPassword.Location = new Point(509, 344);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '⚫';
            txtPassword.PlaceholderText = "⚫⚫⚫⚫";
            txtPassword.Size = new Size(269, 39);
            txtPassword.TabIndex = 2;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(51, 165, 172);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.FromArgb(0, 69, 202);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 126, 222);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Maiandra GD", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(549, 437);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(192, 53);
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
            pictureBox1.Location = new Point(858, 3);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 192, 192);
            label1.Location = new Point(594, 111);
            label1.Name = "label1";
            label1.Size = new Size(92, 41);
            label1.TabIndex = 5;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Calibri", 9.75F, FontStyle.Bold);
            label2.Location = new Point(509, 191);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 6;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Calibri", 9.75F, FontStyle.Bold);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(587, 178);
            label3.Name = "label3";
            label3.Size = new Size(18, 21);
            label3.TabIndex = 7;
            label3.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Calibri", 9.75F, FontStyle.Bold);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(580, 290);
            label4.Name = "label4";
            label4.Size = new Size(18, 21);
            label4.TabIndex = 9;
            label4.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Calibri", 9.75F, FontStyle.Bold);
            label5.Location = new Point(509, 300);
            label5.Name = "label5";
            label5.Size = new Size(78, 21);
            label5.TabIndex = 8;
            label5.Text = "Password";
            // 
            // picEyeHide
            // 
            picEyeHide.BackColor = Color.Transparent;
            picEyeHide.Image = (Image)resources.GetObject("picEyeHide.Image");
            picEyeHide.Location = new Point(742, 345);
            picEyeHide.Margin = new Padding(3, 4, 3, 4);
            picEyeHide.Name = "picEyeHide";
            picEyeHide.Size = new Size(32, 35);
            picEyeHide.SizeMode = PictureBoxSizeMode.Zoom;
            picEyeHide.TabIndex = 10;
            picEyeHide.TabStop = false;
            picEyeHide.Click += picEyeHide_Click;
            // 
            // picEyeShow
            // 
            picEyeShow.BackColor = Color.Transparent;
            picEyeShow.Image = (Image)resources.GetObject("picEyeShow.Image");
            picEyeShow.Location = new Point(742, 345);
            picEyeShow.Margin = new Padding(3, 4, 3, 4);
            picEyeShow.Name = "picEyeShow";
            picEyeShow.Size = new Size(32, 35);
            picEyeShow.SizeMode = PictureBoxSizeMode.Zoom;
            picEyeShow.TabIndex = 11;
            picEyeShow.TabStop = false;
            picEyeShow.Visible = false;
            picEyeShow.Click += picEyeShow_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { tsProgressBar, lblAtatus });
            statusStrip1.Location = new Point(0, 573);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.RenderMode = ToolStripRenderMode.Professional;
            statusStrip1.Size = new Size(914, 27);
            statusStrip1.TabIndex = 12;
            statusStrip1.Text = "statusStrip1";
            // 
            // tsProgressBar
            // 
            tsProgressBar.Name = "tsProgressBar";
            tsProgressBar.Size = new Size(114, 19);
            // 
            // lblAtatus
            // 
            lblAtatus.Font = new Font("Calisto MT", 9F, FontStyle.Bold);
            lblAtatus.ForeColor = Color.DarkGreen;
            lblAtatus.Name = "lblAtatus";
            lblAtatus.Size = new Size(78, 21);
            lblAtatus.Text = "Connected";
            // 
            // process1
            // 
            process1.StartInfo.Domain = "";
            process1.StartInfo.LoadUserProfile = false;
            process1.StartInfo.Password = null;
            process1.StartInfo.StandardErrorEncoding = null;
            process1.StartInfo.StandardInputEncoding = null;
            process1.StartInfo.StandardOutputEncoding = null;
            process1.StartInfo.UseCredentialsForNetworkingOnly = false;
            process1.StartInfo.UserName = "";
            process1.SynchronizingObject = this;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(610, 511);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(73, 24);
            linkLabel1.TabIndex = 13;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign Up";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(914, 600);
            Controls.Add(linkLabel1);
            Controls.Add(statusStrip1);
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
            Margin = new Padding(3, 4, 3, 4);
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
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
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
        private StatusStrip statusStrip1;
        private ToolStripProgressBar tsProgressBar;
        private ToolStripStatusLabel lblAtatus;
        private System.Diagnostics.Process process1;
        private LinkLabel linkLabel1;
    }
}