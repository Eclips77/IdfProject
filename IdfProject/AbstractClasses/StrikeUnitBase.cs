using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdfProject.Iterfaces;

namespace IdfProject.AbstractClasses
{
    abstract class StrikeUnitBase : IStrikeUnit
    {
        public virtual void strike(string location,string target)
        {

        }
        public virtual int ChekEmmoCap()
        {
            return 0;
        }
        public virtual void ConsumeAmmo()
        {

        }
        public virtual int CheckFuel()
        {
            return 0;
        }
        public virtual void RedouceFuel()
        {
            
        }
    }
}



