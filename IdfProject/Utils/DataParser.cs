using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace IdfProject.Utils
{
    public class TerroristDataParser
    {
        public List<TerroristData> ParseApiData(string geminiRawResponse)
        {
            int startIndex = geminiRawResponse.IndexOf('[');
            int endIndex = geminiRawResponse.LastIndexOf(']');

            if (startIndex == -1 || endIndex == -1 || endIndex <= startIndex)
                throw new FormatException("Response does not contain valid JSON array.");

            string jsonArray = geminiRawResponse.Substring(startIndex, endIndex - startIndex + 1);

            return JsonConvert.DeserializeObject<List<TerroristData>>(jsonArray);
        }
    }

}
