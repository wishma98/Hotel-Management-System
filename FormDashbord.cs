using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class FormDashbord : Form
    {
        private string connectionString = "Data Source=localhost;Initial Catalog=master;Integrated Security=True";
        
        public FormDashbord()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked_2(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabellogout_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonRoom_Click(object sender, EventArgs e)
        {
            add_rooms1.BringToFront();
            client1.SendToBack();
            dashboard1.SendToBack();
            addReservations1.SendToBack();
            reservations2.SendToBack();
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            client1.SendToBack();
            dashboard1.SendToBack();
            add_rooms1.SendToBack();
            addReservations1.SendToBack();
            reservations2.SendToBack();
        }

        private void buttonCli_Click(object sender, EventArgs e)
        {
            client1.BringToFront();
            dashboard1.SendToBack();
            add_rooms1.SendToBack();
            addReservations1.SendToBack();
            reservations2.SendToBack();
        }

        private void buttonDash_Click(object sender, EventArgs e)
        {
            dashboard1.BringToFront();
            client1.SendToBack();
            add_rooms1.SendToBack();
            addReservations1.SendToBack();
            reservations2.SendToBack();
        }

        private void buttonRes_Click(object sender, EventArgs e)
        {
            reservations2.BringToFront();
            addReservations1.SendToBack();
            dashboard1.SendToBack();
            client1.SendToBack();
            add_rooms1.SendToBack();
        }

        private void buttonAddRes_Click(object sender, EventArgs e)
        {
            addReservations1.BringToFront();
            reservations2.SendToBack();
            dashboard1.SendToBack();
            client1.SendToBack();
            add_rooms1.SendToBack();
        }

        private string FetchUserName()
        {
            string fullName = "";

            string query = "SELECT fullName FROM users WHERE userId = @userId;";
            string connectionStringWithDatabase = $"{connectionString};Initial Catalog=hotel_management";

            using (SqlConnection connection = new SqlConnection(connectionStringWithDatabase))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userId", Session.CurrentUserId);

                    connection.Open();

                    fullName = (string)command.ExecuteScalar();
                }
            }
             return fullName;
        }

        private void FormDashbord_Load(object sender, EventArgs e)
        {
            labelUsername.Text = FetchUserName();
            dashboard1.BringToFront();
        }

    }
}
