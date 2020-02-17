using SchoolMngNetCore.Core.Contracts;
using SchoolMngNetCore.Core.Entities.Administration;
using System;

namespace SchoolMngNetCore.Core.Entities.Admission
{
    public class StudentAdmission : IAuditableEntity
    {
        public int SchoolId { get; set; }
        public int StudentId { get; set; }

        public string CreationUser { get; set; }
        public DateTime CreationDateTime { get; set; }
        public string LastUpdateUser { get; set; }
        public DateTime? LastUpdateDateTime { get; set; }
        public byte[] Timestamp { get; set; }

        public virtual School School { get; set; }
        public virtual Student Student { get; set; }
    }
}