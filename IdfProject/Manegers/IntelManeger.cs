using IdfProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace IdfProject.Manegers
{
    internal class IntelManeger
    {
        public Hamas Hamas;
        Dictionary<string, List<InteligenceMessage>> targets = new Dictionary<string, List<InteligenceMessage>>();

        public IntelManeger(Hamas hamas)
        {
            this.Hamas = hamas;
        }

        public void AddInteligenceMessage(InteligenceMessage ItelMsg)
        {
            if (!targets.ContainsKey(ItelMsg.GetName()))
            {
                targets[ItelMsg.GetName()] = new List<InteligenceMessage>();
            }
            targets[ItelMsg.GetName()].Add(ItelMsg);
        }

        public Terrorist getMostDagerousTerrorist()
        {
            Terrorist MostDangarous = null;
            Terrorist currentTerrorist;
            int score = 0;

            foreach (var terrorist in this.targets)
            {
                currentTerrorist = Hamas.GetTerroristByName(terrorist.Key);
                int scoreTerrorist = GetScoreTerrorist(currentTerrorist);

                if (scoreTerrorist > score)
                {
                    score = scoreTerrorist;
                    MostDangarous = currentTerrorist;
                }
            }
            return MostDangarous;
        }

        public int GetScoreTerrorist(Terrorist terrorist)
        {
            return terrorist.GetDangerLevel();
        }

        public string GetTheLastLocaition(Terrorist terrorist)
        {
            int lastIndex = targets[terrorist.GetName()].Count - 1;
            string location = targets[terrorist.GetName()][lastIndex].GetLocation();
            return location;
        }

        public bool checkExistence(string name)
        {
            return targets.ContainsKey(name);
        }
    }
}
