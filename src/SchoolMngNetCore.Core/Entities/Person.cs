using SchoolMngNetCore.Core.Entities.Base;
using System;

namespace SchoolMngNetCore.Core.Entities
{
    public class Person : Entity
    {
        public string SSN { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DateofBirth { get; set; }
        public EGender Gender { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
    }

    public enum EGender
    {
        Male = 1,
        Female = 2
    }
}