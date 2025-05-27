using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdfProject.AbstractClasses;
using IdfProject.Entities;
using IdfProject.Entities.StrikeUnits;
using Bogus;

namespace IdfProject.Utils
{
    internal class Factory
    {
        static Faker faker = new Faker("en");
        static Random rnd = new Random();

        static string[] Weapons = { "AK-47", "HandGUn", "Knife", "m16" };

        static string[] bombTypes = { "Laser", "Guided", "Cluster", "High-Explosive" };

        //static string[] StrikeUnitNames = { "Alpha-1", "Beta-2", "Gamma-3", "SkyHawk", "Falcon" };  

        public Terrorist CreateTerrorist()
        {
            string name = faker.Name.FirstName();
            int rank = rnd.Next(1, 6);
            bool alive = true;
            var weapons = Weapons.OrderBy(x => rnd.Next()).Take(rnd.Next(1, 3)).ToList();
            var terrorist = new Terrorist(name, rank, alive, weapons);
            return terrorist;
        }

        public StrikeUnitBase CreateStrikeUnit(int choice)
        {
            string bomb = bombTypes[rnd.Next(bombTypes.Length)];
            choice = choice % 3;
            switch (choice)
            {
                case 1:
                    return new F16(bomb);
                case 2:
                    return new Drone(bomb);
                default:
                    return new Artilery(bomb);
            }
        }
        public List<StrikeUnitBase> CreateStrikeUnitsList()
        {
            var list = new List<StrikeUnitBase>();
            for (int i = 0; i < 20; i++)
            {
                list.Add(CreateStrikeUnit(i));
            }
            return list;
        }





    }
}
