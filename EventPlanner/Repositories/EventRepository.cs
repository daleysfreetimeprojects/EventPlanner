using EventPlanner.Interfaces;
using EventPlanner.Models;

namespace EventPlanner.Repositories
{
    public class EventRepository : IEventRepository
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
