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
        private string Rank;
        private bool Alive;
        private List<string> Weapons;

        public Terrorist(string name, string rank, bool alive, List<string> weapons)
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
    }
}
