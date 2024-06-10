using EventManagementPOO.Model.Model;

namespace EventManagementPOO.Model.Factory
{
    public abstract class EventFactory
    {
        public abstract Event CreateEvent(string name, string description, DateTime date, string localization);
        /*            Event eventCreated = null;

                    if (EventType.Workshop.Equals(eventType))
                        eventCreated = new WorkshopFactory(name, description, date, localization);

                    if (EventType.Conference.Equals(eventType))
                        eventCreated = new ConferenceFactory(name, description, date, localization);

                    return eventCreated;*/
    }
}
