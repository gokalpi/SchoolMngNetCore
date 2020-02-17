using SchoolMngNetCore.Core.Contracts;
using System;

namespace SchoolMngNetCore.Core.Entities.Admission
{
    public class StudentParent : IAuditableEntity
    {
        public int StudentId { get; set; }
        public int ParentId { get; set; }

        public string CreationUser { get; set; }
        public DateTime CreationDateTime { get; set; }
        public string LastUpdateUser { get; set; }
        public DateTime? LastUpdateDateTime { get; set; }
        public byte[] Timestamp { get; set; }

        public virtual Student Student { get; set; }
        public virtual Parent Parent { get; set; }
    }
}