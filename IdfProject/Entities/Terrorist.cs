using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdfProject.Entities
{
    internal class Terrorist
    {
        private string Name;
        private int Rank;
        private bool Alive;
        private List<string> Weapons;

        public Terrorist(string name, int rank, bool alive, List<string> weapons)
        {
            this.Name = name;
            this.Rank = rank;
            this.Alive = alive;
            this.Weapons = weapons;
        }

        public string GetName()
        {
            return this.Name;
        }

        public void KillTerrorist()
        {
            this.Alive = false;
        }

        public int GetDangerLevel()
        {
            int score = 0;
            foreach (string wepon in this.Weapons)
            {
                if (wepon.ToLower() == "m16" || wepon.ToLower() == "ak-47") score += 3;
                else if (wepon.ToLower() == "handgun") score += 2;
                else if (wepon.ToLower() == "knife") score += 1;
            }
            return this.Rank * score;
        }

        public bool IsAlive()
        {
            return this.Alive;
        }

        public override string ToString()
        {
            return $"Name: {this.Name}\n" +
                $"Rank: {this.Rank}\n" +
                $"Alive: {this.Alive}\n" +
                $"Weapons: {string.Join(", ", this.Weapons)}\n";
        }

    }   

}
