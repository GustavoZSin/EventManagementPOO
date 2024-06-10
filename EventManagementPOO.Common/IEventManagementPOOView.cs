using EventManagementPOO.Controller;
using System;
using System.Security.Principal;
using System.Windows.Forms;

namespace EventManagementPOO.View
{
    public interface IEventManagementPOOView
    {
        void SetController(EventController eventController);
        Windows.ListBox Events { get; set; }
        TextBox EventName { get; set; }
        TextBox EventDescription { get; set; }
        DateTimePicker EventDate { get; set; }
        TextBox EventLocation { get; set; }
        ComboBox EventType { get; set; }
    }
}
