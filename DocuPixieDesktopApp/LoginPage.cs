using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace DocuPixieDesktopApp
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            string connectionString = "Data Source=LAPTOP-S5J9JH4R\\SQLEXPRESS;Initial Catalog=DocuPixieDB;Integrated Security=True; Encrypt=True; TrustServerCertificate=True"; // Replace with your SQL Server connection string

            try
            {
                // Step 1: Validate Input Fields
                if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Email and Password are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Step 2: Establish a SQL Connection
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Step 3: Check if Email and Password Match
                    string loginQuery = "SELECT COUNT(*) FROM Users WHERE Email = @Email AND Password = @Password";
                    using (SqlCommand loginCmd = new SqlCommand(loginQuery, connection))
                    {
                        loginCmd.Parameters.AddWithValue("@Email", email);
                        loginCmd.Parameters.AddWithValue("@Password", password);

                        int validUser = (int)loginCmd.ExecuteScalar();
                        if (validUser > 0)
                        {
                            MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Redirect to the next page or application dashboard
                            HomePage home = new HomePage(email);
                            home.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid email or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEmail_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtEmail.Text == "E-mail")
            {
                txtEmail.Clear();
            }
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Clear();
            }
        }
    }
}
