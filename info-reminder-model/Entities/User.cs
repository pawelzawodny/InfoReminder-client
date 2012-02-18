using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfoReminder.Model.Entities
{
    /// <summary>
    /// Represents info-reminder web service user
    /// </summary>
    class User
    {
        /// <summary>
        /// Gets or sets user id
        /// </summary>
        public long UserId { get; set; }

        /// <summary>
        /// Gets or sets username
        /// </summary>
        public string Username { get; set; }
    }
}
