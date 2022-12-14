using EventPlanner.Interfaces;
using EventPlanner.Models;

namespace EventPlanner.Services
{
    public class EventService : IEventService
    {
        private readonly IEventRepository _eventRepository;
        public EventService(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }
        public List<EventType> GetEventTypes()
        {
            return _eventRepository.GetEventTypes();
        }
    }
}
