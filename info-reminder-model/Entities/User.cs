using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfoReminder.Model.Entities
{
    /// <summary>
    /// Represents info-reminder web service user
    /// </summary>
    public class User
    {
        /// <summary>
        /// Default constructor, sets user id to 0 and Username to string.Empty
        /// </summary>
        public User()
        {
            Username = string.Empty;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="userId">User id</param>
        /// <param name="username">Username</param>
        public User(int userId, string username)
        {
            UserId = userId;
            Username = username;
        }

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
