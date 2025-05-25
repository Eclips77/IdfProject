using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdfProject.Entities;
using IdfProject.Iterfaces;

namespace IdfProject.AbstractClasses
{
    abstract class StrikeUnitBase : IStrikeUnit
    {
        string BombType;
        string UseTO;
        int EmmoCap;
        string StrikeName;
        public  void strike(string location, Terrorist target)
        {
            ConsumeAmmo();
            RedouceFuel();
            Console.WriteLine($"\n{this.StrikeName} bombed the target: {target} in the {location}");
        }
        public abstract int ChekEmmoCap();
        public abstract void ConsumeAmmo();
        public abstract int CheckFuel();
        public abstract void RedouceFuel();
        public abstract void CoolDown();
        public abstract bool CanStrike();
        public abstract string GetUseTo();
    }
}



