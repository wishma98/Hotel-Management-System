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

namespace Hotel_Management_System
{
    public partial class login : Form
    {
        private string connectionString = "Data Source=localhost;Initial Catalog=master;Integrated Security=True";

        public login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_Load(object sender, EventArgs e)
        {
            string databaseName = "hotel_management";
            if (!CheckIfDatabaseExists(databaseName))
            {
                // if (ConnectToDatabase(databaseName))
                //{
                if (!CheckIfTablesExist(databaseName,  "users"))
                {
                    CreateTables(databaseName);

                }
                 // }                
            }
            else
            {
                MessageBox.Show("Failed to connect to the database.");
                CreateDatabase(databaseName);
            }
        }

        private bool CheckIfDatabaseExists(string databaseName)
        {
            // Check if the database exists
            bool exists = false;
            // string connectionString = "servaer=localhost;user id=root;password=;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand($"SELECT SCHEMA_NAME FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = '{databaseName}'", connection))
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
            // Connection string to the MySQL server (without specifying database)
            // string connectionString = "servaer=localhost;user id=root;password=;";

            // Create the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Create a command to execute SQL statements
                using (SqlCommand command = new SqlCommand("", connection))
                {
                    // Create the database
                    command.CommandText = $"CREATE DATABASE {databaseName}";
                    command.ExecuteNonQuery();
                    MessageBox.Show("Created to database.");
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
                    MessageBox.Show("Connected to database.");
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting to database: " + ex.Message);
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
                string createLoginTable1 = "CREATE TABLE users (id INT IDENTITY(1,1) PRIMARY KEY, userName VARCHAR(50) NOT NULL, password VARCHAR(50) NOT NULL)";
                using (SqlCommand createLoginTable1CommandText = new SqlCommand(createLoginTable1, connection))
                {
                    createLoginTable1CommandText.ExecuteNonQuery();
                }
                // Create your_table1
                //    string createTable1CommandText = $"CREATE TABLE {tableName1} (id INT IDENTITY(1,1) PRIMARY KEY, name VARCHAR(50))";
                //    using (SqlCommand createTable1Command = new SqlCommand(createTable1CommandText, connection))
                //    {
                // createTable1Command.ExecuteNonQuery();
                //    }
                // Create your_table2
                //   string createTable2CommandText = $"CREATE TABLE {tableName2} (id INT IDENTITY(1,1) PRIMARY KEY, age INT)";
                //   using (SqlCommand createTable2Command = new SqlCommand(createTable2CommandText, connection))
                //    {
                // createTable2Command.ExecuteNonQuery();
                //    }
            }
            AddDefaultUser();
        }

        private void AddDefaultUser()
        {
            string userName = "admin";
            string password = "admin@123";

            // SQL query to insert the default user
            string query = $"INSERT INTO users (userName, password) VALUES (@userName, @password);";

            // Create a SqlConnection object
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create a SqlCommand object with the query and connection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the command
                    command.Parameters.AddWithValue("@userName", userName);
                    command.Parameters.AddWithValue("@password", password);

                    // Open the connection
                    connection.Open();
                    // Execute the query
                    command.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Default user added successfully.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            if (AuthenticateUser(userName, password))
            {
                MessageBox.Show("Login successful.");
                login login = new login();
                login.Close();
                Form2 form2 = new Form2();
                form2.ShowDialog();
                // Redirect to main form or perform other actions here
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
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
            txtPassword.Font= new Font(txtPassword.Font.FontFamily, 11, txtPassword.Font.Style); ;
        }

        private void picEyeShow_Click(object sender, EventArgs e)
        {
            picEyeShow.Visible = false;
            picEyeHide.Visible = true;
            txtPassword.PasswordChar = '⚫';
        }
    }
}
