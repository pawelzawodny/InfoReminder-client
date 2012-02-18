using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfoReminder.Model.Entities
{
    /// <summary>
    /// Represents data used to authenticate in web service
    /// </summary>
    public class ClientCredentials
    {
        /// <summary>
        /// Gets or sets user object
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// Gets or set authentication token
        /// </summary>
        public string AuthToken { get; set; }

        /// <summary>
        /// Gets or sets session id
        /// </summary>
        public string SessionId { get; set; }
    }
}
