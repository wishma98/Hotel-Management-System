﻿namespace Hotel_Management_System
{
    partial class reservations
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
            label5 = new Label();
            label4 = new Label();
            label17 = new Label();
            label16 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            lblAmount = new Label();
            lblStart = new Label();
            lblRoom = new Label();
            label12 = new Label();
            label1 = new Label();
            label11 = new Label();
            txtAmount = new TextBox();
            comboRoomType = new ComboBox();
            lblName = new Label();
            txtName = new TextBox();
            label6 = new Label();
            btnClear = new Button();
            btnAdd = new Button();
            label3 = new Label();
            lblHeader = new Label();
            dataGridView1 = new DataGridView();
            lblEnd = new Label();
            dateTimePicker2 = new DateTimePicker();
            label9 = new Label();
            label10 = new Label();
            lblMethord = new Label();
            label7 = new Label();
            label8 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(33, 697);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 90;
            label5.Text = "Amount";
            label5.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(91, 686);
            label4.Name = "label4";
            label4.Size = new Size(15, 20);
            label4.TabIndex = 105;
            label4.Text = "*";
            label4.UseWaitCursor = true;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = Color.Red;
            label17.ImeMode = ImeMode.NoControl;
            label17.Location = new Point(104, 301);
            label17.Name = "label17";
            label17.Size = new Size(15, 20);
            label17.TabIndex = 106;
            label17.Text = "*";
            label17.UseWaitCursor = true;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ImeMode = ImeMode.NoControl;
            label16.Location = new Point(33, 309);
            label16.Name = "label16";
            label16.Size = new Size(76, 20);
            label16.TabIndex = 102;
            label16.Text = "Start Date";
            label16.UseWaitCursor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(211, 541);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(53, 24);
            radioButton2.TabIndex = 115;
            radioButton2.TabStop = true;
            radioButton2.Text = "Full";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.UseWaitCursor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(33, 541);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(87, 24);
            radioButton1.TabIndex = 114;
            radioButton1.TabStop = true;
            radioButton1.Text = "Advance";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.UseWaitCursor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(33, 338);
            dateTimePicker1.MaximumSize = new Size(172, 27);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(172, 27);
            dateTimePicker1.TabIndex = 113;
            dateTimePicker1.UseWaitCursor = true;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Segoe UI", 7F);
            lblAmount.ForeColor = Color.Red;
            lblAmount.Location = new Point(33, 765);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(121, 15);
            lblAmount.TabIndex = 112;
            lblAmount.Text = "This field is requiered.";
            lblAmount.UseWaitCursor = true;
            lblAmount.Visible = false;
            // 
            // lblStart
            // 
            lblStart.AutoSize = true;
            lblStart.Font = new Font("Segoe UI", 7F);
            lblStart.ForeColor = Color.Red;
            lblStart.Location = new Point(33, 368);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(121, 15);
            lblStart.TabIndex = 110;
            lblStart.Text = "This field is requiered.";
            lblStart.UseWaitCursor = true;
            lblStart.Visible = false;
            // 
            // lblRoom
            // 
            lblRoom.AutoSize = true;
            lblRoom.Font = new Font("Segoe UI", 7F);
            lblRoom.ForeColor = Color.Red;
            lblRoom.Location = new Point(33, 276);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(121, 15);
            lblRoom.TabIndex = 108;
            lblRoom.Text = "This field is requiered.";
            lblRoom.UseWaitCursor = true;
            lblRoom.Visible = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Red;
            label12.ImeMode = ImeMode.NoControl;
            label12.Location = new Point(100, 209);
            label12.Name = "label12";
            label12.Size = new Size(15, 20);
            label12.TabIndex = 107;
            label12.Text = "*";
            label12.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(33, 217);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 103;
            label1.Text = "Room No";
            label1.UseWaitCursor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ImeMode = ImeMode.NoControl;
            label11.Location = new Point(33, 503);
            label11.Name = "label11";
            label11.Size = new Size(100, 20);
            label11.TabIndex = 101;
            label11.Text = "Payment Type";
            label11.UseWaitCursor = true;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(33, 728);
            txtAmount.Multiline = true;
            txtAmount.Name = "txtAmount";
            txtAmount.PlaceholderText = "Amount";
            txtAmount.Size = new Size(336, 34);
            txtAmount.TabIndex = 93;
            txtAmount.UseWaitCursor = true;
            txtAmount.TextChanged += txtAmount_TextChanged;
            // 
            // comboRoomType
            // 
            comboRoomType.BackColor = Color.White;
            comboRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboRoomType.FormattingEnabled = true;
            comboRoomType.ItemHeight = 20;
            comboRoomType.Location = new Point(33, 245);
            comboRoomType.Name = "comboRoomType";
            comboRoomType.Size = new Size(336, 28);
            comboRoomType.TabIndex = 104;
            comboRoomType.UseWaitCursor = true;
            comboRoomType.SelectedIndexChanged += comboRoomType_SelectedIndexChanged;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 7F);
            lblName.ForeColor = Color.Red;
            lblName.Location = new Point(33, 184);
            lblName.Name = "lblName";
            lblName.Size = new Size(121, 15);
            lblName.TabIndex = 109;
            lblName.Text = "This field is requiered.";
            lblName.UseWaitCursor = true;
            lblName.Visible = false;
            // 
            // txtName
            // 
            txtName.Location = new Point(33, 147);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name";
            txtName.Size = new Size(336, 34);
            txtName.TabIndex = 99;
            txtName.UseWaitCursor = true;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.ImeMode = ImeMode.NoControl;
            label6.Location = new Point(113, 104);
            label6.Name = "label6";
            label6.Size = new Size(15, 20);
            label6.TabIndex = 98;
            label6.Text = "*";
            label6.UseWaitCursor = true;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.FlatAppearance.BorderColor = Color.DarkGray;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ImeMode = ImeMode.NoControl;
            btnClear.Location = new Point(33, 807);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(158, 47);
            btnClear.TabIndex = 96;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.UseWaitCursor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkSlateGray;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.ImeMode = ImeMode.NoControl;
            btnAdd.Location = new Point(211, 807);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(158, 47);
            btnAdd.TabIndex = 94;
            btnAdd.Text = "Update";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.UseWaitCursor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(33, 116);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 91;
            label3.Text = "Client name";
            label3.UseWaitCursor = true;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(22, 22);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(264, 54);
            lblHeader.TabIndex = 89;
            lblHeader.Text = "Reservations";
            lblHeader.UseWaitCursor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(450, 104);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1111, 750);
            dataGridView1.TabIndex = 95;
            dataGridView1.UseWaitCursor = true;
            dataGridView1.RowHeaderMouseClick += gridDataClient_RowHeaderMouseClick;
            // 
            // lblEnd
            // 
            lblEnd.AutoSize = true;
            lblEnd.Font = new Font("Segoe UI", 7F);
            lblEnd.ForeColor = Color.Red;
            lblEnd.Location = new Point(33, 463);
            lblEnd.Name = "lblEnd";
            lblEnd.Size = new Size(121, 15);
            lblEnd.TabIndex = 110;
            lblEnd.Text = "This field is requiered.";
            lblEnd.UseWaitCursor = true;
            lblEnd.Visible = false;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(33, 433);
            dateTimePicker2.MaximumSize = new Size(172, 27);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(172, 27);
            dateTimePicker2.TabIndex = 113;
            dateTimePicker2.UseWaitCursor = true;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ImeMode = ImeMode.NoControl;
            label9.Location = new Point(33, 404);
            label9.Name = "label9";
            label9.Size = new Size(70, 20);
            label9.TabIndex = 102;
            label9.Text = "End Date";
            label9.UseWaitCursor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Red;
            label10.ImeMode = ImeMode.NoControl;
            label10.Location = new Point(98, 396);
            label10.Name = "label10";
            label10.Size = new Size(15, 20);
            label10.TabIndex = 106;
            label10.Text = "*";
            label10.UseWaitCursor = true;
            // 
            // lblMethord
            // 
            lblMethord.AutoSize = true;
            lblMethord.Font = new Font("Segoe UI", 7F);
            lblMethord.ForeColor = Color.Red;
            lblMethord.Location = new Point(33, 658);
            lblMethord.Name = "lblMethord";
            lblMethord.Size = new Size(121, 15);
            lblMethord.TabIndex = 112;
            lblMethord.Text = "This field is requiered.";
            lblMethord.UseWaitCursor = true;
            lblMethord.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.ImeMode = ImeMode.NoControl;
            label7.Location = new Point(154, 579);
            label7.Name = "label7";
            label7.Size = new Size(15, 20);
            label7.TabIndex = 105;
            label7.Text = "*";
            label7.UseWaitCursor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ImeMode = ImeMode.NoControl;
            label8.Location = new Point(33, 590);
            label8.Name = "label8";
            label8.Size = new Size(126, 20);
            label8.TabIndex = 90;
            label8.Text = "Payment methord";
            label8.UseWaitCursor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(211, 622);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(62, 24);
            checkBox1.TabIndex = 117;
            checkBox1.Text = "Card";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(33, 622);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(62, 24);
            checkBox2.TabIndex = 117;
            checkBox2.Text = "Cash";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // reservations
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label10);
            Controls.Add(label17);
            Controls.Add(label9);
            Controls.Add(label16);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblEnd);
            Controls.Add(lblMethord);
            Controls.Add(lblAmount);
            Controls.Add(lblStart);
            Controls.Add(lblRoom);
            Controls.Add(label12);
            Controls.Add(label1);
            Controls.Add(label11);
            Controls.Add(txtAmount);
            Controls.Add(comboRoomType);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(lblHeader);
            Controls.Add(dataGridView1);
            Name = "reservations";
            Size = new Size(1478, 884);
            Load += reservations_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private Label label17;
        private Label label16;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private DateTimePicker dateTimePicker1;
        private Label lblAmount;
        private Label lblStart;
        private Label lblRoom;
        private Label label12;
        private Label label1;
        private Label label11;
        private TextBox txtAmount;
        private ComboBox comboRoomType;
        private Label lblName;
        private TextBox txtName;
        private Label label6;
        private Button btnClear;
        private Button btnAdd;
        private Label label3;
        private Label lblHeader;
        private DataGridView dataGridView1;
        private Label lblEnd;
        private DateTimePicker dateTimePicker2;
        private Label label9;
        private Label label10;
        private Label lblMethord;
        private Label label7;
        private Label label8;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
    }
}
