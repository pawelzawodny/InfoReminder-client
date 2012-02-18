using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InfoReminder.Model.Entities;

namespace InfoReminder.Model.Repositories
{
    /// <summary>
    /// Class used to manage events
    /// </summary>
    class EventRepository
    {
        /// <summary>
        /// Fetches upcoming events for specified user using passed credentials
        /// </summary>
        /// <param name="credentials">Credentials used to authenticate and authorise action</param>
        /// <param name="markAsReaded">Indicates whether fetched events should be marked as readed on server side</param>
        /// <returns>List of upcoming events</returns>
        public IList<Event> FetchUpcomingEvents(ClientCredentials credentials, bool markAsReaded)
        {
            return new List<Event>();
        }

        /// <summary>
        /// Marks event as readed on server side
        /// </summary>
        /// <param name="readedEvent">Event object</param>
        public void MarkAsReaded(Event readedEvent)
        {

        }
    }
}
