using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfoReminder.Model.Entities
{
    /// <summary>
    /// Represents event group
    /// </summary>
    public class Group
    {
        /// <summary>
        /// Gets or sets group name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets group description
        /// </summary>
        public string Description { get; set; }
    }
}
