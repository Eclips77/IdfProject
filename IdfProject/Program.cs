using IdfProject.AbstractClasses;
using IdfProject.Entities;
using IdfProject.Entities.StrikeUnits;
using IdfProject.Manegers;
using IdfProject.Utils;
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
       

     
            Hamas hamas = new Hamas();
            IntelManeger intelManeger = new IntelManeger(hamas);

            Idf idf = new Idf();
            StrikeManeger strikeManeger = new StrikeManeger(idf);

            ReportManeger reportManeger = new ReportManeger();

            MenuManeger maneger = new MenuManeger(intelManeger, reportManeger, strikeManeger);


            Factory factory = new Factory();
    

            
            List<Terrorist> terrorists = hamas.GetListTerrorist();

            foreach(Terrorist terrorist in terrorists)
            {
                InteligenceMessage inteligenceMessage = new InteligenceMessage(terrorist.GetName(), "home", DateTime.Now, "syber");
                intelManeger.AddInteligenceMessage(inteligenceMessage);
            }

            maneger.MainMenu();

        }
    }
}
