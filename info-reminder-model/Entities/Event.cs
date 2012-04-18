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
        /// Default constructor
        /// </summary>
        public Event()
        {
            Date = DateTime.Now;
            Title = string.Empty;
            Description = string.Empty;
            Group = new Group();
        }

        /// <summary>
        /// Full constructor
        /// </summary>
        /// <param name="title">Event name</param>
        /// <param name="description">Full description</param>
        /// <param name="date">Date of event</param>
        /// <param name="group">Group this event belongs to</param>
        public Event(long id, string title, string description, DateTime date, Group group)
        {
            Id = id;
            Title = title;
            Description = description;
            Date = date;
            Group = group;
        }

        /// <summary>
        /// Gets or sets event id
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets date when event starts
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets short name of event
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets full description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets group this event belongs to
        /// </summary>
        public Group Group { get; set; }

        public override bool Equals(object obj)
        {
            Event other = (Event)obj;
            return Equals(other);
        }

        public bool Equals(Event other)
        {
            return
                this.Id == other.Id &&
                this.Title.Equals(other.Title) &&
                this.Date.Equals(other.Date) &&
                this.Description.Equals(other.Description) &&
                this.Group.Equals(other.Group);
        }

        public override int GetHashCode()
        {
            return ((int)(this.Id + this.Group.Id) + this.Description.Length);
        }
    }
}
