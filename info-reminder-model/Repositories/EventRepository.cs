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
    /// Repository used to manage events
    /// </summary>
    public class EventRepository
    {
        private InfoReminderWebApi _api;

        /// <summary>
        /// Repository constructor
        /// </summary>
        /// <param name="api">Api object used to communicate with service</param>
        public EventRepository(InfoReminderWebApi api)
        {
            _api = api;
        }
        /// <summary>
        /// Fetches upcoming events for specified user using passed credentials
        /// </summary>
        /// <param name="api">Api instance used to make requests</param>
        /// <param name="markAsReaded">Indicates whether fetched events should be marked as readed on server side</param>
        /// <returns>List of upcoming events</returns>
        public IList<Event> FetchUpcomingEvents(bool markAsReaded)
        {
            RestRequest request = new RestRequest("upcoming_events.json");
            return _api.Execute<List<Event>>(request);
        }

        /// <summary>
        /// Marks event as readed on server side
        /// </summary>
        /// <param name="api">Api instance used to make requests</param>
        /// <param name="readedEvent">Event object</param>
        public void MarkAsReaded(Event readedEvent)
        {

        }
    }
}
