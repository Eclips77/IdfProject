using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdfProject.Manegers
{
    internal class MenuManeger
    {
        public string  ShowMenu()
        {
            Console.WriteLine("___welcome to comand consule!___\n");
            Console.WriteLine("1. intel analyze show the most reported terrorist:\n");
            Console.WriteLine("2. avalibale attack units:\n");
            Console.WriteLine("3. select target by dangoures:\n");
            Console.WriteLine("attacking target!\n");
            Console.WriteLine("show attack report:");
            string choice =Console.ReadLine();
            return choice;
        }


    }
}
