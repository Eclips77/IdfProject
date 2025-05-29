using IdfProject.AbstractClasses;
using IdfProject.Entities;
using IdfProject.Entities.StrikeUnits;
using IdfProject.Manegers;
using IdfProject.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace IdfProject
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //InteligenceMessage intelMSG = new InteligenceMessage("sus", "bus", DateTime.Now, "syber");
            //intelManeger.AddInteligenceMessage(intelMSG);

            //Hamas hamas = new Hamas();
            //IntelManeger intelManeger = new IntelManeger(hamas);

            //Idf idf = new Idf();
            //StrikeManeger strikeManeger = new StrikeManeger(idf);

            //ReportManeger reportManeger = new ReportManeger();

            //MenuManeger maneger = new MenuManeger(intelManeger, reportManeger, strikeManeger);








            var hamas = new Hamas();
            await LoadTerroristsFromGeminiAsync(hamas);


        }
        public static async Task LoadTerroristsFromGeminiAsync(Hamas hamas)
        {
            var api = new AiApiData("AIzaSyCvsYDNL5XKGOunkcommubH01GazSFFX7M");

            object prompt = Prompts.GetTerroristRequestObject(5);

            string responseJson = await api.SendPromptObjectAsync(prompt);
            Console.WriteLine(responseJson);

            var parser = new TerroristDataParser();
            List<TerroristData> dataList = parser.ParseApiData(responseJson);

            var factory = new Factory();
            foreach (var terrorist in factory.CreateTerrorists(dataList))
            {
                hamas.AddTerrorist(terrorist);
            }
        }

    }
}
