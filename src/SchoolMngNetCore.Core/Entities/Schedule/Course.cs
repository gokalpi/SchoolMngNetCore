using SchoolMngNetCore.Core.Contracts;
using SchoolMngNetCore.Core.Entities.Administration;
using SchoolMngNetCore.Core.Entities.Admission;
using System;
using System.Collections.Generic;

namespace SchoolMngNetCore.Core.Entities.Schedule
{
    public class Course : IAuditableEntity
    {
        public Course()
        {
            Students = new HashSet<Student>();
        }

        public Course(int? id) : base()
        {
            Id = id;
        }

        public int? Id { get; set; }
        public string Name { get; set; }
        public int SemesterId { get; set; }
        public int SubjectId { get; set; }
        public ECourseFrequency Frequency { get; set; }
        public ECourseType Type { get; set; }
        public ECourseFormat Format { get; set; }
        public bool IsActive { get; set; }

        public string CreationUser { get; set; }
        public DateTime CreationDateTime { get; set; }
        public string LastUpdateUser { get; set; }
        public DateTime? LastUpdateDateTime { get; set; }
        public byte[] Timestamp { get; set; }

        public virtual Semester Semester { get; set; }
        public virtual Subject Subject { get; set; }

        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<CourseSchedule> CourseSchedules { get; set; }
    }

    public enum ECourseFrequency
    {
        Daily = 1,
        Weekly,
        OneTime
    }

    public enum ECourseType
    {
        Elective = 0,
        Required
    }

    public enum ECourseFormat
    {
        Lecture = 1,
        Online,
        Seminar,
        Reading,
        Tutored,
        Laboratory
    }
}