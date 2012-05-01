using System;
using System.Collections.Generic;
using InfoReminder.Model.Entities;
namespace InfoReminder.Model.Repositories
{
    public interface IEventRepository
    {
        IList<Event> FetchUpcomingEvents(bool markAsReaded);
        void AcceptNotification(Event ev);
        void AcceptNotifications(IList<Event> events);
    }
}
