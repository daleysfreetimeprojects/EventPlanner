using EventPlanner.Models;

namespace EventPlanner.Repositories
{
    public class EventRepository
    {

        public List<EventType> GetEventTypes()
        {
            var eventTypes = new List<EventType>();
            using (var ctx = new EventPlannerContext())
            {
                eventTypes = ctx.EventTypes.ToList();
            }
            return eventTypes;
        }
    }
}
