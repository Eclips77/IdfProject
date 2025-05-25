using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdfProject.AbstractClasses;

namespace IdfProject.Entities
{
    internal class Idf
    {
        private string Establishment = "28/5/1948";
        private string CurrentCommander = "Eyal Zamir";
        List<StrikeUnitBase> strikeUnits = new List<StrikeUnitBase>();


        public void AddStrikeUnit(StrikeUnitBase strikeUnit)
        {
            this.strikeUnits.Add(strikeUnit);
        }

        public void RemoveStrikeUnit(StrikeUnitBase strikeUnit)
        {
            this.strikeUnits.Remove(strikeUnit);
        }

        public List<StrikeUnitBase> GetAllStrikesAvalibel()
        {
            List<StrikeUnitBase> avalibelStrikes = new List<StrikeUnitBase>();

            foreach (StrikeUnitBase strike in this.strikeUnits)
            {
                if (strike.CanStrike())
                {
                    avalibelStrikes.Add(strike);
                }
            }
            return avalibelStrikes;
        }

        public void strikeTerrorist(string location, string weapon, Terrorist terrorist)
        {
            int index = -1;
            for (int i = 0; i < strikeUnits.Count(); i++)
            {
                if (strikeUnits[i].GetStrikeName() == weapon)
                {
                    index = i;
                    break;
                }
            }
            strikeUnits[index].strike(location, terrorist);
        }
    }
}
