using SchoolMngNetCore.Core.Contracts;
using System;
using System.Collections.Generic;

namespace SchoolMngNetCore.Core.Entities.Administration
{
    public class District : IAuditableEntity
    {
        public District()
        {
            Schools = new HashSet<SchoolDistrict>();
        }

        public District(int? id) : base()
        {
            Id = id;
        }

        public int? Id { get; set; }
        public string Name { get; set; }
        public int CityId { get; set; }
        public bool IsActive { get; set; }

        public string CreationUser { get; set; }
        public DateTime CreationDateTime { get; set; }
        public string LastUpdateUser { get; set; }
        public DateTime? LastUpdateDateTime { get; set; }
        public byte[] Timestamp { get; set; }

        public virtual City City { get; set; }
        public virtual ICollection<SchoolDistrict> Schools { get; set; }
    }
}