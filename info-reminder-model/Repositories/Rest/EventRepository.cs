using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InfoReminder.Model.Entities;
using InfoReminder.Model.Rest;
using RestSharp;

namespace InfoReminder.Model.Repositories.Rest
{
    /// <summary>
    /// Repository used to manage events
    /// </summary>
    public class EventRepository : IEventRepository
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
            IList<Event> events = _api.Execute<List<Event>>(request);
            if (events == null)
            {
                events = new List<Event>();
            }

            return events;
        }

        /// <summary>
        /// Accepts notification
        /// </summary>
        /// <param name="acceptedEvent">Event object</param>
        public void AcceptNotification(Event acceptedEvent)
        {

        }

        public void AcceptNotifications(IList<Event> acceptedEvents)
        {
            RestRequest request = new RestRequest("accept_notifications.json");
            AddEventIdsToRequest(request, acceptedEvents);
            _api.Execute<Object>(request);
        }

        private void AddEventIdsToRequest(RestRequest request, IList<Event> acceptedEvents)
        {
            foreach(Event eventObj in acceptedEvents) 
            {
                request.AddParameter("event_ids[]", eventObj.Id);
            }
        }
    }
}
