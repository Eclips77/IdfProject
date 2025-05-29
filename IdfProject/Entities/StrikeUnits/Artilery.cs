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
        public Artilery(string bombType) : base(bombType, "car", 40, "Artilery", 100)
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

        //public override string ToString()
        //{
        //    return $"BombType: {BombType}\n" +
        //        $"UseTo: {UseTo}\n" +
        //        $"EmmoCap: {EmmoCap}\n" +
        //        $"StrikeName: {StrikeName}\n" +
        //        $"Fuel: {Fuel}\n";
        //}
    }
}
