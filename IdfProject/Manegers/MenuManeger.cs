using IdfProject.Entities;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdfProject.Manegers
{
    internal class MenuManeger
    {
        IntelManeger IntelManeger;
        ReportManeger ReportManeger;
        StrikeManeger StrikeManeger;

        public MenuManeger(IntelManeger intelManeger, ReportManeger reportManeger, StrikeManeger strikeManeger)
        {
            this.IntelManeger = intelManeger;
            this.ReportManeger = reportManeger;
            this.StrikeManeger = strikeManeger;
        }



        public void ExecuteAttack()
        {
            Console.WriteLine("enter the name of the terrorist");
            string name = Console.ReadLine();
            Console.WriteLine("enter the type of the weapon to strike");
            string weapon = Console.ReadLine();
            if (IntelManeger.checkExistence(name.ToLower()) && StrikeManeger.checkAvalability(weapon))
            {
                Terrorist terrorist = IntelManeger.Hamas.GetTerroristByName(name);
                string location = IntelManeger.GetTheLastLocaition(terrorist);
                StrikeManeger.Idf.strikeTerrorist(location, weapon, terrorist);
            }
            else
            {
                Console.WriteLine("something went wrong");
            }
        }




        public void MainMenu()
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("___welcome to main menu console!___\n" +
                "1. show command console\n" +
                "5000. to exit\n");
                string choice = Console.ReadLine();
                Console.Clear();

                switch (choice)
                {
                    case "1":
                        ShowMenu();
                        break;
                    case "5000":
                        Console.WriteLine("have a good day");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("invalid choice");
                        break;
                }
            }
            
        }
        public void ShowMenu()
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("___welcome to comand console!___\n" +
                "1. show real time intelegence\n" +
                "2. show availabel ammunition\n" +
                "3. execute attack\n" +
                "4. show attack reports\n" +
                "5. go back\n");
                string choice = Console.ReadLine();
                Console.Clear();

                switch (choice)
                {
                    case "1":
                        IntelegenceMenu();
                        break;
                    case "2":
                        AmmunitionMenu();
                        break;
                    case "3":
                        ExecuteAttack();
                        break;
                    case "4":
                        ReportsMenu();
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("invalid choice");
                        break;
                }
            }
        }
        public void IntelegenceMenu()
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("1. show a list of all targets\n" +
                "2. show the most reported terrorist\n" +
                "3. show the most dangerous torrorist\n" +
                "4. go back");
                string choice = Console.ReadLine();
                Console.Clear();

                switch (choice)
                {
                    case "1":
                        IntelManeger.ShowListOfTargets();
                        break;
                    case "2":
                        IntelManeger.ShowTheMostReportedTerrorist();
                        break;
                    case "3":
                        Console.WriteLine($"the most dangerous terrorist is:\n{IntelManeger.getMostDagerousTerrorist()}");
                        break;
                    case "4":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("invalid choice");
                        break;
                }
            }
            
        }
        public void AmmunitionMenu()
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("1. show a list of all striks\n" +
                "2. show only availabel strikes\n" +
                "3. go back");
                string choice = Console.ReadLine();
                Console.Clear();

                switch (choice)
                {
                    case "1":
                        StrikeManeger.ShowAllStriks();
                        break;
                    case "2":
                        StrikeManeger.ShowAvailabelAllStriks();
                        break;
                    case "3":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("invalid choice");
                        break;
                }
            }
            
        }
        public void ReportsMenu()
        {
            bool runing = true;
            while (runing)
            {
                Console.WriteLine("1. show a list of all reports\n" +
                "2. show reports by date\n" +
                "3. show reports by unit name\n" +
                "4. go back\n");
                string choice = Console.ReadLine();
                Console.Clear();

                switch (choice)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        runing = false;
                        break;
                    default:
                        Console.WriteLine("invalid choice");
                        break;
                }
            }
            
        }

















    }
}
