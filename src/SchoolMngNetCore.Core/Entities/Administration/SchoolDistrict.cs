using SchoolMngNetCore.Core.Contracts;
using System;

namespace SchoolMngNetCore.Core.Entities.Administration
{
    public class SchoolDistrict : IAuditableEntity
    {
        public int SchoolId { get; set; }
        public int DistrictId { get; set; }

        public string CreationUser { get; set; }
        public DateTime CreationDateTime { get; set; }
        public string LastUpdateUser { get; set; }
        public DateTime? LastUpdateDateTime { get; set; }
        public byte[] Timestamp { get; set; }

        public virtual School School { get; set; }
        public virtual District District { get; set; }
    }
}