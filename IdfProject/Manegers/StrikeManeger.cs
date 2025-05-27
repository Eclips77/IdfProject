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
        public Idf Idf;

        public StrikeManeger(Idf idf)
        {
            this.Idf = idf;
        }

        public void ssssstrikeTerrorist(Terrorist terrorist, string locaition)
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


        //public void strikeTerrorist(string weapon, string terrorist)
        //{
        //    List<StrikeUnitBase> avalibelStrikes = this.Idf.GetAllStrikesAvalibel();
        //    StrikeUnitBase chosenWeapon = avalibelStrikes.;
        //}

        public void SortStrikesByEfectivnes(List<StrikeUnitBase> strikes, string locaition)
        {
            // sort the list when the suitabl strikes are first, and less after.
            //List<StrikeUnitBase> sortedStrikes = new List<StrikeUnitBase>();
            //foreach (StrikeUnitBase strike in strikes)
            //{
            //    if (strike.GetUseTo() == locaition)
            //    {
            //        sortedStrikes.Insert(0, strike);
            //    }
            //    else
            //    {
            //        sortedStrikes.Add(strike);
            //    }
            //}
            //strikes = sortedStrikes;


            strikes.Sort((a, b) =>
            {
                bool aMech = a.GetUseTo() == locaition;
                bool bMech = b.GetUseTo() == locaition;
                return aMech == bMech ? 0 : (aMech ? -1 : 1);
            });
        }


        public bool checkAvalability(string weapon)
        {
            List<StrikeUnitBase> avalebalStrikes = Idf.GetAllStrikesAvalibel();
            bool available = false;
            foreach (StrikeUnitBase strikeUnit in avalebalStrikes)
            {
                if (strikeUnit.GetStrikeName() == weapon)
                {
                    available = true;
                    break;
                }
            }
            return available;
        }

        public void ShowAllStriks()
        {
            List<StrikeUnitBase> strikeUnits = Idf.GetAllStriks();
            PrintListStriks(strikeUnits);
        }
        public void ShowAvailabelAllStriks()
        {
            List<StrikeUnitBase> strikeUnitsAvalibel = Idf.GetAllStrikesAvalibel();
            PrintListStriks(strikeUnitsAvalibel);
        }
        public void PrintListStriks(List<StrikeUnitBase> strikeUnits)
        {
            foreach(StrikeUnitBase strikeUnit in strikeUnits)
            {
                Console.WriteLine(strikeUnit);
            }
        }
    }
}
