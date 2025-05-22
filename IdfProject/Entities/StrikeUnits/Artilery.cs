using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdfProject.AbstractClasses;

namespace IdfProject.Entities.StrikeUnits
{
    internal class Artilery : StrikeUnitBase
    {
        string BombType;
        string UseTo;
        int EmmoCap = 40;
        int Fuel = 100;

        public Artilery(string bombType, string useTo, int emmoCap, int fuel)
        {
            this.BombType = bombType;
            this.UseTo = useTo;
            this.EmmoCap = emmoCap;
            this.Fuel = fuel;
        }
        public bool CanStrike()
        {
            if (this.Fuel > 20 && this.EmmoCap > 0)
            {
                return true;
            }
            return false;
        }
        public override void strike(string location, string target)
        {
            Console.WriteLine($"artilery bombed the target: {target} in the {location}");
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
            this.Fuel -= 2; 
        }
        public override void CoolDown()
        {
            this.EmmoCap = 40;
            this.Fuel = 100;
        }
    }
}
