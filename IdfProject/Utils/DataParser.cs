using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace IdfProject.Utils
{
    public class TerroristDataParser
    {
        public List<TerroristData> ParseApiData(string geminiRawResponse)
        {
            try
            {
                dynamic response = JsonConvert.DeserializeObject(geminiRawResponse);
                string rawText = response.candidates[0].content.parts[0].text;

                string cleanJson = CleanJsonBlock(rawText);

                return JsonConvert.DeserializeObject<List<TerroristData>>(cleanJson);
            }
            catch (Exception ex)
            {
                throw new FormatException("Failed to parse terrorist data from API response.", ex);
            }
        }

        private string CleanJsonBlock(string input)
        {
            return input
                .Replace("```json", "")
                .Replace("```", "")
                .Trim();
        }
    }
}
