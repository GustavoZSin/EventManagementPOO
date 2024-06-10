using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementPOO.Model.Model
{
    public class Workshop : Event
    {
        public Workshop(string name, string description, DateTime date, string location) : base(name, description, date, location, EventType.Workshop)
        {
        }

        public override string ShowEventDetails()
        {
            return $"Workshop Details: [Name: {name}; Description:{description}; Date:{date}; Location:{location}]";
        }
    }
}
