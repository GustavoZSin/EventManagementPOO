using EventManagementPOO.Controller;

namespace EventManagementPOO
{
    public interface IEventRegisterView
    {
        DataGridView Events { get; set; }
        TextBox EventName { get; set; }
        TextBox EventDescription { get; set; }
        DateTimePicker EventDate { get; set; }
        DateTimePicker EventHour { get; set; }
        TextBox EventLocation { get; set; }
        ComboBox EventType { get; set; }

        TextBox ParticipantName { get; set; }
        TextBox ParticipantEmail { get; set; }
        DataGridView RegisteredParticipants { get; set; }

        void ShowMessage(string mensagem) { MessageBox.Show(mensagem); }
        void SetController(EventController eventController);
    }
}
