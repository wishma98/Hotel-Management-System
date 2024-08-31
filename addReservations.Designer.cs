namespace Hotel_Management_System
{
    partial class addReservations
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
            lblHeader = new Label();
            label5 = new Label();
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
            lblId = new Label();
            lblName = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            label7 = new Label();
            label6 = new Label();
            btnClear = new Button();
            dataGridView1 = new DataGridView();
            btnAdd = new Button();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            gridDataClient = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridDataClient).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(15, 21);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(353, 54);
            lblHeader.TabIndex = 49;
            lblHeader.Text = "Add Reservations";
            lblHeader.UseWaitCursor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(26, 686);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 52;
            label5.Text = "Amount";
            label5.UseWaitCursor = true;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = Color.Red;
            label17.ImeMode = ImeMode.NoControl;
            label17.Location = new Point(105, 451);
            label17.Name = "label17";
            label17.Size = new Size(15, 20);
            label17.TabIndex = 74;
            label17.Text = "*";
            label17.UseWaitCursor = true;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ImeMode = ImeMode.NoControl;
            label16.Location = new Point(26, 459);
            label16.Name = "label16";
            label16.Size = new Size(76, 20);
            label16.TabIndex = 71;
            label16.Text = "Start Date";
            label16.UseWaitCursor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(204, 615);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(53, 24);
            radioButton2.TabIndex = 86;
            radioButton2.TabStop = true;
            radioButton2.Text = "Full";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.UseWaitCursor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged_1;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(26, 615);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(87, 24);
            radioButton1.TabIndex = 85;
            radioButton1.TabStop = true;
            radioButton1.Text = "Advance";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.UseWaitCursor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(26, 488);
            dateTimePicker1.MaximumSize = new Size(172, 27);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(172, 27);
            dateTimePicker1.TabIndex = 83;
            dateTimePicker1.UseWaitCursor = true;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Segoe UI", 7F);
            lblAmount.ForeColor = Color.Red;
            lblAmount.Location = new Point(26, 754);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(121, 15);
            lblAmount.TabIndex = 82;
            lblAmount.Text = "This field is requiered.";
            lblAmount.UseWaitCursor = true;
            lblAmount.Visible = false;
            // 
            // lblStart
            // 
            lblStart.AutoSize = true;
            lblStart.Font = new Font("Segoe UI", 7F);
            lblStart.ForeColor = Color.Red;
            lblStart.Location = new Point(26, 518);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(121, 15);
            lblStart.TabIndex = 79;
            lblStart.Text = "This field is requiered.";
            lblStart.UseWaitCursor = true;
            lblStart.Visible = false;
            // 
            // lblRoom
            // 
            lblRoom.AutoSize = true;
            lblRoom.Font = new Font("Segoe UI", 7F);
            lblRoom.ForeColor = Color.Red;
            lblRoom.Location = new Point(26, 416);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(121, 15);
            lblRoom.TabIndex = 77;
            lblRoom.Text = "This field is requiered.";
            lblRoom.UseWaitCursor = true;
            lblRoom.Visible = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Red;
            label12.ImeMode = ImeMode.NoControl;
            label12.Location = new Point(93, 349);
            label12.Name = "label12";
            label12.Size = new Size(15, 20);
            label12.TabIndex = 75;
            label12.Text = "*";
            label12.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(26, 357);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 72;
            label1.Text = "Room No";
            label1.UseWaitCursor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ImeMode = ImeMode.NoControl;
            label11.Location = new Point(26, 577);
            label11.Name = "label11";
            label11.Size = new Size(100, 20);
            label11.TabIndex = 70;
            label11.Text = "Payment Type";
            label11.UseWaitCursor = true;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(26, 717);
            txtAmount.Multiline = true;
            txtAmount.Name = "txtAmount";
            txtAmount.PlaceholderText = "Amount";
            txtAmount.Size = new Size(336, 34);
            txtAmount.TabIndex = 56;
            txtAmount.UseWaitCursor = true;
            txtAmount.TextChanged += txtAmount_TextChanged;
            // 
            // comboRoomType
            // 
            comboRoomType.BackColor = Color.White;
            comboRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboRoomType.FormattingEnabled = true;
            comboRoomType.ItemHeight = 20;
            comboRoomType.Items.AddRange(new object[] { "Please select Room No..." });
            comboRoomType.Location = new Point(26, 385);
            comboRoomType.Name = "comboRoomType";
            comboRoomType.Size = new Size(336, 28);
            comboRoomType.TabIndex = 73;
            comboRoomType.UseWaitCursor = true;
            comboRoomType.SelectedIndexChanged += comboRoomType_SelectedIndexChanged_1;
            comboRoomType.SelectedValueChanged += comboRoomType_SelectedIndexChanged;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 7F);
            lblId.ForeColor = Color.Red;
            lblId.Location = new Point(26, 303);
            lblId.Name = "lblId";
            lblId.Size = new Size(121, 15);
            lblId.TabIndex = 81;
            lblId.Text = "This field is requiered.";
            lblId.UseWaitCursor = true;
            lblId.Visible = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 7F);
            lblName.ForeColor = Color.Red;
            lblName.Location = new Point(26, 183);
            lblName.Name = "lblName";
            lblName.Size = new Size(121, 15);
            lblName.TabIndex = 78;
            lblName.Text = "This field is requiered.";
            lblName.UseWaitCursor = true;
            lblName.Visible = false;
            // 
            // txtId
            // 
            txtId.Location = new Point(26, 266);
            txtId.Multiline = true;
            txtId.Name = "txtId";
            txtId.PlaceholderText = "xxxxxxxxxx";
            txtId.Size = new Size(336, 34);
            txtId.TabIndex = 68;
            txtId.UseWaitCursor = true;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(26, 146);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name";
            txtName.Size = new Size(336, 34);
            txtName.TabIndex = 67;
            txtName.UseWaitCursor = true;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.ImeMode = ImeMode.NoControl;
            label7.Location = new Point(98, 220);
            label7.Name = "label7";
            label7.Size = new Size(15, 20);
            label7.TabIndex = 62;
            label7.Text = "*";
            label7.UseWaitCursor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.ImeMode = ImeMode.NoControl;
            label6.Location = new Point(106, 103);
            label6.Name = "label6";
            label6.Size = new Size(15, 20);
            label6.TabIndex = 66;
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
            btnClear.Location = new Point(26, 806);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(158, 47);
            btnClear.TabIndex = 60;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.UseWaitCursor = true;
            btnClear.Click += btnClear_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(443, 103);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1111, 750);
            dataGridView1.TabIndex = 59;
            dataGridView1.UseWaitCursor = true;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkSlateGray;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.ImeMode = ImeMode.NoControl;
            btnAdd.Location = new Point(204, 806);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(158, 47);
            btnAdd.TabIndex = 57;
            btnAdd.Text = "Save";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.UseWaitCursor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(26, 115);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 54;
            label3.Text = "Client name";
            label3.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(26, 232);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 55;
            label2.Text = "ID number";
            label2.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(84, 675);
            label4.Name = "label4";
            label4.Size = new Size(15, 20);
            label4.TabIndex = 74;
            label4.Text = "*";
            label4.UseWaitCursor = true;
            // 
            // gridDataClient
            // 
            gridDataClient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridDataClient.Location = new Point(443, 103);
            gridDataClient.Name = "gridDataClient";
            gridDataClient.RowHeadersWidth = 51;
            gridDataClient.Size = new Size(1111, 750);
            gridDataClient.TabIndex = 88;
            gridDataClient.RowHeaderMouseClick += gridDataClient_RowHeaderMouseClick;
            // 
            // addReservations
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblAmount);
            Controls.Add(lblStart);
            Controls.Add(lblRoom);
            Controls.Add(label12);
            Controls.Add(label1);
            Controls.Add(label11);
            Controls.Add(txtAmount);
            Controls.Add(comboRoomType);
            Controls.Add(lblId);
            Controls.Add(lblName);
            Controls.Add(txtId);
            Controls.Add(txtName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblHeader);
            Controls.Add(gridDataClient);
            Controls.Add(dataGridView1);
            Name = "addReservations";
            Size = new Size(1478, 884);
            Load += reservations_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridDataClient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblHeader;
        private Label label5;
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
        private Label lblId;
        private Label lblName;
        private TextBox txtId;
        private TextBox txtName;
        private Label label7;
        private Label label6;
        private Button btnClear;
        private DataGridView dataGridView1;
        private Button btnAdd;
        private Label label3;
        private Label label2;
        private Label label4;
        private DataGridView gridDataClient;
    }
}
