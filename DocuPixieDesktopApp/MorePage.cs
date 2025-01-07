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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Tesseract;
using System.Net.Http;        // For making HTTP requests
using Newtonsoft.Json;        // For JSON serialization/deserialization

namespace DocuPixieDesktopApp
{
    public partial class MorePage : Form
    {
        private List<FileDetails> uploadedFiles;
        public MorePage(List<FileDetails> uploadedFiles)
        {
            InitializeComponent();
            this.uploadedFiles = uploadedFiles ?? new List<FileDetails>(); // Assign parameter or initialize empty list
        }

        // Scan file using Tesseract (OCR)
        private async Task<string> ScanFileWithTesseract(string filePath)
        {
            using (var engine = new TesseractEngine(@"./tessdata", "eng", EngineMode.Default))
            {
                using (var img = Pix.LoadFromFile(filePath))
                {
                    var result = engine.Process(img);
                    return result.GetText(); // Extracted text
                }
            }
        }


        // Summarize text using HuggingFace API
        private async Task<string> SummarizeTextWithHuggingFace(string text)
        {
            string apiUrl = "https://api-inference.huggingface.co/models/facebook/bart-large-cnn";
            string apiToken = "YOUR_HUGGINGFACE_API_TOKEN"; // Replace with your API token

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiToken}");

                var content = new StringContent(JsonConvert.SerializeObject(new { inputs = text }), System.Text.Encoding.UTF8, "application/json");

                var response = await client.PostAsync(apiUrl, content);
                string responseContent = await response.Content.ReadAsStringAsync();

                dynamic jsonResponse = JsonConvert.DeserializeObject(responseContent);
                return jsonResponse[0].summary_text; // Extracted summary
            }
        }

        private async void btnScanSummarize_Click(object sender, EventArgs e)
        {


            if (uploadedFiles != null && uploadedFiles.Count > 0)
            {
                var selectedFile = uploadedFiles[0]; // Select the first uploaded file for this example
                string filePath = selectedFile.FilePath;

                try
                {

                    extractApi extractapi = new extractApi();
                    
                    // Step 1: Scan the file (OCR)
                    string scannedText = await extractapi.extractText(filePath);


                    MessageBox.Show(scannedText);

                    if (!string.IsNullOrEmpty(scannedText))
                    {

                        summarizeAPI summarizeAPI =  new summarizeAPI();
                        Summarize summarizedText = await summarizeAPI.GetSummary(scannedText);

                        MessageBox.Show(summarizedText.summary_text);
                        // Step 2: Summarize the scanned text
                         //= await SummarizeTextWithHuggingFace(scannedText);

                        // Step 3: Show the summarized text in the SummarizedPage form
                        SummeraizedPage summarizedPage = new SummeraizedPage(summarizedText.summary_text);
                        summarizedPage.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("No text detected in the file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error during scanning or summarization: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No files uploaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        /*public class FileDetails
        {
            public string FileName { get; set; }
            public string FilePath { get; set; }
        }*/

        private void MorePage_Load(object sender, EventArgs e)
        {
            if (uploadedFiles == null || uploadedFiles.Count == 0)
            {
                MessageBox.Show("No uploaded files to display.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
    }

}
    

