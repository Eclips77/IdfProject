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
        string UseTo = "car";
        int EmmoCap = 40;
        int Fuel = 100;
        string StrikeName = "Artilery";

        public Artilery(string bombType)
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
            this.Fuel -= 2; 
        }
        public override void CoolDown()
        {
            this.EmmoCap = 40;
            this.Fuel = 100;
        }
    }
}
