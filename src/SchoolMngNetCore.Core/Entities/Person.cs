using SchoolMngNetCore.Core.Contracts;
using System;

namespace SchoolMngNetCore.Core.Entities
{
    public class Person : IAuditableEntity
    {
        public Person()
        {
        }

        public Person(int? id)
        {
            Id = id;
        }

        public int? Id { get; set; }
        public string SSN { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public EGender Gender { get; set; }
        public EBloodGroup BloodGroup { get; set; }
        public string Nationality { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public byte[] Photo { get; set; }

        public string CreationUser { get; set; }
        public DateTime CreationDateTime { get; set; }
        public string LastUpdateUser { get; set; }
        public DateTime? LastUpdateDateTime { get; set; }
        public byte[] Timestamp { get; set; }
    }

    public enum EGender : byte
    {
        Male = 1,
        Female
    }

    public enum EBloodGroup : short
    {
        APositive = 1,
        BPositive,
        ABPositive,
        OPositive,
        ANegative,
        BNegative,
        ABNegative,
        ONegative
    }
}