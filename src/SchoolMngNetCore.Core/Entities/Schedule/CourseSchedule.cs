using SchoolMngNetCore.Core.Contracts;
using SchoolMngNetCore.Core.Entities.Administration;
using SchoolMngNetCore.Core.Entities.HumanResources;
using System;
using System.Collections.Generic;

namespace SchoolMngNetCore.Core.Entities.Schedule
{
    public class CourseSchedule : IAuditableEntity
    {
        public CourseSchedule()
        {
        }

        public CourseSchedule(string id) : base()
        {
            Id = id;
        }

        public string Id { get; set; }
        public int CourseId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int InstructorId { get; set; }
        public int LocationId { get; set; }
        public bool IsActive { get; set; }

        public string CreationUser { get; set; }
        public DateTime CreationDateTime { get; set; }
        public string LastUpdateUser { get; set; }
        public DateTime? LastUpdateDateTime { get; set; }
        public byte[] Timestamp { get; set; }

        public virtual Course Course { get; set; }
        public virtual Instructor Instructor { get; set; }
        public virtual Location Location { get; set; }

        public virtual ICollection<Attendance> Attendance { get; set; }
    }
}