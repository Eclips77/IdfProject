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
        protected string BombType { get; set; }
        protected string UseTo { get; set; }
        protected int EmmoCap { get; set; }
        protected string StrikeName { get; set; }
        protected int Fuel { get; set; }

        Random rnd = new Random();

        public StrikeUnitBase(string BombType, string UseTo, int EmmoCap, string StrikeName, int Fuel)
        {
            this.BombType = BombType;
            this.UseTo = UseTo;
            this.EmmoCap = EmmoCap;
            this.StrikeName = StrikeName;
            this.Fuel = Fuel;
        }

        public bool strike(string location, Terrorist target)
        {
            int num = rnd.Next(5);
            ConsumeAmmo();
            RedouceFuel();
            Console.WriteLine($"\n{this.StrikeName} bombed the target: {target} in the {location}");
            return num != 0;
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
        public override string ToString()
        {
            return 
                $"StrikeName: {StrikeName}\n" +
                $"BombType: {BombType}\n" +
                $"UseTo: {UseTo}\n" +
                $"EmmoCap: {EmmoCap}\n" +
                $"Fuel: {Fuel}\n";
        }
    }
}



