using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementPOO.Model
{
    public class Workshop : Event
    {
        public Workshop(string name, string description, DateTime date, DateTime hour, string location) : base(name, description, date, hour, location, EventType.Workshop)
        {
        }

        public override string ShowEventDetails()
        {
            return $"Workshop Details: [Name: {Name}; Description:{Description}; Date:{Date}; Hour:{Hour}; Location:{Location}]";
        }
    }
}
