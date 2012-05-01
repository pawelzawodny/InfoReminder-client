using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using InfoReminder.Model.Repositories;
using InfoReminder.Model.Repositories.Rest;
using InfoReminder.Model.Repositories.Test;
using InfoReminder.Model.Rest;
using InfoReminder.Model.Entities;
using InfoReminder.Client.Events;

namespace InfoReminder.Client.Util
{
    /// <summary>
    /// Class used to periodically check web service for new events
    /// </summary>
    class EventMonitor
    {
        private Timer _timer;
        private IEventRepository _repository;

        /// <summary>
        /// Triggered when new events shows up on web service
        /// </summary>
        public event EventHandler<EventsChangedEventArgs> EventsChanged;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="api">Api object used to communicate with web service</param>
        public EventMonitor(InfoReminderWebApi api)
        {
            _repository = RepositoryProvider.GetEventRepository();
            _timer = new Timer();
            _timer.Elapsed += new ElapsedEventHandler(TimerElapsed);
        }

        /// <summary>
        /// Sets checking interval
        /// </summary>
        public TimeSpan Interval 
        {
            set
            {
                _timer.Interval = value.TotalMilliseconds;
            }
        }

        /// <summary>
        /// Stops timer
        /// </summary>
        public void Stop()
        {
            _timer.Stop();
        }
        
        /// <summary>
        /// Starts timer
        /// </summary>
        public void Start()
        {
            _timer.Start();
        }

        /// <summary>
        /// Sends request to web service
        /// </summary>
        /// <param name="source">Source of event</param>
        /// <param name="args">Event arguments</param>
        protected void TimerElapsed(Object source, ElapsedEventArgs args)
        {
            IList<Event> events = _repository.FetchUpcomingEvents(true);
            if (events.Count > 0)
            {
                EventsChanged(this, new EventsChangedEventArgs(events));
                
                _repository.AcceptNotifications(events);
            }
        }
    }
}
