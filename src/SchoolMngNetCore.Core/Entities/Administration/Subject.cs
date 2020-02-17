using SchoolMngNetCore.Core.Contracts;
using System;

namespace SchoolMngNetCore.Core.Entities.Administration
{
    public class Subject : IAuditableEntity
    {
        public Subject()
        {
        }

        public Subject(int? id) : base()
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
    }
}