using EventManagementPOO.Model;
using EventManagementPOO.Model.Factory;
using EventManagementPOO.Model.Observer;
using EventManagementPOO.Model.Singleton;

namespace EventManagementPOO.Controller
{
    public class EventController
    {
        private IEventRegisterView _eventView;
        private EventManager _eventManager;

        public EventController(IEventRegisterView eventView, EventManager eventManager)
        {
            _eventManager = eventManager;
            _eventView = eventView;
            eventView.SetController(this);
        }

        public void AddEvent()
        {
            if (string.IsNullOrEmpty(_eventView.EventName.Text) || string.IsNullOrEmpty(_eventView.EventDescription.Text) || string.IsNullOrEmpty(_eventView.EventLocation.Text))
            {
                _eventView.ShowMessage("Please, enter all data to create the event (*)!");
                return;
            }

            string name = _eventView.EventName.Text;
            string description = _eventView.EventDescription.Text;
            DateTime date = _eventView.EventDate.Value;
            DateTime hour = _eventView.EventHour.Value;
            string location = _eventView.EventLocation.Text;
            string type = _eventView.EventType.Text;

            EventFactory factory;

            if (EventType.Conference.ToString().ToUpper().Equals(type.ToUpper()))
                factory = new ConferenceFactory();
            else if (EventType.Workshop.ToString().ToUpper().Equals(type.ToUpper()))
                factory = new WorkshopFactory();
            else
            {
                _eventView.ShowMessage("Invalid event type. Please, try again!");
                return;
            }

            Event newEvent = factory.CreateEvent(name, description, date, hour, location);

            _eventManager.AddEvent(newEvent);

            AddEventToDataGrid(newEvent);
            ClearEventsFields();
        }
        private void AddEventToDataGrid(Event newEvent)
        {
            int indexNewLine = _eventView.Events.Rows.Add();
            DataGridViewRow newLine = _eventView.Events.Rows[indexNewLine];
            newLine.Cells["name"].Value = newEvent.Name.ToString();
            newLine.Cells["description"].Value = newEvent.Description.ToString();
            newLine.Cells["date"].Value = newEvent.Date.ToString("dd/MM/yyyy");
            newLine.Cells["hour"].Value = newEvent.Hour.ToString("HH:mm:ss");
            newLine.Cells["location"].Value = newEvent.Location.ToString();
            newLine.Cells["type"].Value = newEvent.Type.ToString();
            newLine.Tag = newEvent;
        }

        public void RemoveEvent()
        {
            var rows = _eventView.Events.SelectedRows;

            if (rows.Count <= 0)
            {
                _eventView.ShowMessage("Please, select at least one event to remove!");
                return;
            }

            foreach (DataGridViewRow row in rows)
            {
                if (row.Tag is Event)
                {
                    Event eventToRemove = (Event)row.Tag;

                    _eventManager.RemoveEvent(eventToRemove);
                    _eventManager.RemoveAllObserversFrom(eventToRemove);
                    _eventView.Events.Rows.Remove(row);
                    ReloadParticipantsDataGrid();
                }
            }
        }
        public void UpdateEvent()
        {
            if (_eventView.Events.SelectedRows.Count != 1)
            {
                _eventView.ShowMessage("Select one event to update!");
                return;
            }

            Event eventToUpdate = (Event)_eventView.Events.SelectedRows[0].Tag;

            if (eventToUpdate is null)
            {
                _eventView.ShowMessage("The selected line has no valid event to update! Try again!");
                return;
            }

            int index = _eventView.Events.SelectedRows[0].Index;

            string newName = string.IsNullOrEmpty(_eventView.EventName.Text) ? eventToUpdate.Name : _eventView.EventName.Text;
            string newDescription = string.IsNullOrEmpty(_eventView.EventDescription.Text) ? eventToUpdate.Description : _eventView.EventDescription.Text;
            DateTime newDate = Convert.ToDateTime(_eventView.EventDate.Value.ToString());
            DateTime newHour = Convert.ToDateTime(_eventView.EventHour.Value.ToString());
            string newLocation = string.IsNullOrEmpty(_eventView.EventLocation.Text) ? eventToUpdate.Location : _eventView.EventLocation.Text;

            _eventManager.UpdateEvent(eventToUpdate, newName, newDescription, newDate, newHour, newLocation);

            _eventView.Events.Rows[index].Cells["name"].Value = newName;
            _eventView.Events.Rows[index].Cells["description"].Value = newDescription;
            _eventView.Events.Rows[index].Cells["date"].Value = newDate.ToString("dd/MM/yyyy");
            _eventView.Events.Rows[index].Cells["hour"].Value = newHour.ToString("HH:mm:ss");
            _eventView.Events.Rows[index].Cells["location"].Value = newLocation;

            ReloadParticipantsDataGrid();
            ClearEventsFields();
        }

        public List<Event> GetEvents()
        {
            return _eventManager.ListEvents();
        }
        public void ClearEventsFields()
        {
            _eventView.EventName.Text = string.Empty;
            _eventView.EventDescription.Text = string.Empty;
            _eventView.EventDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            _eventView.EventHour.Text = DateTime.Now.ToString("HH:mm:ss");
            _eventView.EventLocation.Text = string.Empty;
        }

        public void AddObserver()
        {
            if (string.IsNullOrEmpty(_eventView.ParticipantName.Text) || string.IsNullOrEmpty(_eventView.ParticipantEmail.Text))
            {
                _eventView.ShowMessage("Please, enter all data to create the observer (*)!");
                return;
            }

            if (_eventView.Events.SelectedRows.Count != 1)
            {
                _eventView.ShowMessage("Please, select only one event to add the participant!");
                return;
            }

            Event eventObject = (Event)_eventView.Events.SelectedRows[0].Tag;

            if (eventObject is null)
            {
                _eventView.ShowMessage("The selected line has no valid event! Try again!");
                return;
            }

            IEventObserver participant = new Participant(_eventView.ParticipantName.Text, _eventView.ParticipantEmail.Text, eventObject);
            _eventManager.AddObserver(participant);

            AddParticipantToDataGrid(participant as Participant);
            ClearObserverFields();
        }
        public void RemoveObserver()
        {
            var rows = _eventView.RegisteredParticipants.SelectedRows;

            if (rows.Count <= 0)
            {
                _eventView.ShowMessage("Please, select at least one participant to remove!");
                return;
            }

            foreach (DataGridViewRow row in rows)
            {
                if (row.Tag is Participant)
                {
                    Participant participant = (Participant)row.Tag;

                    _eventManager.RemoveObserver(participant);
                    _eventView.RegisteredParticipants.Rows.Remove(row);
                }
            }
        }
        private void AddParticipantToDataGrid(Participant participant)
        {
            int indexNewLine = _eventView.RegisteredParticipants.Rows.Add();
            DataGridViewRow newLine = _eventView.RegisteredParticipants.Rows[indexNewLine];
            newLine.Cells["participantName"].Value = participant.Name.ToString();
            newLine.Cells["participantEmail"].Value = participant.Email.ToString();
            newLine.Cells["eventName"].Value = participant.EventObject.Name;
            newLine.Tag = participant;
        }
        private void ReloadParticipantsDataGrid(string oldEventName = null, string newEventName = null)
        {
            _eventView.RegisteredParticipants.Rows.Clear();

            foreach (Participant participant in _eventManager.GetEventObservers())
                AddParticipantToDataGrid(participant);
        }
        private void ClearObserverFields()
        {
            _eventView.ParticipantName.Text = string.Empty;
            _eventView.ParticipantEmail.Text = string.Empty;
        }
    }
}