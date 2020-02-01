using System;

namespace SchoolMngNetCore.Core.Entities
{
    public class Student : Person
    {
        public string SchoolNo { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}