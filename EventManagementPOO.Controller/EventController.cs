using EventManagementPOO.Model.Factory;
using EventManagementPOO.Model.Model;
using EventManagementPOO.Model.Singleton;

namespace EventManagementPOO.Controller
{
    public class EventController
    {
        private readonly EventManager _eventManager;

        public EventController(IEventManagementPOOView eventView, EventManager eventManager)
        {
            _eventManager = eventManager;
        }

        public void AddEvent(string name, string description, DateTime date, string location, string type)
        {
            EventFactory factory;

            if (EventType.Conference.ToString().ToUpper().Equals(type.ToUpper()))
                factory = new ConferenceFactory();
            else if (EventType.Workshop.ToString().ToUpper().Equals(type.ToUpper()))
                factory = new WorkshopFactory();
            else 
                return;

            Event newEvent = factory.CreateEvent(name, description, date, location);
            _eventManager.AddEvent(newEvent);
        }

        public void RemoveEvent(Event eventToRemove)
        {
            _eventManager.RemoveEvent(eventToRemove);
        }

        public void UpdateEvent(Event eventToUpdate, string newName, string newDescription, DateTime newDate, string newLocation)
        {
            _eventManager.UpdateEvent(eventToUpdate, newName, newDescription, newDate, newLocation);
        }

        public List<Event> GetEvents()
        {
            return _eventManager.ListEvents();
        }
    }
}