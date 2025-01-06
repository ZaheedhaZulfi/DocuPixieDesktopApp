using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocuPixieDesktopApp;
using System.Windows.Forms;
using static DocuPixieDesktopApp.UploadPage;

namespace DocuPixieDesktopApp
{
    public partial class UploadedPage : Form
    {
        private string UserEmail;
        private List<FileDetails> UploadedFiles;
        private string connectionString = "Data Source=LAPTOP-S5J9JH4R\\SQLEXPRESS;Initial Catalog=DocuPixieDB;Integrated Security=True; Encrypt=True; TrustServerCertificate=True";
        public UploadedPage(string userEmail, List<FileDetails> uploadedFiles)
        {
            InitializeComponent();
            UserEmail = userEmail;
            UploadedFiles = uploadedFiles ?? new List<FileDetails>(); // Initialize with an empty list if null
        }

        private void UploadedFilesPage_Load(object sender, EventArgs e)
        {
            //DisplayUploadedFiles();
        }


        private void btnMore_Click(object sender, EventArgs e)
        {
            if (UploadedFiles == null || UploadedFiles.Count == 0)
            {
                MessageBox.Show("No uploaded files to pass to MorePage.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MorePage more = new MorePage(UploadedFiles); // Pass the correct list
            more.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UploadedPage_Load(object sender, EventArgs e)
        {

        }

        private void btnDownload_Click(object sender, EventArgs e)
        {

        }
        

    }

}
