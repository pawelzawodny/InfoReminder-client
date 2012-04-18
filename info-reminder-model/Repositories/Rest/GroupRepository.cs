using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InfoReminder.Model.Entities;
using InfoReminder.Model.Rest;
using RestSharp;

namespace InfoReminder.Model.Repositories.Rest
{
    /// <summary>
    /// Repository used to manage groups
    /// </summary>
    public class GroupRepository : IGroupRepository
    {
        private InfoReminderWebApi _api;

        /// <summary>
        /// Repository constructor
        /// </summary>
        /// <param name="api">Api used to communicate with service</param>
        public GroupRepository(InfoReminderWebApi api)
        {
            _api = api;
        }

        /// <summary>
        /// Fetches all user groups (owned by him and groups where he has membership)
        /// </summary>
        /// <param name="api">Api object used to make request</param>
        /// <returns>List of user groups</returns>
        public IList<Group> FetchUserGroups()
        {
            RestRequest request = new RestRequest("groups.json");
            return _api.Execute<List<Group>>(request);
        }
    }
}
