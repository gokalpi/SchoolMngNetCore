using SchoolMngNetCore.Core.Contracts;
using SchoolMngNetCore.Core.Entities.Administration;
using System;

namespace SchoolMngNetCore.Core.Entities.Schedule
{
    public class Semester : IAuditableEntity
    {
        public Semester()
        {
        }

        public Semester(int? id) : base()
        {
            Id = id;
        }

        public int? Id { get; set; }
        public int SchoolId { get; set; }
        public string Name { get; set; }
        public ESemesterType Type { get; set; }

        public string CreationUser { get; set; }
        public DateTime CreationDateTime { get; set; }
        public string LastUpdateUser { get; set; }
        public DateTime? LastUpdateDateTime { get; set; }
        public byte[] Timestamp { get; set; }

        public virtual School School { get; set; }
    }

    public enum ESemesterType : byte
    {
        Past = 0,
        Current,
        Future,
        Cancelled
    }
}