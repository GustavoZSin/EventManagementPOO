namespace EventManagementPOO.Model.Factory
{
    public class ConferenceFactory : EventFactory
    {
        public override Event CreateEvent(string name, string description, DateTime date, DateTime hour, string localization)
        {
            return new Conference(name, description, date, hour, localization);
        }
    }
}
