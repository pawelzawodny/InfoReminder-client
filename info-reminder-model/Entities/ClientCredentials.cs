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
        /// Default constructor
        /// </summary>
        public ClientCredentials()
        {
            User = new User();
        }

        /// <summary>
        /// Full constructor
        /// </summary>
        /// <param name="user">User used to authenticate</param>
        /// <param name="authToken">Secret authentication token</param>
        public ClientCredentials(User user, string authToken)
        {
            User = user;
            AuthToken = authToken;
        }
        
        /// <summary>
        /// Alternative constructor
        /// </summary>
        /// <param name="userId">Id of user used to authenticate</param>
        /// <param name="userName">Username of user used to authenticate</param>
        /// <param name="authToken">Secret authentication token</param>
        public ClientCredentials(int userId, string userName, string authToken) : this(new User(userId, userName), authToken)
        {
           
        }

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
