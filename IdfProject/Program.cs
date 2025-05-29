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



            //Hamas hamas = new Hamas();
            //IntelManeger intelManeger = new IntelManeger(hamas);

            //Idf idf = new Idf();
            //StrikeManeger strikeManeger = new StrikeManeger(idf);

            //ReportManeger reportManeger = new ReportManeger();

            //MenuManeger maneger = new MenuManeger(intelManeger, reportManeger, strikeManeger);


            //Factory factory = new Factory();



            //List<Terrorist> terrorists = hamas.GetListTerrorist();

            //foreach (Terrorist terrorist in terrorists)
            //{
            //    InteligenceMessage inteligenceMessage = new InteligenceMessage(terrorist.GetName(), "home", DateTime.Now, "syber");
            //    intelManeger.AddInteligenceMessage(inteligenceMessage);
            //}

            //maneger.MainMenu();







            var hamas = new Hamas();
            await LoadTerroristsFromGeminiAsync(hamas);


        }
        public static async Task LoadTerroristsFromGeminiAsync(Hamas hamas)
        {
            var api = new AiApiData("AIzaSyCvsYDNL5XKGOunkcommubH01GazSFFX7M");

            object prompt = Prompts.GetTerroristRequestObject(5);

            string responseJson = await api.SendPromptObjectAsync(prompt);
            Console.WriteLine(responseJson);
            foreach (Terrorist terrorist in terrorists)
            {
                InteligenceMessage inteligenceMessage = new InteligenceMessage(terrorist.GetName(), "home", DateTime.Now, "syber");
                intelManeger.AddInteligenceMessage(inteligenceMessage);
            }

            for (int i = 0; i < 20; i++)
            {
                Artilery artilery = new Artilery("ton");
                Drone drone = new Drone("half ton");
                F16 f16 = new F16("ton");
                idf.AddStrikeUnit(artilery);
                idf.AddStrikeUnit(drone);
                idf.AddStrikeUnit(f16);
            }
            
            






            maneger.MainMenu();

            //var factory = new Factory();
            //foreach (var terrorist in factory.CreateTerrorists(dataList))
            //{
            //    hamas.AddTerrorist(terrorist);
            //}
        }

    }
}
