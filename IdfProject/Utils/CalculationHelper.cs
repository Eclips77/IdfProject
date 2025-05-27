using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdfProject.AbstractClasses;
using IdfProject.Entities;
using IdfProject.Entities.StrikeUnits;

namespace IdfProject.Utils
{
    internal class Factory
    {
        static Random rnd = new Random();

        static string[] TerroristNames = { "Ahmed", "Khaled", "Omar", "Yassin", "Bilal" };
        static string[] Weapons = { "AK-47", "HandGUn", "Knife" };

        static string[] bombTypes = { "Laser", "Guided", "Cluster", "High-Explosive" };

        //static string[] StrikeUnitNames = { "Alpha-1", "Beta-2", "Gamma-3", "SkyHawk", "Falcon" };  

        public Terrorist CreateTerrorist()
        {
            string name = TerroristNames[rnd.Next(TerroristNames.Length)];
            int rank = rnd.Next(1, 6);
            bool alive = true;
            var weapons = Weapons.OrderBy(x => rnd.Next()).Take(rnd.Next(1, 3)).ToList();
            var terrorist = new Terrorist(name, rank, alive, weapons);
            return terrorist;
        }

        public List<Terrorist> CreateTerroristList(int count)
        {
            List<Terrorist> t = new List<Terrorist>();
            for (int i = 0; i < count; i++)
            {
                t.Add(CreateTerrorist());
            }
            return t;
        }

        public StrikeUnitBase CreateStrikeUnit(int choice)
        {
            string bomb = bombTypes[rnd.Next(bombTypes.Length)]; 
            switch (choice)
            {
                case 0:
                    return new F16(bomb);
                case 1:
                    return new Drone(bomb);
                default:
                    return new Artilery(bomb);
            }
        }
        public List<StrikeUnitBase> CreateStrikeUnitsList()
        {
            var list = new List<StrikeUnitBase>();
            for (int i = 0; i < 3; i++)
            {
                list.Add(CreateStrikeUnit(i));
            }
            return list;
        }

    }
}
