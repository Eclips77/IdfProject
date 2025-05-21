using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdfProject.Iterfaces
{
    internal interface IStrikeUnit
    {
        void strike(string location,string target);
        void ConsumeAmmo();
        void CheckFuel();
    }
}
