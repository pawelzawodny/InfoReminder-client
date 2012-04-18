using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InfoReminder.Model.Rest;
using InfoReminder.Model.Rest.Authentication;
using InfoReminder.Client.Configuration;

namespace InfoReminder.Client.Util
{
    /// <summary>
    /// Singleton class used to maintain application config
    /// </summary>
    public class Configuration
    {
        private static Configuration _instance;
        private InfoReminderSection _configSection;
        
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
            _configSection = ConfigurationManager.GetSection("infoReminder") as InfoReminderSection;
            Api = new InfoReminderWebApi(InfoReminderWebApi.DefaultBaseUrl, _configSection.ClientCredentials.ClientCredentials);
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

        /// <summary>
        /// Returns true if debug mode is enabled
        /// </summary>
        public bool DebugEnabled 
        {
            get
            {
                return true;
            }
        }
    }
}
