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

        public string MainMenu()
        {
            Console.WriteLine("___welcome to main menu console!___\n" +
                "1. show command consloe\n" +
                " ");
            string choice = Console.ReadLine();
            return choice;
        }







        public string ShowMenu()
        {
            Console.WriteLine("___welcome to comand console!___\n");
            Console.WriteLine("1. execute attack !!!!:\n");
            Console.WriteLine("2. get intelegence on hamas:\n");
            Console.WriteLine("3. get intelegence on idf:\n");
            Console.WriteLine("4. get intelegence on all targets:\n");
            string choice = Console.ReadLine();
            return choice;
        }


        public void HandelMenuChoice(string choice)
        {
            switch (choice)
            {
                case "1":
                    ExecuteAttack();
                    break;
                case "2":
                    break;
                case "3":
                    break;
                default:
                    Console.WriteLine("invalid choice");
                    break;
            }
        }

























        //public string  ShowMenu()
        //{
        //    Console.WriteLine("___welcome to comand console!___\n");
        //    Console.WriteLine("1. intelegence on hamas:\n");
        //    Console.WriteLine("2. avalibale attack units:\n");
        //    Console.WriteLine("3. all the targets:\n");
        //    Console.WriteLine("4. to attack console:\n");
        //    string choice =Console.ReadLine();
        //    return choice;
        //}

        //public string ShowHamasMenu()
        //{
        //    Console.WriteLine("___welcome to hamas console!___\n");
        //    Console.WriteLine("1. date of establishment:\n");
        //    Console.WriteLine("2. commanders name:\n");
        //    Console.WriteLine("3. all the terrorists:\n");  /////
        //    Console.WriteLine("3. all alive terrorists:\n");
        //    string choice = Console.ReadLine();
        //    return choice;
        //}

        //public string ShowUnitsMenu()
        //{
        //    Console.WriteLine("___welcome to attack console!___\n");
        //    Console.WriteLine("1. show all strikes:\n");
        //    Console.WriteLine("2. avalibale attack units:\n");
        //    Console.WriteLine("3. show only one type (F16 / Drone / Artilary):\n");
        //    string choice = Console.ReadLine();
        //    return choice;
        //}

        //public string ShowTargetsMenu()
        //{
        //    Console.WriteLine("___welcome to target console!___\n");
        //    Console.WriteLine("1. :\n");
        //    Console.WriteLine("2. avalibale attack units:\n");
        //    Console.WriteLine("3. all the targets:\n");
        //    string choice = Console.ReadLine();
        //    return choice;
        //}

        //public string ShowAttackMenu()
        //{
        //    Console.WriteLine("___welcome to attack console!___\n");
        //    Console.WriteLine("1. get the most dangerous terrorist:\n");
        //    Console.WriteLine("2. strike terrorist:\n");
        //    Console.WriteLine("3. all the targets:\n");
        //    string choice = Console.ReadLine();
        //    return choice;
        //}




















    }
}
