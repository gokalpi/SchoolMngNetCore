using SchoolMngNetCore.Core.Contracts;
using System;
using System.Collections.Generic;

namespace SchoolMngNetCore.Core.Entities.Administration
{
    public class Country : IAuditableEntity
    {
        public Country()
        {
            Addresses = new HashSet<Address>();
            Cities = new HashSet<City>();
            States = new HashSet<State>();
        }

        public Country(int? id) : base()
        {
            Id = id;
        }

        public int? Id { get; set; }
        public string CountryName { get; set; }
        public string FormalName { get; set; }
        public string IsoAlpha3Code { get; set; }
        public bool IsActive { get; set; }

        public string CreationUser { get; set; }
        public DateTime CreationDateTime { get; set; }
        public string LastUpdateUser { get; set; }
        public DateTime? LastUpdateDateTime { get; set; }
        public byte[] Timestamp { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<City> Cities { get; set; }
        public virtual ICollection<State> States { get; set; }
    }
}