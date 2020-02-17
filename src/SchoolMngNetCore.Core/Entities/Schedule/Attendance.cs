using SchoolMngNetCore.Core.Contracts;
using SchoolMngNetCore.Core.Entities.Admission;
using System;

namespace SchoolMngNetCore.Core.Entities.Schedule
{
    public class Attendance : IAuditableEntity
    {
        public Attendance()
        {
        }

        public Attendance(string id) : base()
        {
            Id = id;
        }

        public string Id { get; set; }
        public int StudentId { get; set; }
        public int CourseScheduleId { get; set; }
        public EAttendanceStatus Status { get; set; }

        public string CreationUser { get; set; }
        public DateTime CreationDateTime { get; set; }
        public string LastUpdateUser { get; set; }
        public DateTime? LastUpdateDateTime { get; set; }
        public byte[] Timestamp { get; set; }

        public virtual Student Student { get; set; }
        public virtual CourseSchedule CourseSchedule { get; set; }
    }

    public enum EAttendanceStatus
    {
        Absent = 0,
        Present,
        Late,
        Excused
    }
}