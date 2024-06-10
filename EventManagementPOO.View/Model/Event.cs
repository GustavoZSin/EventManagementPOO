using EventManagementPOO.Model.Observer;

namespace EventManagementPOO.Model
{
    public abstract class Event
    {
        private string id;
        private string name;
        private string description;
        private DateTime date;
        private DateTime hour;
        private string location;
        private EventType type;
        private List<IEventObserver> _observers;
        public Event(string name, string description, DateTime date, DateTime hour, string location, EventType type)
        {
            this.id = Guid.NewGuid().ToString();
            this.name = name;
            this.description = description;
            this.date = date;
            this.hour = hour;
            this.location = location;
            this.type = type;
            _observers = new List<IEventObserver>();
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
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
        public DateTime Hour
        {
            get { return hour; }
            set { hour = value; }
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

        public void UpdateEvent(string newName, string newDescription, DateTime newDate, DateTime newHour, string newLocation)
        {
            NotifyObservers($"Event '{name}' was updated. New details: " +
                $"[Name: {name}; Description: {description}; Date: {date}; Hour: {hour}; Location: {location}].");

            this.name = newName;
            this.description = newDescription;
            this.date = newDate;
            this.hour = newHour;
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