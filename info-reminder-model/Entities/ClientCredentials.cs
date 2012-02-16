using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfoReminder.Model.Entities
{
    class ClientCredentials
    {
        public User User { get; set; }
        public string AuthToken { get; set; }
        public string SessionId { get; set; }
    }
}
