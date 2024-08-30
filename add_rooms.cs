using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Hotel_Management_System
{
    public partial class add_rooms : UserControl
    {
        private string connectionString = "Data Source=localhost;Initial Catalog=master;Integrated Security=True";
        private bool isSelectData = false;
        public add_rooms()
        {
            InitializeComponent();

            btnAdd.MouseHover += new EventHandler(btnAdd_MouseHover);
        }

        private void btnAdd_MouseHover(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.FromArgb(51, 175, 172);
        }

        private void add_rooms_Load(object sender, EventArgs e)
        {
            txtMeals.Enabled = false;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            LoadDataIntoDataGridView();
        }

        private void LoadDataIntoDataGridView()
        {
            string connectionString = "Data Source=localhost;Initial Catalog=hotel_management;Integrated Security=True;";
            string query = "SELECT * FROM rooms"; // Replace with your table name

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (comboRoomType.Text == "")
            {
                lblRoomType.Visible = true;
                return;
            }
             if (txtRoomNo.Text == "")
            {
                lblRoomNo.Visible = true;
                return;
            }
             if (comboBedType.Text == "")
            {
                lblBed.Visible = true;
                return;
            }
             if (txtMeals.Text == "")
            {
                lblMeals.Visible = true;
                return;
            }
             if (txtPrice.Text == "")
            {
                lblPrice.Visible = true;
                return;
            }
             if (!isSelectData)
            {
                AddRoom();
            }
            else
            {
                UpdateRoom();
            }

        }

        private void clearAll()
        {
            comboRoomType.Text = "";
            comboRoomType.SelectedItem = null;
            txtRoomNo.Text = "";
            comboBedType.Text = "";
            comboBedType.SelectedItem = null;
            txtMeals.Text = "";
            txtPrice.Text = "";
            isSelectData = false;
            btnAdd.Text = "Save";
            btnAdd.BackColor = Color.DarkSlateGray;
            btnDelete.BackColor = Color.DimGray;
            lblBed.Visible = false;
            lblMeals.Visible = false;
            lblPrice.Visible = false;
            lblBed.Visible = false;
        }


        private void AddRoom()
        {
            string roomType = comboRoomType.Text;
            string roomNo = txtRoomNo.Text;
            string bedType = comboBedType.Text;
            string meals = txtMeals.Text;
            string price = txtPrice.Text;

            // SQL query to insert the default user
            string query = $"INSERT INTO rooms (roomType, roomNo, bedType, meals, price) VALUES (@roomType, @roomNo, @bedType, @meals, @price);";
            string connectionStringWithDatabase = $"{connectionString};Initial Catalog=hotel_management";

            // Create a SqlConnection object
            using (SqlConnection connection = new SqlConnection(connectionStringWithDatabase))
            {
                // Create a SqlCommand object with the query and connection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the command
                    command.Parameters.AddWithValue("@roomType", roomType);
                    command.Parameters.AddWithValue("@roomNo", roomNo);
                    command.Parameters.AddWithValue("@bedType", bedType);
                    command.Parameters.AddWithValue("@meals", meals);
                    command.Parameters.AddWithValue("@price", price);

                    // Open the connection
                    connection.Open();
                    // Execute the query
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Successfull add room.");
                        LoadDataIntoDataGridView();
                        clearAll();
                    }
                    else
                    {
                        MessageBox.Show("Error!");
                    }
                }
            }
        }

        private void UpdateRoom()
        {
            // Assume roomNo is the unique identifier for the room
            string roomNo = txtRoomNo.Text;
            string roomType = comboRoomType.Text;
            string bedType = comboBedType.Text;
            string meals = txtMeals.Text;
            string price = txtPrice.Text;

            // SQL query to update the room details
            string query = $"UPDATE rooms SET roomType = @roomType, bedType = @bedType, meals = @meals, price = @price WHERE roomNo = @roomNo;";
            string connectionStringWithDatabase = $"{connectionString};Initial Catalog=hotel_management";

            // Create a SqlConnection object
            using (SqlConnection connection = new SqlConnection(connectionStringWithDatabase))
            {
                // Create a SqlCommand object with the query and connection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the command
                    command.Parameters.AddWithValue("@roomType", roomType);
                    command.Parameters.AddWithValue("@roomNo", roomNo);  // Assuming roomNo is the unique identifier
                    command.Parameters.AddWithValue("@bedType", bedType);
                    command.Parameters.AddWithValue("@meals", meals);
                    command.Parameters.AddWithValue("@price", price);

                    // Open the connection
                    connection.Open();
                    // Execute the query
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Room details updated successfully.");
                        LoadDataIntoDataGridView();
                        clearAll();
                    }
                    else
                    {
                        MessageBox.Show("Error updating room details!");
                    }
                }
            }
        }


        private void comboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMeals.Enabled = true;
            btnAdd.Enabled = true;
            btnAdd.BackColor = Color.FromArgb(51, 165, 172);
            lblRoomType.Visible = false;


            String bedType = comboRoomType.Text.ToString();

            if (bedType == "Single")
            {
                txtMeals.Text = "";
                txtMeals.Text = "Bereakfirst, Lunch, Dinner";
            }
            if (bedType == "Family")
            {
                txtMeals.Text = "";
                txtMeals.Text = "Bereakfirst, Lunch, Tea, Dinner, Deserts";
            }
            if (bedType == "Custom")
            {
                txtMeals.Text = "";
                txtMeals.Text = "Custom";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void DeleteRowFromDatabase(int roomId)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=hotel_management;Integrated Security=True;";
            string query = "DELETE FROM rooms WHERE roomId = @roomId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@roomId", roomId);

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


        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Ensure the click is on a valid row (not the header or a non-existent row)
            if (e.RowIndex >= 0)
            {
                // Retrieve values from the selected row and assign them to the TextBoxes
                comboRoomType.Text = dataGridView1.Rows[e.RowIndex].Cells["roomType"].Value.ToString();
                txtRoomNo.Text = dataGridView1.Rows[e.RowIndex].Cells["roomNo"].Value.ToString();
                comboBedType.Text = dataGridView1.Rows[e.RowIndex].Cells["bedType"].Value.ToString();
                txtMeals.Text = dataGridView1.Rows[e.RowIndex].Cells["meals"].Value.ToString();
                txtPrice.Text = dataGridView1.Rows[e.RowIndex].Cells["price"].Value.ToString();
                btnDelete.Enabled = true;
                btnDelete.BackColor = Color.Brown;
                btnAdd.Enabled = true;
                btnAdd.BackColor = Color.FromArgb(51, 165, 172);
                btnAdd.Text = "Update";
                isSelectData = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Index >= 0)
            {
                // Get the selected roomId from the DataGridView
                int roomId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["roomId"].Value);

                // Confirm deletion
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this room?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    // Delete the row from the database
                    DeleteRowFromDatabase(roomId);

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

        private void txtRoomNo_TextChanged(object sender, EventArgs e)
        {
            lblRoomNo.Visible = false;
        }

        private void comboBedType_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblBed.Visible = false;
        }

        private void txtMeals_TextChanged(object sender, EventArgs e)
        {
            lblMeals.Visible = false;
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            lblPrice.Visible = false;
        }
    }
}
