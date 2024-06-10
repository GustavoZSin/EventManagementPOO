using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementPOO.Model
{
    public class Conference : Event
    {
        public Conference(string name, string description, DateTime date, DateTime hour, string location) : base(name, description, date, hour, location, EventType.Conference)
        {
        }

        public override string ShowEventDetails()
        {
            return $"Conference Details: [Name: {Name}; Description:{Description}; Date:{Date}; Hour:{Hour}; Location:{Location}]";
        }
    }
}
