using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdfProject.Manegers
{
    internal class MenuManeger
    {
        public string ShowMenu()
        {
            Console.WriteLine("___welcome to comand console!___\n");
            Console.WriteLine("1. intel analyze show the most reported terrorist:\n");
            Console.WriteLine("2. avalibale attack units:\n");
            Console.WriteLine("3. get the most dangoures terrorist:\n");
            Console.WriteLine("4. attack console:\n");
            Console.WriteLine("5. show attack report:");
            string choice = Console.ReadLine();
            return choice;
        }

        public void HandelChoice(string choice)
        {
            switch (choice)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                default:
                    Console.WriteLine("invalid choice please try again");
                    break;
            }
        }
    }
}
