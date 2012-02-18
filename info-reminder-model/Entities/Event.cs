using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfoReminder.Model.Entities
{
    /// <summary>
    /// Represents event 
    /// </summary>
    public class Event
    {
        /// <summary>
        /// Gets or sets date when event starts
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets short name of event
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets full description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets group this event belongs to
        /// </summary>
        public Group Group { get; set; }
    }
}
