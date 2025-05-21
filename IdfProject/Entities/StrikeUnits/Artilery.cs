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
        public override void strike(string location, string target)
        {
            Console.WriteLine($"artilery bombed the target: {target} in the {location}");
        }
        public override void ConsumeAmmo()
        {

        }
        public override void CheckFuel()
        {

        }
    }
}
