using SchoolMngNetCore.Core.Contracts;
using System;
using System.Collections.Generic;

namespace SchoolMngNetCore.Core.Entities.Administration
{
    public class State : IAuditableEntity
    {
        public State()
        {
            Addresses = new HashSet<Address>();
            Cities = new HashSet<City>();
        }

        public State(int? id) : base()
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
        public virtual ICollection<City> Cities { get; set; }
    }
}