namespace Hotel_Management_System
{
    partial class add_rooms
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label7 = new Label();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            btnAdd = new Button();
            comboType = new ComboBox();
            comboBedType = new ComboBox();
            txtPrice = new TextBox();
            txtRoomNo = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 3);
            label1.Name = "label1";
            label1.Size = new Size(240, 54);
            label1.TabIndex = 0;
            label1.Text = "Add Rooms";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.ImeMode = ImeMode.NoControl;
            label7.Location = new Point(149, 152);
            label7.Name = "label7";
            label7.Size = new Size(15, 20);
            label7.TabIndex = 19;
            label7.Text = "*";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Red;
            label9.ImeMode = ImeMode.NoControl;
            label9.Location = new Point(80, 319);
            label9.Name = "label9";
            label9.Size = new Size(15, 20);
            label9.TabIndex = 20;
            label9.Text = "*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.ImeMode = ImeMode.NoControl;
            label8.Location = new Point(109, 240);
            label8.Name = "label8";
            label8.Size = new Size(15, 20);
            label8.TabIndex = 21;
            label8.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.ImeMode = ImeMode.NoControl;
            label6.Location = new Point(114, 59);
            label6.Name = "label6";
            label6.Size = new Size(15, 20);
            label6.TabIndex = 22;
            label6.Text = "*";
            // 
            // button1
            // 
            button1.ImeMode = ImeMode.NoControl;
            button1.Location = new Point(44, 417);
            button1.Name = "button1";
            button1.Size = new Size(158, 52);
            button1.TabIndex = 18;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(445, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(555, 402);
            dataGridView1.TabIndex = 17;
            // 
            // btnAdd
            // 
            btnAdd.ImeMode = ImeMode.NoControl;
            btnAdd.Location = new Point(222, 417);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(158, 52);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "Save";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // comboType
            // 
            comboType.DropDownStyle = ComboBoxStyle.Simple;
            comboType.FormattingEnabled = true;
            comboType.ItemHeight = 20;
            comboType.Items.AddRange(new object[] { "Single", "Double" });
            comboType.Location = new Point(35, 105);
            comboType.Name = "comboType";
            comboType.Size = new Size(336, 28);
            comboType.TabIndex = 14;
            // 
            // comboBedType
            // 
            comboBedType.FormattingEnabled = true;
            comboBedType.ItemHeight = 20;
            comboBedType.Items.AddRange(new object[] { "Single", "Double" });
            comboBedType.Location = new Point(44, 288);
            comboBedType.Name = "comboBedType";
            comboBedType.Size = new Size(336, 28);
            comboBedType.TabIndex = 15;
            // 
            // txtPrice
            // 
            txtPrice.BorderStyle = BorderStyle.None;
            txtPrice.Location = new Point(44, 361);
            txtPrice.Multiline = true;
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(336, 34);
            txtPrice.TabIndex = 12;
            // 
            // txtRoomNo
            // 
            txtRoomNo.BorderStyle = BorderStyle.None;
            txtRoomNo.Location = new Point(44, 194);
            txtRoomNo.Multiline = true;
            txtRoomNo.Name = "txtRoomNo";
            txtRoomNo.Size = new Size(336, 34);
            txtRoomNo.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(44, 248);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 7;
            label4.Text = "Bed Type";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(44, 327);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 8;
            label5.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(35, 67);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 9;
            label3.Text = "Room Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(44, 160);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 10;
            label2.Text = "Room Number";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label10.ImeMode = ImeMode.NoControl;
            label10.Location = new Point(-27, -57);
            label10.Name = "label10";
            label10.Size = new Size(167, 41);
            label10.TabIndex = 11;
            label10.Text = "Add Room";
            // 
            // add_rooms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label7);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(btnAdd);
            Controls.Add(comboType);
            Controls.Add(comboBedType);
            Controls.Add(txtPrice);
            Controls.Add(txtRoomNo);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label10);
            Controls.Add(label1);
            Name = "add_rooms";
            Size = new Size(1021, 490);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label7;
        private Label label9;
        private Label label8;
        private Label label6;
        private Button button1;
        private DataGridView dataGridView1;
        private Button btnAdd;
        private ComboBox comboType;
        private ComboBox comboBedType;
        private TextBox txtPrice;
        private TextBox txtRoomNo;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label10;
    }
}
