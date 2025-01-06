using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class UploadPage : Form
    {
        private string UserEmail;
        private string connectionString = "Data Source=LAPTOP-S5J9JH4R\\SQLEXPRESS;Initial Catalog=DocuPixieDB;Integrated Security=True; Encrypt=True; TrustServerCertificate=True"; // Replace with your SQL Server connection string
        private List<FileDetails> uploadedFiles = new List<FileDetails>(); // List to store file details
        public UploadPage(string useremail)
        {
            InitializeComponent();
            UserEmail = useremail;
            
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "All Files (*.*)|*.*" // File types to display
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                string selectedFileName = Path.GetFileName(selectedFilePath);

                int userId = GetUserID(UserEmail);

                if (userId != -1)
                {
                    SaveFileDetails(userId, selectedFileName, selectedFilePath);
                    // Add to the uploaded files list
                    uploadedFiles.Add(new FileDetails
                    {
                        FileName = selectedFileName,
                        FilePath = selectedFilePath
                    });
                    //MessageBox.Show($"File Selected: {selectedFileName}\nPath: {selectedFilePath}",
                       // "File Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    UploadedPage uploadedFilesPage = new UploadedPage(UserEmail, uploadedFiles);
                    uploadedFilesPage.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("User not found. Cannot save file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pnlDragDrop_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void pnlDragDrop_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            List<FileDetails> uploadedFiles = new List<FileDetails>();
            int userId = GetUserID(UserEmail);

            if (userId != -1)
            {
                foreach (string filePath in files)
                {
                    string fileName = Path.GetFileName(filePath);
                    SaveFileDetails(userId, fileName, filePath);

                    // Add file details to the list
                    uploadedFiles.Add(new FileDetails
                    {
                        FileName = fileName,
                        FilePath = filePath
                    });

                    //MessageBox.Show($"File Dragged: {fileName}\nPath: {filePath}",
                        //"File Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                UploadedPage uploadedFilesPage = new UploadedPage(UserEmail, uploadedFiles);
                uploadedFilesPage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User not found. Cannot save file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int GetUserID(string email)
        {
            int userId = -1;

            string query = "SELECT Id FROM Users WHERE Email = @Email";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                userId = reader.GetInt32(0);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error fetching User ID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return userId;
        }
        private void SaveFileDetails(int userId, string fileName, string filePath)
        {
            string query = "INSERT INTO Document (UserID, FileName, FilePath) VALUES (@UserID, @FileName, @FilePath)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userId);
                        cmd.Parameters.AddWithValue("@FileName", fileName);
                        cmd.Parameters.AddWithValue("@FilePath", filePath);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("File details saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving file details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /*public class FileDetails
        {
            public string FileName { get; set; }
            public string FilePath { get; set; }
        }*/
        private void UploadPage_Load(object sender, EventArgs e)
        {
            //pnlDragDrop.DragEnter += pnlDragDrop_DragEnter;
            //pnlDragDrop.DragDrop += pnlDragDrop_DragDrop;
        }
    }
}


    

