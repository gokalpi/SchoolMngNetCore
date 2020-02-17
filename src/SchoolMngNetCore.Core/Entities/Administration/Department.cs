using SchoolMngNetCore.Core.Contracts;
using SchoolMngNetCore.Core.Entities.HumanResources;
using System;
using System.Collections.Generic;

namespace SchoolMngNetCore.Core.Entities.Administration
{
    public class Department : IAuditableEntity
    {
        public Department()
        {
            Instructors = new HashSet<Instructor>();
        }

        public Department(int? id)
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

        public virtual ICollection<Instructor> Instructors { get; set; }
    }
}