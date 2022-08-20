using EventPlanner.Interfaces;
using EventPlanner.Models;
using Microsoft.AspNetCore.Mvc;

namespace EventPlanner.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventController : ControllerBase
    {
        private readonly IEventService _eventService;

        public EventController(IEventService eventService)
        {
            _eventService = eventService;
        }

        [HttpGet(Name = "GetEventTypes")]
        public List<EventType> GetEventTypes()
        {
            return _eventService.GetEventTypes();
        }

    }
}
