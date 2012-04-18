using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InfoReminder.Model.Entities;

namespace InfoReminder.Model.Repositories.Test
{
    public class TestGroupRepository : IGroupRepository
    {
        private List<Group> _groups;

        public TestGroupRepository()
        {
            _groups = new List<Group>();
            PopulateGroupList();
        }

        private void PopulateGroupList()
        {
            for (int i = 0; i < 10; i++)
            {
                _groups.Add(new Group(i, string.Format("Group #{0:d}", i), "Description"));
            }
        }

        public IList<Entities.Group> FetchUserGroups()
        {
            return _groups;
        }
    }
}
