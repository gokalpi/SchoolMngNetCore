using System;

namespace SchoolMngNetCore.Services.Responses.Admission
{
    public class StudentResponse
    {
        public int Id { get; set; }
        public string SSN { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public string Gender { get; set; }
        public string BloodGroup { get; set; }
        public string Nationality { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public byte[] Photo { get; set; }
        public string Status { get; set; }
        public string SchoolNumber { get; set; }
        public DateTime AdmissionDate { get; set; }
    }
}