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

        public int GetDangerLevel()
        {
            int DangerLevel = this.Rank * this.
        }

    }   

}
