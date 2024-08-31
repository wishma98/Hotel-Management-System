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
using Microsoft.VisualBasic.ApplicationServices;

namespace Hotel_Management_System
{
    public partial class login : Form
    {
        private string connectionString = "Data Source=localhost;Initial Catalog=master;Integrated Security=True";

        public int userId = 0;

        public login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void login_Load(object sender, EventArgs e)
        {
            tsProgressBar.Enabled = true;
            tsProgressBar.Value = 20;
            string databaseName = "hotel_management";
            if (!CheckIfDatabaseExists(databaseName))
            {
                tsProgressBar.Value = 50;
                CreateDatabase(databaseName);
                CreateTables(databaseName);
                tsProgressBar.Value = 100;
            }
            else
            {
                tsProgressBar.Value = 50;
                if (CheckIfDatabaseExists(databaseName) && !CheckIfTablesExist(databaseName, "users"))
                {
                    tsProgressBar.Value = 70;
                    CreateTables(databaseName);
                    tsProgressBar.Value = 100;
                }
                if (CheckIfDatabaseExists(databaseName) && !CheckIfTablesExist(databaseName, "client"))
                {
                    tsProgressBar.Value = 70;
                    CreateClientTable(databaseName);
                    tsProgressBar.Value = 100;
                }
                if (CheckIfDatabaseExists(databaseName) && !CheckIfTablesExist(databaseName, "reservation"))
                {
                    tsProgressBar.Value = 70;
                    CreateReservationTable(databaseName);
                    tsProgressBar.Value = 100;
                }
                if (CheckIfDatabaseExists(databaseName) && !CheckIfTablesExist(databaseName, "rooms"))
                {
                    tsProgressBar.Value = 70;
                    CreateRoomTable(databaseName);
                    tsProgressBar.Value = 100;
                }
            }
            tsProgressBar.Value = 100;
            ConnectToDatabase(databaseName);
            tsProgressBar.Enabled = false;
            tsProgressBar.Value = 0;
        }

        private bool CheckIfDatabaseExists(string databaseName)
        {
            // Check if the database exists
            bool exists = false;
            // string connectionString = "server=localhost;user id=root;password=;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand($"SELECT name FROM sys.databases WHERE name = '{databaseName}'", connection))
                {
                    connection.Open();
                    if (command.ExecuteScalar() != null)
                    {
                        exists = true;
                    }
                }
            }
            return exists;
        }

