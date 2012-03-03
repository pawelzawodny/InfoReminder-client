using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfoReminder.Client.Configuration
{
    /// <summary>
    /// InfoReminder configuration section implementation
    /// </summary>
    public class InfoReminderSection : ConfigurationSection
    {
        /// <summary>
        /// Gets or sets client credentials section
        /// </summary>
        [ConfigurationProperty("clientCredentials", IsRequired=true)]
        public ClientCredentialsElement ClientCredentials 
        {
            get
            {
                return this["clientCredentials"] as ClientCredentialsElement;
            }

            set
            {
                this["clientCredentials"] = value;
            }
        }
    }
}
