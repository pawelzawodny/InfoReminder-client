using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InfoReminder.Model.Entities;
using InfoReminder.Model.Rest;
using RestSharp;

namespace InfoReminder.Model.Repositories
{
    /// <summary>
    /// Repository used to manage groups
    /// </summary>
    public static class GroupRepository
    {
        /// <summary>
        /// Fetches all user groups (owned by him and groups where he has membership)
        /// </summary>
        /// <param name="api">Api object used to make request</param>
        /// <returns>List of user groups</returns>
        public static IList<Group> FetchUserGroups(InfoReminderWebApi api)
        {
            RestRequest request = new RestRequest("groups.json");
            return api.Execute<List<Group>>(request);
        }
    }
}
