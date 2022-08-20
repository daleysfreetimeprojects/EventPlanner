using EventPlanner.Interfaces;
using EventPlanner.Models;
using EventPlanner.Repositories;
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
            return new EventService(new EventRepository()).GetEventTypes();
        }

    }
}
