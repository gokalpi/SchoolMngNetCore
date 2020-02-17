using SchoolMngNetCore.Core.Contracts;
using System;
using System.Collections.Generic;

namespace SchoolMngNetCore.Core.Entities.Administration
{
    public class City : IAuditableEntity
    {
        public City()
        {
            Addresses = new HashSet<Address>();
            Districts = new HashSet<District>();
            Schools = new HashSet<School>();
        }

        public City(int? id) : base()
        {
            Id = id;
        }

        public int? Id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
        public bool IsActive { get; set; }

        public string CreationUser { get; set; }
        public DateTime CreationDateTime { get; set; }
        public string LastUpdateUser { get; set; }
        public DateTime? LastUpdateDateTime { get; set; }
        public byte[] Timestamp { get; set; }

        public virtual Country Country { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<District> Districts { get; set; }
        public virtual ICollection<School> Schools { get; set; }
    }
}