using EventManagementPOO.Model.Observer;

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
            NotifyObservers(newEvent.Name, $"New event '{newEvent.Name}' was created.");
        }
        public void RemoveEvent(Event eventToRemove)
        {
            _events.Remove(eventToRemove);
            NotifyObservers(eventToRemove.Name, $"Event {eventToRemove.Name} was removed. You'll be removed from this event");
        }
        public void UpdateEvent(Event eventToUpdate, string newName, string newDescription, DateTime newDate, DateTime newHour, string newLocation)
        {
            NotifyObservers(eventToUpdate.Name, $"Event '{eventToUpdate.Name}' was updated. New details: " +
            $"[Name: {newName}; Description: {newDescription}; " +
            $"Date: {newDate:dd/MM/yyyy}; Hour: {newHour:HH:mm:ss}; Location: {newLocation}].");

            eventToUpdate.Name = newName;
            eventToUpdate.Description = newDescription;
            eventToUpdate.Date = newDate;
            eventToUpdate.Hour = newHour;
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

        public List<IEventObserver> GetEventObservers()
        {
            return _observers;
        }
        private void NotifyObservers(string eventName, string message)
        {
            foreach (Participant observer in _observers)
            {
                if (observer.EventObject.Name == eventName)
                    observer.Update(message);
            }
        }

        public void RemoveAllObserversFrom(Event eventToRemove)
        {
            List<Participant> participantsToRemove = new List<Participant>();

            foreach (Participant participant in _observers)
            {
                if (participant.EventObject.Equals(eventToRemove))
                    participantsToRemove.Add(participant);
            }

            foreach(Participant participant in participantsToRemove)
            {
                _observers.Remove(participant);
            }
        }
    }
}