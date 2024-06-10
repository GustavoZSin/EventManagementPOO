using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementPOO.Model.Model
{
    public class Conference : Event
    {
        public Conference(string name, string description, DateTime date, string location) : base(name, description, date, location, EventType.Conference)
        {
        }

        public override string ShowEventDetails()
        {
            return $"Conference Details: [Name: {name}; Description:{description}; Date:{date}; Location:{location}]";
        }
    }
}
