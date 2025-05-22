using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdfProject.Entities
{
    internal class Hamas
    {
        private string Establishment = "06/11/1992";
        private string CurrentCommander = "Muchamad..";
        List<Terrorist> terrorists = new List<Terrorist>();


        public void AddTerrorist(Terrorist terrorist)
        {
            terrorists.Add(terrorist);
        }

        public void RemoveTerrorist(Terrorist terrorist)
        {
            terrorists.Remove(terrorist);
        }

        public Terrorist GetTerroristByName(string name)
        {
            Terrorist wantedTerrorist = null;
            foreach (Terrorist terrorist in this.terrorists)
            {
                if (terrorist.GetName() == name)
                {
                    wantedTerrorist = terrorist;
                }
            }
            return wantedTerrorist;
        }
    }
}
