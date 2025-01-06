using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocuPixieDesktopApp
{
    public class extractApi
    {
        public async Task<string> extractText(string path)
        {
            if (string.IsNullOrEmpty(path))
                return "{\"error\": \"No file path provided.\"}"; // Return JSON error if path is empty

            try
            {
                HttpClient httpClient = new HttpClient();
                httpClient.Timeout = new TimeSpan(1, 1, 1);

                MultipartFormDataContent form = new MultipartFormDataContent();
                form.Add(new StringContent("K84283691788957"), "apikey"); // API key in form data
                form.Add(new StringContent("eng"), "language");

                form.Add(new StringContent("2"), "ocrengine");
                form.Add(new StringContent("true"), "scale");
                form.Add(new StringContent("true"), "istable");

                if (!string.IsNullOrEmpty(path))
                {
                    byte[] imageData = File.ReadAllBytes(path);
                    form.Add(new ByteArrayContent(imageData, 0, imageData.Length), "image", "image.jpg");
                }
                else if (!string.IsNullOrEmpty(path))
                {
                    byte[] imageData = File.ReadAllBytes(path);
                    form.Add(new ByteArrayContent(imageData, 0, imageData.Length), "PDF", "pdf.pdf");
                }

                HttpResponseMessage response = await httpClient.PostAsync("https://api.ocr.space/Parse/Image", form);
                string strContent = await response.Content.ReadAsStringAsync();

                // Optionally, deserialize to check the status
                Rootobject ocrResult = JsonConvert.DeserializeObject<Rootobject>(strContent);

                if (ocrResult.OCRExitCode == 1)
                {
                    // Return the full JSON response as is
                    return strContent; // This is already a valid JSON response from the OCR API
                }
                else
                {
                    // Returning the error message in JSON format
                    return JsonConvert.SerializeObject(new { error = "OCR failed", details = strContent });
                }
            }
            catch (Exception exception)
            {
                // Return exception message as a JSON object
                return JsonConvert.SerializeObject(new { error = "Exception occurred", message = exception.ToString() });
            }
        }
    }
}
