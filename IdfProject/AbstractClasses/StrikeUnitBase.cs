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
        string BombType;
        string UseTO;
        int EmmoCap;
        public abstract void strike(string location, string target);
        public abstract int ChekEmmoCap();
        public abstract void ConsumeAmmo();
        public abstract int CheckFuel();
        public abstract void RedouceFuel();
        public abstract void CoolDown();
        public abstract bool CanStrike();
       
    }
}



