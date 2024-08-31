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

namespace Hotel_Management_System
{
    public partial class reservations : UserControl
    {
        private string connectionString = "Data Source=localhost;Initial Catalog=master;Integrated Security=True";
        bool isSelectData = false;
        public int clientId = 0;
        int reservationId = 0;
        public int roomId = 0;
        public decimal amount = 0;

        public reservations()
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

        private void reservations_Load(object sender, EventArgs e)
        {
            LoadRoomNumbersIntoComboBox();
            LoadDataIntoDataGridView();

            btnAdd.Enabled = false;
            btnClear.Enabled = false;
            btnAdd.BackColor = Color.DarkSlateGray;
        }

        private void gridDataClient_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtName.Text = dataGridView1.Rows[e.RowIndex].Cells["clientName"].Value.ToString();
                clientId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["clientId"].Value);
                roomId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["roomId"].Value);
                reservationId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["reservationId"].Value);
                comboRoomType.Text = dataGridView1.Rows[e.RowIndex].Cells["roomNo"].Value.ToString();
                dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells["startDate"].Value.ToString();
                dateTimePicker2.Text = dataGridView1.Rows[e.RowIndex].Cells["closeDate"].Value.ToString();
                txtAmount.Text = dataGridView1.Rows[e.RowIndex].Cells["paymentAmount"].Value.ToString();
                string paymentType = dataGridView1.Rows[e.RowIndex].Cells["paymentType"].Value.ToString();

                if (paymentType == "Advance")
                {
                    radioButton1.Checked = true;
                    radioButton2.Checked = false;
                }
                else if (paymentType == "Full")
                {
                    radioButton2.Checked = true;
                    radioButton1.Checked = false;
                }
                else
                {
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                }

                btnAdd.Enabled = true;
                btnClear.Enabled = true;
                btnAdd.BackColor = Color.FromArgb(51, 165, 172);

            }
        }

        private string GetClientNameByIdNo(string clientId)
        {
            string getName = "";
            string query = "SELECT name FROM client WHERE clientId = @clientId;";
            string connectionStringWithDatabase = $"{connectionString};Initial Catalog=hotel_management";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionStringWithDatabase))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@clientId", clientId);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                getName = reader.ToString();
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
            return getName;
        }

        private string GetRoomIdByRoomNo(string roomId)
        {
            string getRoomNo = "";
            string query = "SELECT roomNo FROM rooms WHERE roomId = @roomId;";
            string connectionStringWithDatabase = $"{connectionString};Initial Catalog=hotel_management";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionStringWithDatabase))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add the parameter for idNo
                        command.Parameters.AddWithValue("@roomId", roomId);

                        // Open the connection
                        connection.Open();

                        // Execute the query
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Assuming you want to display or use these values
                                getRoomNo = reader.ToString();
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
            return getRoomNo;
        }

        private decimal GetRoomIdByRoomAmount(string roomId)
        {
            decimal getRoomAmount = 0; // Changed to decimal to handle typical currency/price values
            string query = "SELECT price FROM rooms WHERE roomId = @roomId;";
            string connectionStringWithDatabase = $"{connectionString};Initial Catalog=hotel_management";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionStringWithDatabase))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add the parameter for roomNo
                        command.Parameters.AddWithValue("@roomId", roomId);

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
            return getRoomAmount; // Ensure amount is of type decimal or adjust as needed
        }

        private void clearAll()
        {
            txtName.Text = string.Empty;
            dateTimePicker1.Text = string.Empty;
            txtAmount.Text = string.Empty;
            comboRoomType.Text = "";
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";
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

        private void UpdateReservation()
        {
            string paymentMethord = "", paymentType = "", endDate = "";
            int amount = 0;

            endDate = dateTimePicker2.Text;

            if (radioButton1.Checked)
            {
                paymentType = "Advance";
            }
            if (radioButton2.Checked)
            {
                paymentType = "Full";
            }

            if (checkBox1.Checked)
            {
                paymentMethord = "Cash";
            }
            if (checkBox2.Checked)
            {
                paymentMethord = "Card";
            }

            string query = $"UPDATE reservation SET closeDate = @endDate, paymentType = @paymentType, paymentMethord = @paymentMethord, paymentAmount= @amount WHERE reservationId = @reservationId;";
            string connectionStringWithDatabase = $"{connectionString};Initial Catalog=hotel_management";

            using (SqlConnection connection = new SqlConnection(connectionStringWithDatabase))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@reservationId", reservationId);
                    command.Parameters.AddWithValue("@endDate", endDate);
                    command.Parameters.AddWithValue("@paymentType", paymentType);
                    command.Parameters.AddWithValue("@paymentMethord", paymentMethord);
                    command.Parameters.AddWithValue("@amount", amount);

                    connection.Open();

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Updated reservation informations.");
                        LoadDataIntoDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Error updating reservation information.");
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                lblName.Visible = true;
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
            if ((checkBox1.Checked == false || checkBox2.Checked == false))
            {
                lblMethord.Visible = true;
            }
            if (isSelectData && txtName.Text != "" && comboRoomType.Text != "" && dateTimePicker1.Text != "" && dateTimePicker2.Text != "" && (radioButton1.Checked == false || radioButton2.Checked == false) && (checkBox1.Checked == false || checkBox2.Checked == false) && txtAmount.Text != "")
            {
                UpdateReservation();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            lblMethord.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            lblMethord.Visible = false;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            lblName.Visible = false;
        }

        private void comboRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblRoom.Visible = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lblStart.Visible = false;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            lblEnd.Visible = false;
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            lblAmount.Visible = false;
        }
    }
}
