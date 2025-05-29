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
        public F16(string bombType) : base(bombType, "building", 8, "F16", 100)
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
        public override void RedouceFuel()
        {
            this.Fuel-=10;
        }
        public override void CoolDown()
        {
            this.EmmoCap = 8;
            this.Fuel = 100;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
