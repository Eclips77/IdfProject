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
        string UseTo;
        int EmmoCap;
        string StrikeName;
        int Fuel;
        public  void strike(string location, Terrorist target)
        {
            Console.WriteLine($"\n{this.StrikeName} bombed the target: {target} in the {location}");
        }
        public int ChekEmmoCap()
        {
            return this.EmmoCap;
        }
        public void ConsumeAmmo()
        {
            this.EmmoCap--;
        }
        public int CheckFuel()
        {
            return this.Fuel;
        }
        public abstract void RedouceFuel();
        public abstract void CoolDown();
        public abstract bool CanStrike();
        public string GetUseTo()
        {
            return this.UseTo;
        }
        public string GetStrikeName()
        {
            return this.StrikeName;
        }
    }
}



