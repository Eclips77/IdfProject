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

        public void KillTerroristByName(string name)
        {
            foreach(Terrorist terrorist in terrorists)
            {
                if (terrorist.GetName() == name)
                {
                    terrorist.KillTerrorist();
                    break;
                }
            }
        }
        
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
            foreach (Terrorist terroris in this.terrorists)
            {
                if (terroris.GetName() == name)
                {
                    wantedTerrorist = terroris;
                    break;
                }
            }
            return wantedTerrorist;
        }

        public List<Terrorist> GetListTerrorist()
        {
            return this.terrorists;
        }

        public List<Terrorist> GetAllTerrorist()
        {
            return this.terrorists;
        }
        public List<Terrorist> GetAliveTerrorist()
        {
            List<Terrorist> terrorists = new List<Terrorist>();
            foreach(Terrorist terrorist in terrorists)
            {
                if (terrorist.IsAlive())
                {
                    terrorists.Add(terrorist);
                }
            }
            return terrorists;
        }
        public List<Terrorist> GetDedTerrorist()
        {
            List<Terrorist> terrorists = new List<Terrorist>();
            foreach (Terrorist terrorist in terrorists)
            {
                if (!terrorist.IsAlive())
                {
                    terrorists.Add(terrorist);
                }
            }
            return terrorists;
        }
        public void PrintTerrorists(List<Terrorist> terrorists)
        {
            Console.WriteLine($"Thre is {terrorists.Count} terrorists:");
            foreach(Terrorist terrorist in terrorists)
            {
                Console.WriteLine(terrorist);
            }
        }
    }
}
