using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdfProject.AbstractClasses;

namespace IdfProject.Entities.StrikeUnits
{
    internal class F16 : StrikeUnitBase
    {
        public override void strike(string location,string target)
        {
            Console.WriteLine($"F16 striked the target: {target} in the {location}");
        }
        public override void ConsumeAmmo()
        {

        }
        public override void CheckFuel()
        {

        }
    }
}
