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
    public partial class dashboard : UserControl
    {
        private string connectionString = "Data Source=localhost;Initial Catalog=master;Integrated Security=True";
        public dashboard()
        {
            InitializeComponent();
        }
        private int GetTotalRooms()
        {
            int totalRooms = 0;
            string query = "SELECT COUNT(*) FROM rooms;";
            string connectionStringWithDatabase = $"{connectionString};Initial Catalog=hotel_management";

            using (SqlConnection connection = new SqlConnection(connectionStringWithDatabase))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    totalRooms = (int)command.ExecuteScalar();
                }
            }

            return totalRooms;
        }

        private int GetBookedRooms()
        {
            int bookedRooms = 0;
            string todayDate = DateTime.Now.ToString("MM/dd/yyyy");

            string query = "SELECT COUNT(*) FROM reservation WHERE startDate = @startDate;";
            string connectionStringWithDatabase = $"{connectionString};Initial Catalog=hotel_management";

            using (SqlConnection connection = new SqlConnection(connectionStringWithDatabase))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add the startDate parameter
                    command.Parameters.AddWithValue("@startDate", todayDate);
                    command.Parameters.AddWithValue("@endDate", todayDate);

                    connection.Open();

                    // Execute the query and retrieve the count
                    bookedRooms = (int)command.ExecuteScalar();
                }
            }

            return bookedRooms;
        }

        private int GetCheckedOutRooms()
        {
            int bookedRooms = 0;
            string todayDate = DateTime.Now.ToString("MM/dd/yyyy");

            string query = "SELECT COUNT(*) FROM reservation WHERE startDate = @startDate AND (closeDate IS NULL OR closeDate != @endDate);";
            string connectionStringWithDatabase = $"{connectionString};Initial Catalog=hotel_management";

            using (SqlConnection connection = new SqlConnection(connectionStringWithDatabase))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add the startDate parameter
                    command.Parameters.AddWithValue("@startDate", todayDate);
                    command.Parameters.AddWithValue("@endDate", todayDate);

                    connection.Open();

                    // Execute the query and retrieve the count
                    bookedRooms = (int)command.ExecuteScalar();
                }
            }

            return bookedRooms;
        }

        private int GetCheckedInRooms()
        {
            int bookedRooms = 0;
            string todayDate = DateTime.Now.ToString("MM/dd/yyyy");

            string query = "SELECT COUNT(*) FROM reservation WHERE startDate = @startDate AND closeDate != @endDate;";
            string connectionStringWithDatabase = $"{connectionString};Initial Catalog=hotel_management";

            using (SqlConnection connection = new SqlConnection(connectionStringWithDatabase))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add the startDate parameter
                    command.Parameters.AddWithValue("@startDate", todayDate);
                    command.Parameters.AddWithValue("@endDate", todayDate);

                    connection.Open();

                    // Execute the query and retrieve the count
                    bookedRooms = (int)command.ExecuteScalar();
                }
            }

            return bookedRooms;
        }

        private int GetAvailableRooms()
        {
            int availableRooms = 0;
            string todayDate = DateTime.Now.ToString("MM/dd/yyyy");

            // SQL query to find rooms that are available today
            string query = @"SELECT COUNT(*) 
                                FROM rooms r
                                WHERE NOT EXISTS (
                                    SELECT 1 
                                    FROM reservation res
                                    WHERE res.roomId = r.roomId
                                    AND (
                                        (res.startDate <= @todayDate AND (res.closeDate IS NULL OR res.closeDate >= @todayDate))
                                    )
                                );";

            string connectionStringWithDatabase = $"{connectionString};Initial Catalog=hotel_management";

            using (SqlConnection connection = new SqlConnection(connectionStringWithDatabase))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add the parameter for today's date
                    command.Parameters.AddWithValue("@todayDate", todayDate);

                    connection.Open();

                    // Execute the query and retrieve the count
                    availableRooms = (int)command.ExecuteScalar();
                }
            }

            return availableRooms;
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            lblRooms.Text = "";
            lblBooked.Text = "";
            lblAvailable.Text = "";
            lblChekedIn.Text = "";
            lblCheckedOut.Text = "";

            lblRooms.Text = GetTotalRooms().ToString();
            lblBooked.Text = GetBookedRooms().ToString();
            lblAvailable.Text = GetAvailableRooms().ToString();
            lblChekedIn.Text = GetCheckedInRooms().ToString();
            lblCheckedOut.Text = GetCheckedOutRooms().ToString();
        }
    }
}
