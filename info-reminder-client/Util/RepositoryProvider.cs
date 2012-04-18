using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InfoReminder.Model.Repositories;
using InfoReminder.Model.Repositories.Test;
using InfoReminder.Model.Repositories.Rest;

namespace InfoReminder.Client.Util
{
    /// <summary>
    /// Provides implementation for event repository
    /// </summary>
    class RepositoryProvider
    {
        /// <summary>
        /// Returns event repository implementation
        /// </summary>
        /// <returns>event repository implementation</returns>
        public static IEventRepository GetEventRepository()
        {
            if (Configuration.Instance.DebugEnabled)
            {
                return CreateTestEventRepository();
            }
            else
            {
                return CreateRestEventRepository();
            }
        }

        /// <summary>
        /// Returns group repository implementation
        /// </summary>
        /// <returns>group repository implementation</returns>
        public static IGroupRepository GetGroupRepository()
        {
            if (Configuration.Instance.DebugEnabled)
            {
                return CreateTestGroupRepository();
            }
            else
            {
                return CreateRestGroupRepository();
            }
        }

        private static IEventRepository CreateRestEventRepository()
        {
            return new EventRepository(Configuration.Instance.Api);
        }

        private static IEventRepository CreateTestEventRepository()
        {
            return new TestEventRepository();
        }

        private static IGroupRepository CreateTestGroupRepository()
        {
            return new TestGroupRepository();
        }

        private static IGroupRepository CreateRestGroupRepository()
        {
            return new GroupRepository(Configuration.Instance.Api);
        }
    }
}
