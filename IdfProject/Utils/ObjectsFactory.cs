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
        static Random rnd = new Random();
        static string[] bombTypes = { "Laser", "Guided", "Cluster", "High-Explosive" };


        public IEnumerable<Terrorist> CreateTerrorists(List<TerroristData> dataList)
        {

            foreach (var data in dataList)
            {
                var terrorist = new Terrorist(
                    data.Name,
                    data.Rank,
                    data.Alive,
                    data.Weapons.ToList()
                );
                yield return terrorist;
            }

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
