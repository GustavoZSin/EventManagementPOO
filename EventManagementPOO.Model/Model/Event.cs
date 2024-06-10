using TrabalhoPOOPadroesProjeto.Observer;

namespace EventManagementPOO.Model.Model
{
    public abstract class Event
    {
        public string name;
        public string description;
        public DateTime date;
        public string location;
        public EventType type;
        private List<IEventObserver> _observers;
        public Event(string name, string description, DateTime date, string location, EventType type)
        {
            this.name = name;
            this.description = description;
            this.date = date;
            this.location = location;
            this.type = type;
            _observers = new List<IEventObserver>();
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        public EventType Type
        {
            get { return type; }
            set { type = value; }
        }

        public abstract string ShowEventDetails();

        public void UpdateEvent(string newName, string newDescription, DateTime newDate, string newLocation)
        {
            NotifyObservers($"Event '{name}' was updated. New details: " +
                $"[Name: {name}; Description: {description}; Date: {date}; Location: {location}].");

            this.name = newName;
            this.description = newDescription;
            this.date = newDate;
            this.location = newLocation;
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