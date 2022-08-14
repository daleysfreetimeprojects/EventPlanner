using System;
using System.Collections.Generic;

namespace EventPlanner.Models
{
    public partial class EventType
    {
        public int EventTypeId { get; set; }
        public string? EventTypeDescription { get; set; }
    }
}
