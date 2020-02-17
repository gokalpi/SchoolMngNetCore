using SchoolMngNetCore.Core.Entities.Schedule;
using System;
using System.Collections.Generic;

namespace SchoolMngNetCore.Core.Entities.Admission
{
    public class Student : Person
    {
        public Student() : base()
        {
            Parents = new HashSet<StudentParent>();
            Attendances = new HashSet<Attendance>();
        }

        public string SchoolNumber { get; set; }
        public DateTime AdmissionDate { get; set; }
        public EStudentStatus Status { get; set; }

        public virtual ICollection<StudentParent> Parents { get; set; }
        public virtual ICollection<Attendance> Attendances { get; set; }
    }

    public enum EStudentStatus : byte
    {
        Passive = 0,
        Active,
        Expelled,
        Transferred
    }
}