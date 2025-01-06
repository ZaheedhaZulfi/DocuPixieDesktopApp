using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.Logging;
using System.Data;
using System.Text.RegularExpressions;
namespace DocuPixieDesktopApp
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        // Check if Email is Valid
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        // Check if Password Meets Security Criteria
        private bool IsValidPassword(string password)
        {
            // Password must contain at least one uppercase letter, one lowercase letter, one digit, one special character, and be at least 8 characters long
            return System.Text.RegularExpressions.Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$");
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

        private void txtConfirmPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtConfirmPassword.Text == "Confirm Password")
            {
                txtConfirmPassword.Clear();
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            // Step 1: Validate Email
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Step 2: Validate Password
            if (!IsValidPassword(password))
            {
                MessageBox.Show("Password must be at least 8 characters long and include an uppercase letter, a lowercase letter, a digit, and a special character.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Step 3: Check if Password and Confirm Password Match
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if Email Already Exists
            string checkEmailQuery = "SELECT COUNT(*) FROM Users WHERE Email = @Email";
            // Step 4: Connect to SQL Server and Execute Queries
            string connectionString = "data Source=LAPTOP-S5J9JH4R\\SQLEXPRESS; database = DocuPixieDB;Integrated Security=True; Encrypt=True; TrustServerCertificate=True"; // Replace with your SQL Server connection string

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                   
                    using (SqlCommand checkCmd = new SqlCommand(checkEmailQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@Email", email);
                        int emailExists = (int)checkCmd.ExecuteScalar();
                        if (emailExists > 0)
                        {
                            MessageBox.Show("This email is already registered. Please log in instead.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Insert New User
                    string insertQuery = "INSERT INTO Users (Email, Password) VALUES (@Email, @Password)";
                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, connection))
                    {
                        insertCmd.Parameters.AddWithValue("@Email", email);
                        insertCmd.Parameters.AddWithValue("@Password", password);
                        insertCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Signup Successful! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HomePage home = new HomePage(email);
                    home.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginPage login = new LoginPage();
            login.Show();
            this.Hide();

        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            
        }
    }
}
