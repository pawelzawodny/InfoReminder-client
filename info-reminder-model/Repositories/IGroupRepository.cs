using System;
using System.Collections.Generic;
using InfoReminder.Model.Entities;

namespace InfoReminder.Model.Repositories
{
    public interface IGroupRepository
    {
        IList<Group> FetchUserGroups();
    }
}
