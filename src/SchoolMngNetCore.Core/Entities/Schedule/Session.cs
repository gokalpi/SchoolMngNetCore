using SchoolMngNetCore.Core.Contracts;
using SchoolMngNetCore.Core.Entities.Administration;
using System;
using System.Collections.Generic;

namespace SchoolMngNetCore.Core.Entities.Schedule
{
    public class Session : IAuditableEntity
    {
        public Session()
        {
            Classes = new HashSet<Class>();
        }

        public Session(int? id) : base()
        {
            Id = id;
        }

        public int? Id { get; set; }
        public string SessionName { get; set; }
        public bool IsActive { get; set; }

        public string CreationUser { get; set; }
        public DateTime CreationDateTime { get; set; }
        public string LastUpdateUser { get; set; }
        public DateTime? LastUpdateDateTime { get; set; }
        public byte[] Timestamp { get; set; }

        public virtual ICollection<Class> Classes { get; set; }
    }
}