using EventPlanner.Models;

namespace EventPlanner.Interfaces
{
    public interface IEventService
    {
        List<EventType> GetEventTypes();
    }
}