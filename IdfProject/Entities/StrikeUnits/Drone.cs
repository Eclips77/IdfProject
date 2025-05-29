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
        string UseTo = "person";
        int EmmoCap = 3;
        int Fuel = 100;
        string StrikeName = "Drone";

        public Drone(string bombType)
        {
            this.BombType = bombType;
        }
        public override bool CanStrike()
        {
            if (this.Fuel > 10 && this.EmmoCap > 0)
            {
                return true;
            }
            return false;
        }
        public override void RedouceFuel()
        {
            this.Fuel-= 30;
        }
        public override void CoolDown()
        {
            this.EmmoCap = 3;
            this.Fuel = 100;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
