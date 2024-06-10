using EventManagementPOO.Model.Model;
using System.Xml.Linq;
using TrabalhoPOOPadroesProjeto.Observer;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EventManagementPOO.Model.Singleton
{
    public class EventManager
    {
        //Singleton
        public static EventManager _instance = null;
        private List<Event> _events;

        //Observer
        private List<IEventObserver> _observers;

        private EventManager()
        {
            _events = new List<Event>();
            _observers = new List<IEventObserver>();
        }
        public static EventManager GetInstance()
        {
            if (_instance == null)
                _instance = new EventManager();

            return _instance;
        }

        public void AddEvent(Event newEvent)
        {
            _events.Add(newEvent);
            NotifyObservers($"New event '{newEvent.Name}' was created.");
        }
        public void RemoveEvent(Event eventToRemove)
        {
            _events.Remove(eventToRemove);
            NotifyObservers($"Event {eventToRemove.Name} was removed.");
        }
        public void UpdateEvent(Event eventToUpdate, string newName, string newDescription, DateTime newDate, string newLocation)
        {
            NotifyObservers($"Event '{eventToUpdate.Name}' was updated. New details: " +
            $"[Name: {newName}; Description: {newDescription}; " +
            $"Date: {newDate}; Location: {newLocation}].");

            eventToUpdate.Name = newName;
            eventToUpdate.Description = newDescription;
            eventToUpdate.Date = newDate;
            eventToUpdate.Location = newLocation;
        }
        public List<Event> ListEvents()
        {
            return _events;
        }

        public void AddObserver(IEventObserver observer)
        {
            _observers.Add(observer);
        }
        public void RemoveObserver(IEventObserver observer)
        {
            _observers.Remove(observer);
        }
        private void NotifyObservers(string message)
        {
            _observers.ForEach(o => o.Update(message));
        }
    }
}
