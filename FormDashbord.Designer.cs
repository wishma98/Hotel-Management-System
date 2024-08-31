
namespace Hotel_Management_System
{
    partial class FormDashbord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashbord));
            panel4 = new Panel();
            labelUsername = new Label();
            label3 = new Label();
            panel5 = new Panel();
            linkLabellogout = new LinkLabel();
            pictureBox1 = new PictureBox();
            buttonDash = new Button();
            buttonCli = new Button();
            buttonRoom = new Button();
            buttonRes = new Button();
            panel2 = new Panel();
            dashboard1 = new dashboard();
            add_rooms1 = new add_rooms();
            client1 = new client();
            addReservations1 = new addReservations();
            reservations2 = new reservations();
            panel3 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            panel6 = new Panel();
            buttonAddRes = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(51, 165, 172);
            panel4.Controls.Add(labelUsername);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(327, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1050, 183);
            panel4.TabIndex = 0;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUsername.ForeColor = Color.White;
            labelUsername.Location = new Point(158, 122);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(31, 37);
            labelUsername.TabIndex = 4;
            labelUsername.Text = "?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(6, 122);
            label3.Name = "label3";
            label3.Size = new Size(155, 37);
            label3.TabIndex = 3;
            label3.Text = "Welcome : ";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel5.BackColor = Color.White;
            panel5.Controls.Add(linkLabellogout);
            panel5.Controls.Add(pictureBox1);
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1050, 99);
            panel5.TabIndex = 0;
            // 
            // linkLabellogout
            // 
            linkLabellogout.ActiveLinkColor = Color.FromArgb(51, 165, 172);
            linkLabellogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            linkLabellogout.AutoSize = true;
            linkLabellogout.DisabledLinkColor = Color.FromArgb(51, 165, 172);
            linkLabellogout.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabellogout.LinkColor = Color.FromArgb(51, 165, 172);
            linkLabellogout.Location = new Point(948, 36);
            linkLabellogout.Name = "linkLabellogout";
            linkLabellogout.Size = new Size(91, 28);
            linkLabellogout.TabIndex = 0;
            linkLabellogout.TabStop = true;
            linkLabellogout.Text = "Log Out";
            linkLabellogout.TextAlign = ContentAlignment.TopRight;
            linkLabellogout.VisitedLinkColor = Color.FromArgb(51, 165, 172);
            linkLabellogout.LinkClicked += linkLabellogout_LinkClicked_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(863, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // buttonDash
            // 
            buttonDash.FlatAppearance.BorderSize = 0;
            buttonDash.FlatStyle = FlatStyle.Flat;
            buttonDash.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDash.ForeColor = Color.White;
            buttonDash.Image = (Image)resources.GetObject("buttonDash.Image");
            buttonDash.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDash.Location = new Point(45, 234);
            buttonDash.Name = "buttonDash";
            buttonDash.Size = new Size(282, 63);
            buttonDash.TabIndex = 1;
            buttonDash.Text = "    Dashboard";
            buttonDash.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonDash.UseVisualStyleBackColor = true;
            buttonDash.Click += buttonDash_Click;
            // 
            // buttonCli
            // 
            buttonCli.FlatAppearance.BorderSize = 0;
            buttonCli.FlatStyle = FlatStyle.Flat;
            buttonCli.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCli.ForeColor = Color.White;
            buttonCli.Image = (Image)resources.GetObject("buttonCli.Image");
            buttonCli.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCli.Location = new Point(45, 302);
            buttonCli.Name = "buttonCli";
            buttonCli.Size = new Size(282, 63);
            buttonCli.TabIndex = 2;
            buttonCli.Text = "    Client";
            buttonCli.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCli.UseVisualStyleBackColor = true;
            buttonCli.Click += buttonCli_Click;
            // 
            // buttonRoom
            // 
            buttonRoom.FlatAppearance.BorderSize = 0;
            buttonRoom.FlatStyle = FlatStyle.Flat;
            buttonRoom.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRoom.ForeColor = Color.White;
            buttonRoom.Image = (Image)resources.GetObject("buttonRoom.Image");
            buttonRoom.ImageAlign = ContentAlignment.MiddleLeft;
            buttonRoom.Location = new Point(45, 370);
            buttonRoom.Name = "buttonRoom";
            buttonRoom.Size = new Size(282, 63);
            buttonRoom.TabIndex = 3;
            buttonRoom.Text = "    Room";
            buttonRoom.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonRoom.UseVisualStyleBackColor = true;
            buttonRoom.Click += buttonRoom_Click;
            // 
            // buttonRes
            // 
            buttonRes.FlatAppearance.BorderSize = 0;
            buttonRes.FlatStyle = FlatStyle.Flat;
            buttonRes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRes.ForeColor = Color.White;
            buttonRes.Image = (Image)resources.GetObject("buttonRes.Image");
            buttonRes.ImageAlign = ContentAlignment.MiddleLeft;
            buttonRes.Location = new Point(45, 439);
            buttonRes.Name = "buttonRes";
            buttonRes.Size = new Size(282, 63);
            buttonRes.TabIndex = 4;
            buttonRes.Text = "    Reservation";
            buttonRes.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonRes.UseVisualStyleBackColor = true;
            buttonRes.Click += buttonRes_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dashboard1);
            panel2.Controls.Add(add_rooms1);
            panel2.Controls.Add(client1);
            panel2.Controls.Add(addReservations1);
            panel2.Controls.Add(reservations2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(327, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1050, 692);
            panel2.TabIndex = 0;
            // 
            // dashboard1
            // 
            dashboard1.BackColor = Color.White;
            dashboard1.BorderStyle = BorderStyle.FixedSingle;
            dashboard1.Location = new Point(0, 183);
            dashboard1.Name = "dashboard1";
            dashboard1.Size = new Size(1848, 1065);
            dashboard1.TabIndex = 9;
            // 
            // add_rooms1
            // 
            add_rooms1.BackColor = Color.White;
            add_rooms1.Location = new Point(3, 183);
            add_rooms1.Name = "add_rooms1";
            add_rooms1.Size = new Size(1848, 978);
            add_rooms1.TabIndex = 2;
            // 
            // client1
            // 
            client1.AutoScroll = true;
            client1.AutoScrollMinSize = new Size(1259, 653);
            client1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            client1.BackColor = Color.White;
            client1.Location = new Point(0, 183);
            client1.Name = "client1";
            client1.Size = new Size(1821, 1079);
            client1.TabIndex = 10;
            client1.UseWaitCursor = true;
            // 
            // addReservations1
            // 
            addReservations1.BackColor = Color.White;
            addReservations1.Location = new Point(0, 183);
            addReservations1.Name = "addReservations1";
            addReservations1.Size = new Size(1848, 1105);
            addReservations1.TabIndex = 11;
            // 
            // reservations2
            // 
            reservations2.BackColor = Color.White;
            reservations2.Location = new Point(0, 183);
            reservations2.Name = "reservations2";
            reservations2.Size = new Size(1848, 1105);
            reservations2.TabIndex = 12;
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(327, 183);
            panel3.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(110, 137);
            label2.Name = "label2";
            label2.Size = new Size(106, 37);
            label2.TabIndex = 2;
            label2.Text = "System";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(35, 105);
            label1.Name = "label1";
            label1.Size = new Size(257, 37);
            label1.TabIndex = 1;
            label1.Text = "Hotel Management";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.D_logo;
            pictureBox2.Location = new Point(34, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(259, 99);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 165, 172);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(buttonDash);
            panel1.Controls.Add(buttonCli);
            panel1.Controls.Add(buttonRoom);
            panel1.Controls.Add(buttonAddRes);
            panel1.Controls.Add(buttonRes);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(327, 692);
            panel1.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Location = new Point(327, 183);
            panel6.Name = "panel6";
            panel6.Size = new Size(952, 487);
            panel6.TabIndex = 6;
            // 
            // buttonAddRes
            // 
            buttonAddRes.FlatAppearance.BorderSize = 0;
            buttonAddRes.FlatStyle = FlatStyle.Flat;
            buttonAddRes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAddRes.ForeColor = Color.White;
            buttonAddRes.Image = (Image)resources.GetObject("buttonAddRes.Image");
            buttonAddRes.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddRes.Location = new Point(42, 508);
            buttonAddRes.Name = "buttonAddRes";
            buttonAddRes.Size = new Size(282, 63);
            buttonAddRes.TabIndex = 4;
            buttonAddRes.Text = "    Add Reservation";
            buttonAddRes.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAddRes.UseVisualStyleBackColor = true;
            buttonAddRes.Click += buttonAddRes_Click;
            // 
            // FormDashbord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1377, 692);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormDashbord";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += FormDashbord_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }


        #endregion
        private Panel panel4;
        private Panel panel5;
        private PictureBox pictureBox1;
        private LinkLabel linkLabellogout;
        private Label label3;
        private Label labelUsername;
        private Button buttonDash;
        private Button buttonRes;
        private Button buttonRoom;
        private Button buttonCli;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Panel panel6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private add_rooms add_rooms1;
        private dashboard dashboard1;
        private client client1;
        private Button buttonAddRes;
        private addReservations reservations1;
        private addReservations addReservations1;
        private reservations reservations2;
    }
}