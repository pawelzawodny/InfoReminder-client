using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using InfoReminder.Client.Util;
using InfoReminder.Model.Entities;
using InfoReminder.Client.Events;
using InfoReminder.Client.ViewModels;

namespace InfoReminder.Client
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private EventMonitor _eventMonitor;
        private UpcomingEventsWindow _window;

        protected override void OnStartup(StartupEventArgs e)
        {
            _window = new UpcomingEventsWindow();

            _eventMonitor = new EventMonitor(Configuration.Instance.Api);
            _eventMonitor.Interval = Configuration.Instance.MonitorInterval;
            _eventMonitor.EventsChanged += new EventHandler<EventsChangedEventArgs>(EventsArrived);
            _eventMonitor.Start();
        } 

        protected void EventsArrived(object source, EventsChangedEventArgs args)
        {
            UpcomingEventsViewModel viewModel = _window.Resources["ViewModel"] as UpcomingEventsViewModel;
            viewModel.UpcomingEvents = args.Events;
            Dispatcher.Invoke(
                new Action(() => {
                    _window.Show();
                })
            );
        }
    }
}
