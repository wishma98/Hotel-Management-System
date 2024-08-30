namespace Hotel_Management_System
{
    partial class signup
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(51, 165, 171);
            label1.Location = new Point(39, 95);
            label1.Name = "label1";
            label1.Size = new Size(85, 19);
            label1.TabIndex = 0;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(51, 165, 171);
            label2.Location = new Point(39, 136);
            label2.Name = "label2";
            label2.Size = new Size(78, 19);
            label2.TabIndex = 1;
            label2.Text = "Full Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(51, 165, 171);
            label3.Location = new Point(39, 178);
            label3.Name = "label3";
            label3.Size = new Size(72, 19);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(51, 165, 171);
            label4.Location = new Point(39, 219);
            label4.Name = "label4";
            label4.Size = new Size(115, 19);
            label4.TabIndex = 3;
            label4.Text = "Mobile Number";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(161, 95);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(217, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(161, 136);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(217, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(161, 219);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(217, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(161, 178);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(217, 23);
            textBox4.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(51, 165, 171);
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(93, 283);
            button1.Name = "button1";
            button1.Size = new Size(89, 25);
            button1.TabIndex = 8;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(51, 165, 171);
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(224, 283);
            button2.Name = "button2";
            button2.Size = new Size(88, 25);
            button2.TabIndex = 9;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            // 
            // signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 335);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "signup";
            Text = "signup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
    }
}