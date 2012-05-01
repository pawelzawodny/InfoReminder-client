using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InfoReminder.Model.Entities;

namespace InfoReminder.Model.Repositories.Test
{
    public class TestEventRepository : IEventRepository
    {
        private IList<Event> _events;

        public TestEventRepository()
        {
            _events = new List<Event>();
            PopulateEventList();
        }

        private void PopulateEventList()
        {
            for (int i = 0; i < 100; i++)
            {
                _events.Add(GenerateRandomEvent(i));
            }
        }

        private Event GenerateRandomEvent(int i)
        {
            Event e = new Event(
                i,
                string.Format("Event #{0:d}", i),
                "Description",
                GenerateRandomDate(),
                GenerateRandomGroup(i)
                );

            return e;
        }

        private Group GenerateRandomGroup(int i)
        {
            return new Group(i, string.Format("Group #{0:d}", i), "Description");
        }

        private DateTime GenerateRandomDate()
        {
            return new DateTime(DateTime.Now.Year, DateTime.Now.Month, new Random(DateTime.Now.Millisecond).Next(31));
        }

        public IList<Entities.Event> FetchUpcomingEvents(bool markAsReaded)
        {
            return _events;
        }

        public void AcceptNotification(Event e)
        {
        }

        public void AcceptNotifications(IList<Event> events)
        {
        }
    }
}
