using IdfProject.Entities;
using IdfProject.Entities.StrikeUnits;
using IdfProject.Manegers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdfProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hamas hamas = new Hamas();
            //IntelManeger intelManeger = new IntelManeger(hamas);

            //Terrorist a = new Terrorist("hamor", 5, true, new List<string> { "M16", "gun"});
            //Terrorist b = new Terrorist("sus", 5, true, new List<string> { "M16", "gun"});

            //hamas.AddTerrorist(a);
            //hamas.AddTerrorist(b);

            //InteligenceMessage intelMSG = new InteligenceMessage("sus", "bus", DateTime.Now, "syber");
            //intelManeger.AddInteligenceMessage(intelMSG);

            //Terrorist terrrrrr = intelManeger.getMostDagerousTerrorist();
            //Console.WriteLine(terrrrrr);




            //Idf idf = new Idf();
            //StrikeManeger strikeManeger = new StrikeManeger(idf);

            //Artilery artilery = new Artilery("t5");
            //F16 F16 = new F16("t5");
            //Drone Drone = new Drone("t5");
            //idf.AddStrikeUnit(artilery);
            //idf.AddStrikeUnit(F16);
            //idf.AddStrikeUnit(Drone);

            //strikeManeger.strikeTerrorist(terrrrrr, "home");
            Hamas hamas = new Hamas();
            IntelManeger intelManeger = new IntelManeger(hamas);

            Idf idf = new Idf();
            StrikeManeger strikeManeger = new StrikeManeger(idf);

            ReportManeger reportManeger = new ReportManeger();

            MenuManeger maneger = new MenuManeger(intelManeger, reportManeger, strikeManeger);

            maneger.MainMenu();
        }
    }
}
