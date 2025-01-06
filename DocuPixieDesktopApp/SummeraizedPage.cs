using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocuPixieDesktopApp
{
    public partial class SummeraizedPage : Form
    {
        public SummeraizedPage(string summarizedText)
        {
            InitializeComponent();
            richTextBox1.Text = summarizedText; // Set the summarized text
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
