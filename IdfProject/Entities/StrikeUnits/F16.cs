using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using IdfProject.AbstractClasses;

namespace IdfProject.Entities.StrikeUnits
{
    internal class F16 : StrikeUnitBase
    {
        string BombType;
        string UseTo = "building";
        int EmmoCap = 8;
        int Fuel = 100;
        string StrikeName = "F16";

        public F16(string bombType)
        {
            this.BombType = bombType;
        }
        public override bool CanStrike()
        {
            if (this.Fuel > 20 && this.EmmoCap > 0)
            {
                return true;
            }
            return false;
        }
        //public override void strike(string location,Terrorist target)
        //{
        //    Console.WriteLine($"F16 striked the target: {target} in the {location}");
        //}
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
            this.Fuel-=10;
        }
        public override void CoolDown()
        {
            this.EmmoCap = 8;
            this.Fuel = 100;
        }
        public override string GetUseTo()
        {
            return this.UseTo;
        }
    }
}
