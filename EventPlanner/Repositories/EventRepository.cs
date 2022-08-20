using EventPlanner.Interfaces;
using EventPlanner.Models;

namespace EventPlanner.Repositories
{
    public class EventRepository : IEventRepository
    {
        private readonly EventPlannerContext _eventPlannerContext;
        public EventRepository(EventPlannerContext eventPlannerContext)
        {
            _eventPlannerContext = eventPlannerContext;
        }
        public List<EventType> GetEventTypes()
        {
            var eventTypes = _eventPlannerContext.EventTypes.ToList();
            return eventTypes;
        }
    }
}
