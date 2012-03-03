using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InfoReminder.Model.Rest.Authentication;

namespace InfoReminder.Client.Configuration
{
    /// <summary>
    /// Represents client credentials element in config
    /// </summary>
    public class ClientCredentialsElement : ConfigurationElement
    {
        /// <summary>
        /// Gets or sets User Id
        /// </summary>
        [ConfigurationProperty("userId", IsRequired = true)]
        [IntegerValidator()]
        public int UserId 
        {
            get
            {
                return Convert.ToInt32(this["userId"]);
            }

            set
            {
                this["userId"] = value.ToString();
            }
        }

        /// <summary>
        /// Gets or sets username
        /// </summary>
        [ConfigurationProperty("username", IsRequired = true)]
        public string UserName
        {
            get
            {
                return this["username"] as string;
            }

            set
            {
                this["username"] = value;
            }
        }

        /// <summary>
        /// Gets or sets authentication token
        /// </summary>
        [ConfigurationProperty("authToken", IsRequired=true)]
        public string AuthToken
        {
            get
            {
                return this["authToken"] as string;
            }

            set
            {
                this["authToken"] = value;
            }
        }

        /// <summary>
        /// Gets client credentials object used to authenticate
        /// </summary>
        public ClientCredentials ClientCredentials 
        {
            get
            {
                return new ClientCredentials(UserId, UserName, AuthToken);
            }
        }
    }
}
