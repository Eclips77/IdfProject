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

        public void ShowListOfTargets()
        {
            Console.WriteLine("here are all the targets:");
            foreach(string terrorist in targets.Keys)
            {
                Console.WriteLine(terrorist);
            }
        }

        public void ShowTheMostReportedTerrorist()
        {
            int len = 0;
            string mostReported = "";
            foreach(var terrorist in targets)
            {
                if (terrorist.Value.Count > len)
                {
                    len = terrorist.Value.Count;
                    mostReported = terrorist.Key;
                }
            }
            Console.WriteLine($"the most reported terrorist is: {mostReported}, {len} reports have been found.");
        }
    }
}
