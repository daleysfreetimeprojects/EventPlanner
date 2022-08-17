using EventPlanner.Models;
using EventPlanner.Services;
using Microsoft.AspNetCore.Mvc;

namespace EventPlanner.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventController : ControllerBase
    {
        [HttpGet(Name = "GetEventTypes")]
        public List<EventType> GetEventTypes()
        {
            return new EventService().GetEventTypes();
        }

    }
}
