using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private IEventRepository _service;

        /// <summary>
        /// Gets or setslist of upcoming events
        /// </summary>
        public ObservableCollection<Event> UpcomingEvents { get; set; }

        /// <summary>
        /// Gets or sets current event
        /// </summary>
        public Event Event { get; set; }

        /// <summary>
        /// Default constructor. Initializes web service.
        /// </summary>
        public UpcomingEventsViewModel()
        {
            _service = RepositoryProvider.GetEventRepository();
            UpcomingEvents = new ObservableCollection<Event>();
        }
    }
}
