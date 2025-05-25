using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdfProject.Entities
{
    internal class InteligenceMessage
    {
        private string Name;
        private string Location;
        private DateTime Timestamp;
        private string Source;

        public InteligenceMessage(string name, string location, DateTime timestamp, string source)
        {
            this.Name = name;
            this.Location = location;
            this.Timestamp = timestamp;
            this.Source =source;
        }

        public string GetName()
        {
            return this.Name;
        }

        public string GetLocation()
        {
            return this.Location;
        }
    }
}
