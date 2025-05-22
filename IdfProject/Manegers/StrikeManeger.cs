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
            
        }

        public void SortStrikesByEfectivnes(List<StrikeUnitBase> strikes, string locaition)
        {
            List<StrikeUnitBase> sortedStrikes = new List<StrikeUnitBase>();
            foreach (StrikeUnitBase strike in strikes)
            {
                if (strike.GetUseTo())
            }
        }

    }
}
