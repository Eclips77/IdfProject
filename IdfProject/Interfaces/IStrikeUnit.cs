using IdfProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdfProject.Iterfaces
{
    internal interface IStrikeUnit
    {
        bool strike(string location, Terrorist target);
        int ChekEmmoCap();
        void ConsumeAmmo();
        int CheckFuel();
        void RedouceFuel();
    }
}
