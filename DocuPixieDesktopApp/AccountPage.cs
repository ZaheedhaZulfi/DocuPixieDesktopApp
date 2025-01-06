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
using static DocuPixieDesktopApp.UploadPage;

namespace DocuPixieDesktopApp
{
    public partial class AccountPage : Form
    {
        private string UserEmail;
        private string connectionString = "Data Source=LAPTOP-S5J9JH4R\\SQLEXPRESS;Initial Catalog=DocuPixieDB;Integrated Security=True; Encrypt=True; TrustServerCertificate=True";
        public AccountPage(string userEmail)
        {
            InitializeComponent();
            UserEmail = userEmail;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage(UserEmail);
            homePage.Show();
            this.Hide();
        }
        private void LoadUploadedDocuments()
        {
            DataTable documentsTable = new DataTable();
            string query = "SELECT FileName, FilePath FROM Document WHERE UserID = (SELECT Id FROM Users WHERE Email = @Email)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Email", UserEmail);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(documentsTable);
                        }
                    }

                    // Bind the DataTable to the DataGridView
                    dgvDocuments.DataSource = documentsTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading documents: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AccountPage_Load(object sender, EventArgs e)
        {
            // Display the user's email
            lblUserEmail.Text = $"User Email: {UserEmail}";

            // Load uploaded documents into the DataGridView
            LoadUploadedDocuments();

        }
    }
}
