using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DocuPixieDesktopApp
{
    public class summarizeAPI
    {
        private static readonly string apiKey = "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";
        private static readonly string apiUrl = "https://api-inference.huggingface.co/models/facebook/bart-large-cnn"; // Example summarization model


        // The text you want to summarize
        string inputText = "The swirling clouds danced across the horizon, painted in hues of orange and pink as the sun dipped below the mountains. Birds chirped a melody that seemed to echo the rhythm of the rustling leaves, while the distant laughter of children added life to the serene evening. Somewhere, a clock ticked steadily, marking the passage of another fleeting moment in the tapestry of time.\r\n\r\n.";

        //var summary = await GetSummary(inputText);
        //Console.WriteLine("Summary: " + summary);


        // Function to get summary using Hugging Face API
        public static async Task<Summarize> GetSummary(string inputText)
        {
            using (var client = new HttpClient())
            {
                // Set the Authorization header
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + apiKey);

                // Prepare the JSON body
                var jsonBody = new
                {
                    inputs = inputText
                };

                var content = new StringContent(
                    Newtonsoft.Json.JsonConvert.SerializeObject(jsonBody),
                    Encoding.UTF8,
                    "application/json"
                );

                // Send POST request to Hugging Face API
                var response = await client.PostAsync(apiUrl, content);

                // Ensure successful response
                response.EnsureSuccessStatusCode();

                // Read and return the response body as a string
                string result = await response.Content.ReadAsStringAsync();

                // Deserialize the JSON array into a list of Summarize objects
                var summaries = JsonConvert.DeserializeObject<List<Summarize>>(result);

                // Extract the first summary and return it as a Summarize object
                if (summaries != null && summaries.Count > 0)
                {
                    return summaries.First();
                }
                else
                {
                    throw new Exception("No summary returned from the API.");
                }
            }
        }


    }
}
