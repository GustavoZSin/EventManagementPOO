using EventManagementPOO.Model.Model;

namespace EventManagementPOO.Model.Factory
{
    public class WorkshopFactory : EventFactory
    {
        public override Event CreateEvent(string name, string description, DateTime date, string localization)
        {
            return new Workshop(name, description, date, localization);
        }
    }
}
