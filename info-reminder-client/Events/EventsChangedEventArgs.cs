using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InfoReminder.Model.Entities;

namespace InfoReminder.Client.Events
{
    /// <summary>
    /// Represents arguments to EventsChanged event
    /// </summary>
    public class EventsChangedEventArgs : EventArgs
    {
        /// <summary>
        /// Gets or sets list of events which arrived
        /// </summary>
        public IList<Event> Events { get; set; }

        /// <summary>
        /// Only constructor
        /// </summary>
        public EventsChangedEventArgs(IList<Event> events)
        {
            Events = events;
        }
    }
}
