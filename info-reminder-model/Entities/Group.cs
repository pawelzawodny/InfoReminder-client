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
        /// Default constructor
        /// </summary>
        public Group()
        {
            Name = string.Empty;
            Description = string.Empty;
        }

        /// <summary>
        /// Full constructor
        /// </summary>
        /// <param name="id">Group id</param>
        /// <param name="Name">Group name</param>
        /// <param name="Description">Description</param>
        public Group(long id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        /// <summary>
        /// Gets or sets group id
        /// </summary>
        public long Id { get; set; }

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
