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

    }
}
