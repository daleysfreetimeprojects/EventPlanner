using EventPlanner.Models;

namespace EventPlanner.Interfaces
{
    public interface IEventRepository
    {
        List<EventType> GetEventTypes();
    }
}