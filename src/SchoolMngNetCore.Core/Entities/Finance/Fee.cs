using SchoolMngNetCore.Core.Contracts;
using SchoolMngNetCore.Core.Entities.Administration;
using SchoolMngNetCore.Core.Entities.Admission;
using SchoolMngNetCore.Core.Entities.Schedule;
using System;

namespace SchoolMngNetCore.Core.Entities.Finance
{
    public class Fee : IAuditableEntity
    {
        public Fee()
        {
        }

        public Fee(string id) : base()
        {
            Id = id;
        }

        public string Id { get; set; }
        public double Amount { get; set; }
        public double Fine { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? PaymentDate { get; set; }
        public int SchoolId { get; set; }
        public int FeeTypeId { get; set; }
        public int StudentId { get; set; }
        public int? SessionId { get; set; }

        public string CreationUser { get; set; }
        public DateTime CreationDateTime { get; set; }
        public string LastUpdateUser { get; set; }
        public DateTime? LastUpdateDateTime { get; set; }
        public byte[] Timestamp { get; set; }

        public virtual School School { get; set; }
        public virtual FeeType FeeType { get; set; }
        public virtual Student Student { get; set; }
        public virtual Session Session { get; set; }
    }
}