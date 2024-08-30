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
            comboRoomType = new ComboBox();
            comboBedType = new ComboBox();
            txtPrice = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label10 = new Label();
            label11 = new Label();
            txtMeals = new TextBox();
            txtRoomNo = new TextBox();
            lblRoomType = new Label();
            lblRoomNo = new Label();
            lblBed = new Label();
            lblMeals = new Label();
            lblPrice = new Label();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 22);
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
            label7.Location = new Point(138, 216);
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
            label9.Location = new Point(69, 553);
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
            label8.Location = new Point(98, 341);
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
            label6.Location = new Point(112, 99);
            label6.Name = "label6";
            label6.Size = new Size(15, 20);
            label6.TabIndex = 22;
            label6.Text = "*";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.DarkGray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ImeMode = ImeMode.NoControl;
            button1.Location = new Point(33, 690);
            button1.Name = "button1";
            button1.Size = new Size(158, 52);
            button1.TabIndex = 18;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(453, 86);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1111, 750);
            dataGridView1.TabIndex = 17;
            dataGridView1.RowHeaderMouseDoubleClick += dataGridView1_RowHeaderMouseDoubleClick;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkSlateGray;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.ImeMode = ImeMode.NoControl;
            btnAdd.Location = new Point(211, 690);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(158, 52);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "Save";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // comboRoomType
            // 
            comboRoomType.BackColor = Color.White;
            comboRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboRoomType.FormattingEnabled = true;
            comboRoomType.ItemHeight = 20;
            comboRoomType.Items.AddRange(new object[] { "Single", "Family", "Custom" });
            comboRoomType.Location = new Point(33, 145);
            comboRoomType.Name = "comboRoomType";
            comboRoomType.Size = new Size(336, 28);
            comboRoomType.TabIndex = 14;
            comboRoomType.SelectedIndexChanged += comboType_SelectedIndexChanged;
            // 
            // comboBedType
            // 
            comboBedType.BackColor = Color.White;
            comboBedType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBedType.FormattingEnabled = true;
            comboBedType.ItemHeight = 20;
            comboBedType.Items.AddRange(new object[] { "Single", "Double" });
            comboBedType.Location = new Point(33, 389);
            comboBedType.Name = "comboBedType";
            comboBedType.Size = new Size(336, 28);
            comboBedType.TabIndex = 15;
            comboBedType.SelectedIndexChanged += comboBedType_SelectedIndexChanged;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(33, 602);
            txtPrice.Multiline = true;
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(336, 34);
            txtPrice.TabIndex = 12;
            txtPrice.TextChanged += txtPrice_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(33, 349);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 7;
            label4.Text = "Bed Type";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(33, 561);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 8;
            label5.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(33, 107);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 9;
            label3.Text = "Room Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(33, 224);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 10;
            label2.Text = "Room Number";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ImeMode = ImeMode.NoControl;
            label10.Location = new Point(33, 459);
            label10.Name = "label10";
            label10.Size = new Size(48, 20);
            label10.TabIndex = 7;
            label10.Text = "Meals";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Red;
            label11.ImeMode = ImeMode.NoControl;
            label11.Location = new Point(78, 448);
            label11.Name = "label11";
            label11.Size = new Size(15, 20);
            label11.TabIndex = 21;
            label11.Text = "*";
            // 
            // txtMeals
            // 
            txtMeals.Location = new Point(33, 493);
            txtMeals.Multiline = true;
            txtMeals.Name = "txtMeals";
            txtMeals.ReadOnly = true;
            txtMeals.Size = new Size(336, 34);
            txtMeals.TabIndex = 12;
            txtMeals.TextChanged += txtMeals_TextChanged;
            // 
            // txtRoomNo
            // 
            txtRoomNo.Location = new Point(33, 271);
            txtRoomNo.Multiline = true;
            txtRoomNo.Name = "txtRoomNo";
            txtRoomNo.Size = new Size(336, 34);
            txtRoomNo.TabIndex = 12;
            txtRoomNo.TextChanged += txtRoomNo_TextChanged;
            // 
            // lblRoomType
            // 
            lblRoomType.AutoSize = true;
            lblRoomType.Font = new Font("Segoe UI", 7F);
            lblRoomType.ForeColor = Color.Red;
            lblRoomType.Location = new Point(33, 176);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(121, 15);
            lblRoomType.TabIndex = 23;
            lblRoomType.Text = "This field is requiered.";
            lblRoomType.Visible = false;
            // 
            // lblRoomNo
            // 
            lblRoomNo.AutoSize = true;
            lblRoomNo.Font = new Font("Segoe UI", 7F);
            lblRoomNo.ForeColor = Color.Red;
            lblRoomNo.Location = new Point(33, 308);
            lblRoomNo.Name = "lblRoomNo";
            lblRoomNo.Size = new Size(121, 15);
            lblRoomNo.TabIndex = 23;
            lblRoomNo.Text = "This field is requiered.";
            lblRoomNo.Visible = false;
            // 
            // lblBed
            // 
            lblBed.AutoSize = true;
            lblBed.Font = new Font("Segoe UI", 7F);
            lblBed.ForeColor = Color.Red;
            lblBed.Location = new Point(33, 420);
            lblBed.Name = "lblBed";
            lblBed.Size = new Size(121, 15);
            lblBed.TabIndex = 23;
            lblBed.Text = "This field is requiered.";
            lblBed.Visible = false;
            // 
            // lblMeals
            // 
            lblMeals.AutoSize = true;
            lblMeals.Font = new Font("Segoe UI", 7F);
            lblMeals.ForeColor = Color.Red;
            lblMeals.Location = new Point(33, 530);
            lblMeals.Name = "lblMeals";
            lblMeals.Size = new Size(121, 15);
            lblMeals.TabIndex = 23;
            lblMeals.Text = "This field is requiered.";
            lblMeals.Visible = false;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 7F);
            lblPrice.ForeColor = Color.Red;
            lblPrice.Location = new Point(32, 639);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(121, 15);
            lblPrice.TabIndex = 23;
            lblPrice.Text = "This field is requiered.";
            lblPrice.Visible = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DimGray;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(33, 763);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(336, 62);
            btnDelete.TabIndex = 24;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // add_rooms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnDelete);
            Controls.Add(lblPrice);
            Controls.Add(lblMeals);
            Controls.Add(lblBed);
            Controls.Add(lblRoomNo);
            Controls.Add(lblRoomType);
            Controls.Add(label7);
            Controls.Add(label9);
            Controls.Add(label11);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(btnAdd);
            Controls.Add(comboRoomType);
            Controls.Add(comboBedType);
            Controls.Add(label10);
            Controls.Add(txtMeals);
            Controls.Add(txtRoomNo);
            Controls.Add(txtPrice);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "add_rooms";
            Size = new Size(1478, 852);
            Load += add_rooms_Load;
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
        private ComboBox comboRoomType;
        private ComboBox comboBedType;
        private TextBox txtPrice;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label10;
        private Label label11;
        private TextBox txtMeals;
        private TextBox txtRoomNo;
        private Label lblRoomType;
        private Label lblRoomNo;
        private Label lblBed;
        private Label lblMeals;
        private Label lblPrice;
        private Button btnDelete;
    }
}
