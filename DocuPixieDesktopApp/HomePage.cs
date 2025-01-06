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

    public partial class HomePage : Form
    {
        private string UserEmail;
        public HomePage(string userEmail)
        {
            InitializeComponent();
            UserEmail = userEmail;
        }

        private void btnUploadDocument_Click(object sender, EventArgs e)
        {
            UploadPage upload = new UploadPage(UserEmail);
            upload.Show();
            this.Hide();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            AccountPage accountPage = new AccountPage(UserEmail);
            accountPage.Show();
            this.Hide();
        }
    }
}
