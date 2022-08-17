using EventPlanner.Models;
using EventPlanner.Repositories;

namespace EventPlanner.Services
{
    public class EventService
    {
        public List<EventType> GetEventTypes()
        {
            return new EventRepository().GetEventTypes();
        }
    }
}
