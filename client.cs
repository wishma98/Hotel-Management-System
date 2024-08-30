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
        int clientId = 0;
        public client()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void client_Load(object sender, EventArgs e)
        {
            lblAddress.Visible = false;
            lblMobile.Visible = false;
            lblId.Visible = false;
            lblName.Visible = false;
            lblRoom.Visible = false;
            lblStart.Visible = false;
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

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnAdd.BackColor = Color.FromArgb(51, 165, 172);
        }

        private void clearAll()
        {
            txtAddress.Text = "";
            txtId.Text = "";
            txtMobileNo.Text = string.Empty;
            txtName.Text = string.Empty;
            dateTimePicker1.Text = string.Empty;
            lblHeader.Text = "Add Client";
        }

        private void AddClient()
        {
            String name, idNo, mobileNo, address;
            double price;

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
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        LoadDataIntoDataGridView();
                        clientId = GetClientByIdNo(idNo);
                        btnClientAdd.Visible = false;
                        btnClientCancel.Visible = false;
                        btnDelete.Visible = false;
                        label10.Visible = true;
                        label11.Visible = true;
                        comboRoomType.Visible = true;
                        dateTimePicker1.Visible = true;
                        label16.Visible = true;
                        label17.Visible = true;
                        btnAdd.Visible = true;
                        btnClear.Visible = true;
                        lblHeader.Text = "Add Reservation";
                        LoadRoomNumbersIntoComboBox();
                    }
                }
            }
        }

        private void UpdateClient()
        {
            String name, idNo, mobileNo, address;

            // Retrieve data from textboxes
            name = txtName.Text;
            idNo = txtId.Text;
            mobileNo = txtMobileNo.Text;
            address = txtAddress.Text;

            // SQL query to update the client's information
            string query = $"UPDATE client SET name = @name, mobileNo = @mobileNo, address = @address WHERE idNo = @idNo;";
            string connectionStringWithDatabase = $"{connectionString};Initial Catalog=hotel_management";

            // Create a SqlConnection object
            using (SqlConnection connection = new SqlConnection(connectionStringWithDatabase))
            {
                // Create a SqlCommand object with the query and connection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the command
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@idNo", idNo); // Assuming idNo is the unique identifier
                    command.Parameters.AddWithValue("@mobileNo", mobileNo);
                    command.Parameters.AddWithValue("@address", address);

                    // Open the connection
                    connection.Open();
                    // Execute the query
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        // Update was successful, update UI elements
                        LoadDataIntoDataGridView();
                        btnClientAdd.Visible = false;
                        btnClientCancel.Visible = false;
                        btnDelete.Visible = false;
                        label10.Visible = true;
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
                return;
            }
            if (txtId.Text == "")
            {
                lblId.Visible = true;
                return;
            }
            if (txtMobileNo.Text == "")
            {
                lblMobile.Visible = true;
                return;
            }
            if (txtAddress.Text == "")
            {
                lblAddress.Visible = true;
                return;
            }
            if (!isSelectData)
            {
                AddClient();
            }
            else
            {
                UpdateClient();
            }


        }

        private int GetClientByIdNo(string idNo)
        {
            int getClientId = 0;
            string query = "SELECT clientId, name, idNo, mobileNo, address FROM client WHERE idNo = @idNo;";
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

        private void AddReservation()
        {
            String name, idNo, mobileNo, address;
            double price;

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
                        LoadDataIntoDataGridView();
                        btnClientAdd.Visible = false;
                        btnClientCancel.Visible = false;
                        btnDelete.Visible = false;
                        label10.Visible = true;
                        label11.Visible = true;
                        comboRoomType.Visible = true;
                        dateTimePicker1.Visible = true;
                        label16.Visible = true;
                        label17.Visible = true;
                        btnAdd.Visible = true;
                        btnClear.Visible = true;
                        lblHeader.Text = "Add Reservation";
                        LoadRoomNumbersIntoComboBox();
                    }
                }
            }
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
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

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
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
                btnClientCancel.Visible = false;
                btnClientAdd.Visible = false;
                btnDelete.Visible = false;
                label10.Visible = true;
                label11.Visible = true;
                comboRoomType.Visible = true;
                dateTimePicker1.Visible = true;
                label16.Visible = true;
                label17.Visible = true;
                btnAdd.Visible = true;
                btnClear.Visible = true;
                lblHeader.Text = "Add Reservation";
                isSelectData = true;
            }
        }
    }
}
