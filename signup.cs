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
    public partial class signup : Form
    {
        private string connectionString = "Data Source=localhost;Initial Catalog=master;Integrated Security=True";
        public signup()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
            login login1 = new login();
            login1.Show();
        }

        private void picEyeShow_Click_1(object sender, EventArgs e)
        {
            picEyeShow.Visible = false;
            picEyeHide.Visible = true;
            txtPassword.PasswordChar = '⚫';
        }

        private void picEyeHide_Click_1(object sender, EventArgs e)
        {
            picEyeHide.Visible = false;
            picEyeShow.Visible = true;
            txtPassword.PasswordChar = '\0';
            txtPassword.Font = new Font(txtPassword.Font.FontFamily, 11, txtPassword.Font.Style); ;
        }

        private void clearAll()
        {
            txtUserName.Clear();
            txtFullName.Clear();
            txtMobileNo.Clear();
            txtPassword.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void AddUser()
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            string fullName = txtFullName.Text;
            string mobileNo = txtMobileNo.Text;

            string query = $"INSERT INTO users (userName, password, fullName, mobileNo) VALUES (@userName, @password, @fullName, @mobileNo);";
            string connectionStringWithDatabase = $"{connectionString};Initial Catalog=hotel_management";

            using (SqlConnection connection = new SqlConnection(connectionStringWithDatabase))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userName", userName);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@fullName", fullName);
                    command.Parameters.AddWithValue("@mobileNo", mobileNo);

                    connection.Open();
                    int result= command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("User created successfully!");
                        clearAll();
                        this.Close();
                        login login1 = new login();
                        login1.Show();
                    }
                    else
                    {
                        MessageBox.Show("Error creating user.");
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                lblUserName.Visible = true;
            }
            if (txtPassword.Text == "")
            {
                lblPassword.Visible = true;
            }if (txtFullName.Text == "")
            {
                lblFullName.Visible = true;
            }
            if(txtMobileNo.Text == "")
            {
                lblMobile.Visible = true;
            }
            if (txtUserName.Text != "" && txtPassword.Text != ""&& txtFullName.Text != "" && txtMobileNo.Text != "")
            {
                AddUser();
            }
        }
    }
}
