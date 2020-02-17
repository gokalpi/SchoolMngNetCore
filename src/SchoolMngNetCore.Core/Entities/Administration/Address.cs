using SchoolMngNetCore.Core.Contracts;
using System;

namespace SchoolMngNetCore.Core.Entities.Administration
{
    public class Address : IAuditableEntity
    {
        public Address()
        {
        }

        public Address(string id) : base()
        {
            Id = id;
        }

        public string Id { get; set; }

        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public int CityId { get; set; }
        public int? StateId { get; set; }
        public int CountryId { get; set; }
        public bool IsActive { get; set; }

        public string CreationUser { get; set; }
        public DateTime CreationDateTime { get; set; }
        public string LastUpdateUser { get; set; }
        public DateTime? LastUpdateDateTime { get; set; }
        public byte[] Timestamp { get; set; }

        public City City { get; set; }
        public State State { get; set; }
        public Country Country { get; set; }
    }
}