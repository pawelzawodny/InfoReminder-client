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
        private InfoReminderWebApi _api;
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
            _api = new InfoReminderWebApi();
        }

        /// <summary>
        /// Fetches upcoming events for specified user using passed credentials
        /// </summary>
        /// <param name="credentials">Credentials used to authenticate and authorise action</param>
        /// <param name="markAsReaded">Indicates whether fetched events should be marked as readed on server side</param>
        /// <returns>List of upcoming events</returns>
        public IList<Event> FetchUpcomingEvents(ClientCredentials credentials, bool markAsReaded)
        {
            RestRequest request = new RestRequest("upcoming_events.json");
            _api.ClientCredentials = credentials;
            return _api.Execute<List<Event>>(request);
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
