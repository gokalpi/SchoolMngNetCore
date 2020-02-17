using SchoolMngNetCore.Core.Contracts;
using SchoolMngNetCore.Core.Entities.Schedule;
using System;
using System.Collections.Generic;

namespace SchoolMngNetCore.Core.Entities.Administration
{
    public class Location : IAuditableEntity
    {
        public Location()
        {
            CourseSchedules = new HashSet<CourseSchedule>();
        }

        public Location(int? id) : base()
        {
            Id = id;
        }

        public int? Id { get; set; }
        public string Name { get; set; }
        public int SchoolId { get; set; }
        public bool IsActive { get; set; }

        public string CreationUser { get; set; }
        public DateTime CreationDateTime { get; set; }
        public string LastUpdateUser { get; set; }
        public DateTime? LastUpdateDateTime { get; set; }
        public byte[] Timestamp { get; set; }

        public virtual School School { get; set; }

        public virtual ICollection<CourseSchedule> CourseSchedules { get; set; }
    }
}