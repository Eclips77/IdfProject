using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json; 

namespace IdfProject.Utils
{
    internal class AiApiData
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;

        public AiApiData(string apiKey)
        {
            this._httpClient = new HttpClient();
            this._apiKey = apiKey;
        }
        public async Task<string> SendPromptObjectAsync(object promptRequest)
        {
            string url = $"https://generativelanguage.googleapis.com/v1beta/models/gemini-2.0-flash:generateContent?key={_apiKey}";
            string json = JsonConvert.SerializeObject(promptRequest);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(url, content);
            return await response.Content.ReadAsStringAsync();
        }

    }


}
