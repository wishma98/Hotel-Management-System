using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Hotel_Management_System
{
    public partial class addReservations : UserControl
    {
        private string connectionString = "Data Source=localhost;Initial Catalog=master;Integrated Security=True";
        bool isSelectData = false;
        public int clientId = 0;
        public int roomId = 0;
        public decimal amount = 0;

        public addReservations()
        {
            InitializeComponent();
        }

        private void LoadDataIntoDataGridView()
        {
            string connectionString = "Data Source=localhost;Initial Catalog=hotel_management;Integrated Security=True;";
            string query = "SELECT reservation.reservationId, client.name AS clientName, reservation.clientId, reservation.roomId, rooms.roomNo, reservation.startDate, reservation.closeDate, reservation.paymentType, reservation.paymentMethord, reservation.paymentAmount FROM reservation INNER JOIN client ON reservation.clientId = client.clientId INNER JOIN rooms ON reservation.roomId = rooms.roomId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Bind the DataTable to the DataGridView
                        dataGridView1.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Ensure the click is on a valid row (not the header or a non-existent row)
            if (e.RowIndex >= 0)
            {
                txtName.Text = dataGridView1.Rows[e.RowIndex].Cells["name"].Value.ToString();
                txtId.Text = dataGridView1.Rows[e.RowIndex].Cells["idNo"].Value.ToString();

                btnAdd.Enabled = true;
                btnAdd.BackColor = Color.FromArgb(51, 165, 172);
                isSelectData = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                lblName.Visible = true;
            }
            if (txtId.Text == "")
            {
                lblId.Visible = true;
            }
            if (comboRoomType.Text == "")
            {
                lblRoom.Visible = true;
            }
            if (dateTimePicker1.Text == "")
            {
                lblStart.Visible = true;
            }
            if (txtAmount.Text == "")
            {
                lblAmount.Visible = true;
            }
            if (isSelectData && txtName.Text != "" && txtId.Text != "" && comboRoomType.Text != "" && dateTimePicker1.Text != "")
            {
                AddReservation();
            }
        }

        private void AddReservation()
        {
            string startDate, paymentType = "", paymentAmount = "0";

            startDate = dateTimePicker1.Text;
            paymentAmount = txtAmount.Text;

            if (radioButton1.Checked)
            {
                paymentType = "Advance";
            }
            if (radioButton2.Checked)
            {
                paymentType = "Full";
            }

            string query = $"INSERT INTO reservation (clientId, roomId, startDate, paymentType, paymentAmount) VALUES (@clientId, @roomId, @startDate, @paymentType, @paymentAmount);";
            string connectionStringWithDatabase = $"{connectionString};Initial Catalog=hotel_management";

            using (SqlConnection connection = new SqlConnection(connectionStringWithDatabase))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@clientId", clientId);
                    command.Parameters.AddWithValue("@roomId", roomId);
                    command.Parameters.AddWithValue("@startDate", startDate);
                    command.Parameters.AddWithValue("@paymentType", paymentType);
                    command.Parameters.AddWithValue("@paymentAmount", paymentAmount);

                    connection.Open();

                    int result = command.ExecuteNonQuery();
                    MessageBox.Show("Reservation added successfully!"+result);
                    if (result > 0)
                    {
                        MessageBox.Show("Reservation added successfully!");
                        gridDataClient.SendToBack();
                        dataGridView1.BringToFront();
                        LoadDataIntoDataGridView();
                        LoadDataIntoClientGridView();
                        clearAll();
                        isSelectData = false;
                    }
                }
            }
        }

        private void LoadDataIntoClientGridView()
        {
            string connectionString = "Data Source=localhost;Initial Catalog=hotel_management;Integrated Security=True;";
            string query = "SELECT * FROM client"; // Replace with your table name

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Bind the DataTable to the DataGridView
                        gridDataClient.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private int GetClientByIdNo(string idNo)
        {
            int getClientId = 0;
            string query = "SELECT clientId FROM client WHERE idNo = @idNo;";
            string connectionStringWithDatabase = $"{connectionString};Initial Catalog=hotel_management";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionStringWithDatabase))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add the parameter for idNo
                        command.Parameters.AddWithValue("@idNo", idNo);

                        // Open the connection
                        connection.Open();

                        // Execute the query
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Assuming you want to display or use these values
                                getClientId = reader.GetInt32(0);
                            }
                            else
                            {
                                MessageBox.Show("Client not found.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            return getClientId;
        }

        private void GetRoomIdByRoomNo(string roomNo)
        {
            int getRoomId = 0;
            string query = "SELECT roomId FROM rooms WHERE roomNo = @roomNo;";
            string connectionStringWithDatabase = $"{connectionString};Initial Catalog=hotel_management";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionStringWithDatabase))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add the parameter for idNo
                        command.Parameters.AddWithValue("@roomNo", roomNo);

                        // Open the connection
                        connection.Open();

                        // Execute the query
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Assuming you want to display or use these values
                                getRoomId = reader.GetInt32(0);
                            }
                            else
                            {
                                MessageBox.Show("Room not found.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            roomId = getRoomId;
        }

        private void GetRoomIdByRoomAmount(string roomNo)
        {
            decimal getRoomAmount = 0; // Changed to decimal to handle typical currency/price values
            string query = "SELECT price FROM rooms WHERE roomNo = @roomNo;";
            string connectionStringWithDatabase = $"{connectionString};Initial Catalog=hotel_management";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionStringWithDatabase))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add the parameter for roomNo
                        command.Parameters.AddWithValue("@roomNo", roomNo);

                        // Open the connection
                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            // Convert the result to decimal
                            getRoomAmount = Convert.ToDecimal(result);
                        }
                        else
                        {
                            MessageBox.Show("Room not found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            amount = getRoomAmount; // Ensure amount is of type decimal or adjust as needed
        }

        private void LoadRoomNumbersIntoComboBox()
        {
            string query = "SELECT roomNo FROM rooms";
            string connectionStringWithDatabase = $"{connectionString};Initial Catalog=hotel_management";

            comboRoomType.Items.Clear();

            using (SqlConnection connection = new SqlConnection(connectionStringWithDatabase))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboRoomType.Items.Add(reader["roomNo"].ToString());
                        }
                    }
                }
            }
        }

        private void comboRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string roomNo = comboRoomType.Text;
            bool isAvailable = IsRoomAvailableToday(roomNo);


            if (isAvailable)
            {
                GetRoomIdByRoomNo(roomNo);
                GetRoomIdByRoomAmount(roomNo);
            }
            else
            {
                comboRoomType.Text = "Please select room no";
                MessageBox.Show("The room is not available today.");
            }
        }

        private void reservations_Load(object sender, EventArgs e)
        {
            LoadRoomNumbersIntoComboBox();
            LoadDataIntoDataGridView();
            LoadDataIntoClientGridView();
            dataGridView1.SendToBack();
            gridDataClient.BringToFront();
            clearAll();
        }

        private void gridDataClient_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtName.Text = gridDataClient.Rows[e.RowIndex].Cells["name"].Value.ToString();
                txtId.Text = gridDataClient.Rows[e.RowIndex].Cells["idNo"].Value.ToString();

                btnAdd.Enabled = true;
                btnAdd.BackColor = Color.FromArgb(51, 165, 172);

                clientId = GetClientByIdNo(gridDataClient.Rows[e.RowIndex].Cells["idNo"].Value.ToString());
                isSelectData=true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtAmount.Text = (amount / 2).ToString();
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            txtAmount.Text = amount.ToString();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            lblName.Visible = false;
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            lblId.Visible = false;
        }

        private void comboRoomType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            lblRoom.Visible = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lblStart.Visible = false;
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            lblAmount.Visible = false;
        }

        private void clearAll()
        {
            txtName.Text = "";
            dateTimePicker1.Text = "";
            txtAmount.Text = "";
            txtId.Text = "";
            comboRoomType.Text = "";
            dateTimePicker1.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            btnAdd.BackColor = Color.DarkSlateGray;
            btnClear.Enabled = false;
            btnClear.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private bool IsRoomAvailableToday(string roomNo)
        {
            bool isAvailable = true;
            string todayDate = DateTime.Now.ToString("yyyy-MM-dd");

            string query = @"SELECT COUNT(*) 
                     FROM reservation 
                     WHERE roomId = (SELECT roomId FROM rooms WHERE roomNo = @roomNo) 
                       AND @todayDate BETWEEN startDate AND DATEADD(day, -1, closeDate);";

            string connectionStringWithDatabase = $"{connectionString};Initial Catalog=hotel_management";

            using (SqlConnection connection = new SqlConnection(connectionStringWithDatabase))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@roomNo", roomNo);
                    command.Parameters.AddWithValue("@todayDate", todayDate);

                    connection.Open();

                    int reservationCount = (int)command.ExecuteScalar();

                    if (reservationCount > 0)
                    {
                        isAvailable = false;
                    }
                }
            }

            return isAvailable;
        }

    }
}
