using IdfProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdfProject.Manegers
{
    internal class IntelManeger
    {
        Dictionary<string, List<InteligenceMessage>> targets = new Dictionary<string, List<InteligenceMessage>>();

        public void AddInteligenceMessage(InteligenceMessage ItelMsg)
        {
            if (!targets.ContainsKey(ItelMsg.GetName()))
            {
                targets[ItelMsg.GetName()] = new List<InteligenceMessage>();
            }
            targets[ItelMsg.GetName()].Append(ItelMsg);
        }
    }
}
