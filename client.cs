using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Hotel_Management_System
{
    public partial class client : UserControl
    {
        private string connectionString = "Data Source=localhost;Initial Catalog=master;Integrated Security=True";
        bool isSelectData = false;
        public int clientId = 0;
        public int roomId = 0;
        public int amount = 0;

        public client()
        {
            InitializeComponent();
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
            if (isSelectData && txtName.Text == "" && txtId.Text == "" && comboRoomType.Text == "" && dateTimePicker1.Text == "")
            {
                AddReservation();
                dataGridView1.Visible = false;
                reservationGridView.Visible = true;
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

            // Create a SqlConnection object
            using (SqlConnection connection = new SqlConnection(connectionStringWithDatabase))
            {
                // Create a SqlCommand object with the query and connection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the command
                    command.Parameters.AddWithValue("@clientId", clientId);
                    command.Parameters.AddWithValue("@roomId", roomId);
                    command.Parameters.AddWithValue("@startDate", startDate);
                    command.Parameters.AddWithValue("@paymentType", paymentType);
                    command.Parameters.AddWithValue("@paymentAmount", paymentAmount);

                    // Open the connection
                    connection.Open();
                    // Execute the query
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        LoadDataIntoDataGridView();
                        LoadDataIntoReservationGridView();
                    }
                }
            }
        }

        private void client_Load(object sender, EventArgs e)
        {
            lblAmount.Visible = false;
            lblMobile.Visible = false;
            lblId.Visible = false;
            lblName.Visible = false;
            lblRoom.Visible = false;
            lblStart.Visible = false;
            dataGridView1.BringToFront();
            LoadDataIntoDataGridView();
        }

        private void LoadDataIntoDataGridView()
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
                        dataGridView1.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void LoadDataIntoReservationGridView()
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
                        reservationGridView.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnAdd.BackColor = Color.FromArgb(51, 165, 172);
            lblName.Visible = false;
        }

        private void clearAll()
        {
            txtAddress.Text = string.Empty;
            txtId.Text = string.Empty;
            txtMobileNo.Text = string.Empty;
            txtName.Text = string.Empty;
            dateTimePicker1.Text = string.Empty;
            lblHeader.Text = "Add Client";
            comboRoomType.Text = "";
            dateTimePicker1.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            btnDelete.BackColor = Color.DimGray;
            btnDelete.Enabled = false;
            dataGridView1.BringToFront();
        }

        private void AddClient()
        {
            String name, idNo, mobileNo, address;

            name = txtName.Text;
            idNo = txtId.Text;
            mobileNo = txtMobileNo.Text;
            address = txtAddress.Text;

            string query = $"INSERT INTO client (name, idNo, mobileNo, address) VALUES (@name, @idNo, @mobileNo, @address);";
            string connectionStringWithDatabase = $"{connectionString};Initial Catalog=hotel_management";

            // Create a SqlConnection object
            using (SqlConnection connection = new SqlConnection(connectionStringWithDatabase))
            {
                // Create a SqlCommand object with the query and connection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the command
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@idNo", idNo);
                    command.Parameters.AddWithValue("@mobileNo", mobileNo);
                    command.Parameters.AddWithValue("@address", address);

                    // Open the connection
                    connection.Open();
                    // Execute the query
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Client added successfully!");
                        LoadDataIntoDataGridView();
                        clientId = GetClientByIdNo(idNo);
                        btnClientAdd.Visible = false;
                        btnClientCancel.Visible = false;
                        btnDelete.Visible = false;
                        label11.Visible = true;
                        comboRoomType.Visible = true;
                        dateTimePicker1.Visible = true;
                        txtMobileNo.Visible = false;
                        txtAddress.Visible = false;
                        btnClientCancel.Visible = false;
                        btnClientAdd.Visible = false;
                        btnDelete.Visible = false;
                        lblMobileH.Visible = false;
                        lblAddressH.Visible = false;
                        label9.Visible = false;
                        label8.Visible = false;
                        label16.Visible = true;
                        label17.Visible = true;
                        btnAdd.Visible = true;
                        btnClear.Visible = true;
                        radioButton1.Visible = true;
                        radioButton2.Visible = true;
                        label1.Visible = true;
                        label12.Visible = true;
                        label5.Visible = true;
                        label9.Visible = true;
                        txtAmount.Visible = true;
                        lblHeader.Text = "Add Reservation";
                        isSelectData = true;
                        LoadRoomNumbersIntoComboBox();
                    }
                }
            }
        }

        private void UpdateClient()
        {
            String name, idNo, mobileNo, address;

            name = txtName.Text;
            idNo = txtId.Text;
            mobileNo = txtMobileNo.Text;
            address = txtAddress.Text;

            string query = $"UPDATE client SET name = @name, mobileNo = @mobileNo, address = @address WHERE idNo = @idNo;";
            string connectionStringWithDatabase = $"{connectionString};Initial Catalog=hotel_management";

            using (SqlConnection connection = new SqlConnection(connectionStringWithDatabase))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@idNo", idNo);
                    command.Parameters.AddWithValue("@mobileNo", mobileNo);
                    command.Parameters.AddWithValue("@address", address);

                    connection.Open();

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        LoadDataIntoDataGridView();
                        btnClientAdd.Visible = false;
                        btnClientCancel.Visible = false;
                        btnDelete.Visible = false;
                        label11.Visible = true;
                        comboRoomType.Visible = true;
                        dateTimePicker1.Visible = true;
                        label16.Visible = true;
                        label17.Visible = true;
                        btnAdd.Visible = true;
                        btnClear.Visible = true;
                        lblHeader.Text = "Update Reservation";
                        LoadRoomNumbersIntoComboBox();
                    }
                    else
                    {
                        MessageBox.Show("Error updating client information.");
                    }
                }
            }
        }

        private void btnClientAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                lblName.Visible = true;
            }
            if (txtId.Text == "")
            {
                lblId.Visible = true;
            }
            if (txtMobileNo.Text == "")
            {
                lblMobile.Visible = true;
            }
            if (txtAddress.Text == "")
            {
                lblAmount.Visible = true;
            }
            if (!isSelectData && txtName.Text != "" && txtId.Text != "" && txtMobileNo.Text != "" && txtAddress.Text != "")
            {
                AddClient();
            }
            if (isSelectData && txtName.Text != "" && txtId.Text != "" && txtMobileNo.Text != "" && txtAddress.Text != "")
            {
                UpdateClient();
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

        private int GetRoomIdByRoomNo(string roomNo)
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
            return getRoomId;
        }

        private int GetRoomIdByRoomAmount(string roomNo)
        {
            int getRoomAmount = 0;
            string query = "SELECT price FROM rooms WHERE roomNo = @roomNo;";
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
                                getRoomAmount = reader.GetInt32(0);
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
            return getRoomAmount;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Ensure the click is on a valid row (not the header or a non-existent row)
            if (e.RowIndex >= 0)
            {
                txtName.Text = dataGridView1.Rows[e.RowIndex].Cells["name"].Value.ToString();
                txtId.Text = dataGridView1.Rows[e.RowIndex].Cells["idNo"].Value.ToString();
                txtMobileNo.Text = dataGridView1.Rows[e.RowIndex].Cells["mobileNo"].Value.ToString();
                txtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells["address"].Value.ToString();

                btnDelete.Enabled = true;
                btnDelete.BackColor = Color.Brown;
                btnAdd.Enabled = true;
                btnAdd.BackColor = Color.FromArgb(51, 165, 172);
                btnClientAdd.Text = "Update";
                isSelectData = true;
            }
        }

        private void LoadRoomNumbersIntoComboBox()
        {
            string query = "SELECT roomNo FROM rooms";
            string connectionStringWithDatabase = $"{connectionString};Initial Catalog=hotel_management";

            // Clear the ComboBox before adding new items
            comboRoomType.Items.Clear();

            // Create a SqlConnection object
            using (SqlConnection connection = new SqlConnection(connectionStringWithDatabase))
            {
                // Create a SqlCommand object with the query and connection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Open the connection
                    connection.Open();

                    // Execute the query and get a SqlDataReader to read the results
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Loop through the result set
                        while (reader.Read())
                        {
                            // Add each roomNo to the ComboBox
                            comboRoomType.Items.Add(reader["roomNo"].ToString());
                        }
                    }
                }
            }
        }

        private void DeleteRowFromDatabase(int clientId)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=hotel_management;Integrated Security=True;";
            string query = "DELETE FROM client WHERE clientId = @clientId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@clientId", clientId);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while deleting the row: " + ex.Message);
                    }
                }
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Index >= 0)
            {
                // Get the selected clientId from the DataGridView
                int clientId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["clientId"].Value);

                // Confirm deletion
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this room?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    // Delete the row from the database
                    DeleteRowFromDatabase(clientId);

                    // Remove the row from the DataGridView
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                    clearAll();

                    MessageBox.Show("Room deleted successfully.");
                }
            }
            else
            {
                MessageBox.Show("Please select a room to delete.");
            }
        }

        private void comboRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblRoom.Visible = false;
            string roomNo = comboRoomType.Text;

            roomId = GetRoomIdByRoomNo(roomNo);
            amount = GetRoomIdByRoomAmount(roomNo);
        }

        private void btnClientCancel_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtAmount.Text = (amount / 2).ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtAmount.Text = amount.ToString();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            lblId.Visible = false;
        }

        private void txtMobileNo_TextChanged(object sender, EventArgs e)
        {

            lblMobile.Visible = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lblStart.Visible = false;
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            lblAmount.Visible = false;
        }
    }
}