        private void CreateDatabase(string databaseName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("", connection))
                {
                    command.CommandText = $"CREATE DATABASE {databaseName}";
                    command.ExecuteNonQuery();
                }
            }
        }

        private bool ConnectToDatabase(string databaseName)
        {
            string connectionStringWithDatabase = $"{connectionString};Initial Catalog={databaseName}";
            using (SqlConnection connection = new SqlConnection(connectionStringWithDatabase))
            {
                try
                {
                    connection.Open();
                    lblAtatus.Text = "Connected";
                    return true;
                }
                catch (Exception ex)
                {
                    lblAtatus.Text = ex.Message;
                    MessageBox.Show("Error connecting database: " + ex.Message);
                    return false;
                }
            }
        }

        private bool CheckIfTablesExist(string databaseName, params string[] tableNames)
        {
            bool tablesExist = true;
            string connectionStringWithDatabase = $"{connectionString};Initial Catalog={databaseName}";
            using (SqlConnection connection = new SqlConnection(connectionStringWithDatabase))
            {
                connection.Open();
                foreach (string tableName in tableNames)
                {
                    string commandText = $"SELECT COUNT(*) FROM information_schema.tables WHERE table_catalog = '{databaseName}' AND table_name = '{tableName}'";
                    using (SqlCommand command = new SqlCommand(commandText, connection))
                    {
                        int count = Convert.ToInt32(command.ExecuteScalar());
                        if (count == 0)
                        {
                            tablesExist = false;
                            break;
                        }
                    }
                }
            }
            return tablesExist;
        }

        private void CreateTables(string databaseName)
        {
            string connectionStringWithDatabase = $"{connectionString};Initial Catalog={databaseName}";
            using (SqlConnection connection = new SqlConnection(connectionStringWithDatabase))
            {
                connection.Open();
                // Create users
                string createLoginTable1 = "CREATE TABLE users (userId INT IDENTITY(1,1) PRIMARY KEY, userName VARCHAR(50) NOT NULL, password VARCHAR(50) NOT NULL, fullName VARCHAR(50), mobileNo char(10))";
                using (SqlCommand createLoginTable1CommandText = new SqlCommand(createLoginTable1, connection))
                {
                    createLoginTable1CommandText.ExecuteNonQuery();
                }
            }
            AddDefaultUser();
        }

        private void CreateRoomTable(string databaseName)
        {
            string connectionStringWithDatabase = $"{connectionString};Initial Catalog={databaseName}";
            using (SqlConnection connection = new SqlConnection(connectionStringWithDatabase))
            {
                connection.Open();

                string createTable1CommandText = "CREATE TABLE rooms (roomId INT IDENTITY(1,1) PRIMARY KEY, roomType VARCHAR(50), roomNo VARCHAR(50), bedType VARCHAR(50), meals VARCHAR(100), price FLOAT)";
                using (SqlCommand createTable1Command = new SqlCommand(createTable1CommandText, connection))
                {
                    createTable1Command.ExecuteNonQuery();
                }

            }
        }

        private void CreateClientTable(string databaseName)
        {
            string connectionStringWithDatabase = $"{connectionString};Initial Catalog={databaseName}";
            using (SqlConnection connection = new SqlConnection(connectionStringWithDatabase))
            {
                connection.Open();

                string createTable1CommandText = "CREATE TABLE client (clientId INT IDENTITY(1,1) PRIMARY KEY, name VARCHAR(50), idNo VARCHAR(12), mobileNo VARCHAR(10), address VARCHAR(100))";
                using (SqlCommand createTable1Command = new SqlCommand(createTable1CommandText, connection))
                {
                    createTable1Command.ExecuteNonQuery();
                }

            }
        }

        private void CreateReservationTable(string databaseName)
        {
            string connectionStringWithDatabase = $"{connectionString};Initial Catalog={databaseName}";
            using (SqlConnection connection = new SqlConnection(connectionStringWithDatabase))
            {
                connection.Open();

                string createTable2CommandText = "CREATE TABLE reservation (reservationId INT IDENTITY(1,1) PRIMARY KEY, clientId INT, roomId INT, startDate DATE, closeDate DATE, paymentType VARCHAR(10), paymentMethord VARCHAR(10), paymentAmount INT)";
                using (SqlCommand createTable2Command = new SqlCommand(createTable2CommandText, connection))
                {
                    createTable2Command.ExecuteNonQuery();
                }
            }
        }

        private void AddDefaultUser()
        {
            string userName = "admin";
            string password = "admin@123";

            string query = $"INSERT INTO users (userName, password, fullName) VALUES (@userName, @password, 'Admin');";
            string connectionStringWithDatabase = $"{connectionString};Initial Catalog=hotel_management";

            using (SqlConnection connection = new SqlConnection(connectionStringWithDatabase))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userName", userName);
                    command.Parameters.AddWithValue("@password", password);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tsProgressBar.Enabled = true;
            tsProgressBar.Value = 30;
            string userName = txtUserName.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            if (AuthenticateUser(userName, password))
            {
                tsProgressBar.Value = 50;

                //  tsProgressBar.Enabled = false;
                this.Hide();
                tsProgressBar.Value = 100;
                FormDashbord FormDashbord = new FormDashbord();
                tsProgressBar.Value = 0;

                Session.CurrentUserId = SetUserId(userName);
                FormDashbord.ShowDialog();
            }
            else
            {
                tsProgressBar.Enabled = false;
                tsProgressBar.Value = 0;
                MessageBox.Show("Invalid username or password.");
            }
        }

        private int SetUserId(string userName)
        {
            int getUserId = 0;
            string query = "SELECT userId FROM users WHERE userName = @userName;";
            string connectionStringWithDatabase = $"{connectionString};Initial Catalog=hotel_management";

            using (SqlConnection connection = new SqlConnection(connectionStringWithDatabase))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userName", userName);

                    connection.Open();

                    getUserId = (int)command.ExecuteScalar();
                }
            }
            return getUserId;

        }

        private bool AuthenticateUser(string userName, string password)
        {
            string query = "SELECT COUNT(*) FROM users WHERE userName = @userName AND password = @password";
            int count = 0;

            string connectionStringNew = $"{connectionString};Initial Catalog=hotel_management";
            using (SqlConnection connection = new SqlConnection(connectionStringNew))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userName", userName);
                    command.Parameters.AddWithValue("@password", password);

                    connection.Open();
                    count = (int)command.ExecuteScalar();

                }
            }

            return count > 0;
        }

        private void picEyeHide_Click(object sender, EventArgs e)
        {
            picEyeHide.Visible = false;
            picEyeShow.Visible = true;
            txtPassword.PasswordChar = '\0';
            txtPassword.Font = new Font(txtPassword.Font.FontFamily, 11, txtPassword.Font.Style); ;
        }

        private void picEyeShow_Click(object sender, EventArgs e)
        {
            picEyeShow.Visible = false;
            picEyeHide.Visible = true;
            txtPassword.PasswordChar = '⚫';
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            signup signup1 = new signup();
            signup1.Show();
        }
    }
}
