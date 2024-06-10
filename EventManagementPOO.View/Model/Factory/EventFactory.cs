namespace EventManagementPOO.Model.Factory
{
    public abstract class EventFactory
    {
        public abstract Event CreateEvent(string name, string description, DateTime date, DateTime hour, string localization);
    }
}
