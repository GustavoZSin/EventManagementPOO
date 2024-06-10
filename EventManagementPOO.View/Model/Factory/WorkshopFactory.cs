namespace EventManagementPOO.Model.Factory
{
    public class WorkshopFactory : EventFactory
    {
        public override Event CreateEvent(string name, string description, DateTime date, DateTime hour, string localization)
        {
            return new Workshop(name, description, date, hour, localization);
        }
    }
}
