using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdfProject.AbstractClasses;

namespace IdfProject.Entities.StrikeUnits
{
    internal class Drone : StrikeUnitBase
    {
        string BombType;
        string UseTo;
        int EmmoCap = 3;
        int Fuel = 100;
        public override void strike(string location, string target)
        {
            Console.WriteLine($"Drone attacking the target: {target} in the {location}");
        }
        public override int ChekEmmoCap()
        {
            return this.EmmoCap;
        }
        public override void ConsumeAmmo()
        {
            this.EmmoCap--;
        }
        public override int CheckFuel()
        {
            return this.Fuel;
        }
        public override void RedouceFuel()
        {
            this.Fuel--;
        }
    }
}
