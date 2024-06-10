namespace EventManagementPOO.Model.Observer
{
    public class Participant : IEventObserver
    {
        private string name;
        private string email;
        private Event eventObject;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public Event EventObject
        {
            get { return eventObject; }
            set { eventObject = value; }
        }

        public Participant(string name, string email, Event eventObject)
        {
            this.name = name;
            this.email = email;
            this.eventObject = eventObject;
        }

        public void Update(string message)
        {
            MessageBox.Show($"Participant {name} (event:{eventObject.Name}) was notified! {message}");
        }
    }
}
