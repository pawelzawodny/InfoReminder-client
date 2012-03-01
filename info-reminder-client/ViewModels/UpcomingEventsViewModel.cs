using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InfoReminder.Model.Repositories;
using InfoReminder.Model.Entities;
using InfoReminder.Client.Util;

namespace InfoReminder.Client.ViewModels
{
    /// <summary>
    /// ViewModel used to provide upcoming events
    /// </summary>
    class UpcomingEventsViewModel
    {
        private EventRepository _service;

        /// <summary>
        /// Gets or setslist of upcoming events
        /// </summary>
        public IEnumerable<Event> UpcomingEvents { get; set; }

        /// <summary>
        /// Gets or sets current event
        /// </summary>
        public Event Event { get; set; }

        /// <summary>
        /// Default constructor. Initializes web service.
        /// </summary>
        public UpcomingEventsViewModel()
        {
            _service = new EventRepository(Configuration.Instance.Api);
            Event = new Event(2, "Test", "descr", DateTime.Now, null);
            List<Event> events = new List<Event>();
            events.Add(Event);
            UpcomingEvents = events;
        }
    }
}
