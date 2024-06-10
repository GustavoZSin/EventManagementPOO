using EventManagementPOO.Controller;

namespace EventManagementPOO.View
{
    public partial class EventRegisterView : Form, IEventRegisterView
    {
        EventController controller;
        public EventRegisterView()
        {
            InitializeComponent();
        }

        #region Implementação da interface IEventManagementPOOView
        public TextBox EventName
        {
            get { return txbEventName; }
            set { txbEventName = value; }
        }
        public TextBox EventDescription
        {
            get { return txbEventDescription; }
            set { txbEventDescription = value; }
        }
        public DateTimePicker EventDate
        {
            get { return dtpEventDate; }
            set { dtpEventDate = value; }
        }
        public DateTimePicker EventHour
        {
            get { return dtpEventHour; }
            set { dtpEventHour = value; }
        }
        public TextBox EventLocation
        {
            get { return txbEventLocation; }
            set { txbEventLocation = value; }
        }
        public ComboBox EventType
        {
            get { return cbxEventType; }
            set { cbxEventType = value; }
        }
        DataGridView IEventRegisterView.Events
        {
            get { return dgvEvents; }
            set { dgvEvents = value; }
        }
        public TextBox ParticipantName
        {
            get { return txbParticipantName; }
            set { txbParticipantName = value; }
        }
        public TextBox ParticipantEmail
        {
            get { return txbParticipantEmail; }
            set { txbParticipantEmail = value; }
        }
        public DataGridView RegisteredParticipants
        {
            get { return dgvRegisteredParticipants; }
            set { dgvRegisteredParticipants = value; }
        }

        public void SetController(EventController eventController)
        {
            controller = eventController;
        }
        #endregion

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            controller.AddEvent();
        }
        private void btnRemoveEvent_Click(object sender, EventArgs e)
        {
            controller.RemoveEvent();
        }
        private void btnUpdateEvent_Click(object sender, EventArgs e)
        {
            controller.UpdateEvent();
        }

        private void btnAddObserver_Click(object sender, EventArgs e)
        {
            controller.AddObserver();
        }
        private void btnRemoveObserver_Click(object sender, EventArgs e)
        {
            controller.RemoveObserver();
        }
    }
}
