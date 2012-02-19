using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InfoReminder.Model.Entities;
using InfoReminder.Model.Rest;
using RestSharp;

namespace InfoReminder.Model.Repositories
{
    /// <summary>
    /// Singleton class used to manage events
    /// </summary>
    public class EventRepository
    {
        private static EventRepository _instance;

        /// <summary>
        /// Returns repository instance
        /// </summary>
        public static EventRepository Instance {
            get
            {
                if (_instance == null)
                {
                    _instance = new EventRepository();
                }
                
                return _instance;
            }
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        private EventRepository()
        {

        }

        /// <summary>
        /// Fetches upcoming events for specified user using passed credentials
        /// </summary>
        /// <param name="api">Api instance used to make requests</param>
        /// <param name="markAsReaded">Indicates whether fetched events should be marked as readed on server side</param>
        /// <returns>List of upcoming events</returns>
        public IList<Event> FetchUpcomingEvents(InfoReminderWebApi api, bool markAsReaded)
        {
            RestRequest request = new RestRequest("upcoming_events.json");
            return api.Execute<List<Event>>(request);
        }

        /// <summary>
        /// Marks event as readed on server side
        /// </summary>
        /// <param name="api">Api instance used to make requests</param>
        /// <param name="readedEvent">Event object</param>
        public void MarkAsReaded(InfoReminderWebApi api, Event readedEvent)
        {

        }
    }
}
