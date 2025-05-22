using IdfProject.AbstractClasses;
using IdfProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IdfProject.Manegers
{
    internal class StrikeManeger
    {
        Idf Idf;

        public StrikeManeger(Idf idf)
        {
            this.Idf = idf;
        }

        public void strikeTerrorist(Terrorist terrorist, string locaition)
        {
            List<StrikeUnitBase> avalibelStrikes = this.Idf.GetAllStrikesAvalibel();
            SortStrikesByEfectivnes(avalibelStrikes, locaition);
            if (avalibelStrikes.Count > 0)
            {
                StrikeUnitBase chosenStrike = avalibelStrikes[0];
                chosenStrike.strike(locaition, terrorist);
            }
            else
            {
                Console.WriteLine("there is no strikes avaleble");
            }
            
        }



        public void SortStrikesByEfectivnes(List<StrikeUnitBase> strikes, string locaition)
        {
            // sort the list when the suitabl strikes are first, and less after.
            List<StrikeUnitBase> sortedStrikes = new List<StrikeUnitBase>();
            foreach (StrikeUnitBase strike in strikes)
            {
                if (strike.GetUseTo() == locaition)
                {
                    sortedStrikes.Insert(0, strike);
                }
                else
                {
                    sortedStrikes.Add(strike);
                }
            }
            strikes = sortedStrikes;
        }

    }
}
