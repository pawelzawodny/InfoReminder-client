using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InfoReminder.Model.Rest;
using InfoReminder.Model.Rest.Authentication;

namespace InfoReminder.Client.Util
{
    /// <summary>
    /// Singleton class used to maintain application config
    /// </summary>
    public class Configuration
    {
        private static Configuration _instance;
        
        /// <summary>
        /// Returns the only instance of this class
        /// </summary>
        public static Configuration Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Configuration();
                }

                return _instance;
            }
        }

        /// <summary>
        /// Default constructor. Loads configuration
        /// </summary>
        public Configuration()
        {
            // TODO: Load credentials from .config file
            ClientCredentials cred = new ClientCredentials(1, "szygi", "42a3d139546587fce152c892292ce46c5d0aa330");
            Api = new InfoReminderWebApi(InfoReminderWebApi.DefaultBaseUrl, cred);
        }

        /// <summary>
        /// Returns default object used to communicate with service
        /// </summary>
        public InfoReminderWebApi Api { get; set; }

        /// <summary>
        /// Gets monitor interval
        /// </summary>
        public TimeSpan MonitorInterval 
        {
            get
            {
                return new TimeSpan(0, 1, 0);
            }
        }
    }
}
