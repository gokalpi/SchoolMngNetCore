using SchoolMngNetCore.Core.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace SchoolMngNetCore.Services.Requests.HumanResources
{
    public class StaffRequest
    {
        [Required]
        public int SchoolId { get; set; }

        [Required]
        public int StaffTypeId { get; set; }

        [Required]
        public DateTime HireDate { get; set; }

        [Required]
        public string SSN { get; set; }

        [Required]
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        public string BirthPlace { get; set; }

        [Required]
        public EGender Gender { get; set; }

        [Required]
        public EBloodGroup BloodGroup { get; set; }

        [Required]
        public string Nationality { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string Email { get; set; }

        public byte[] Photo { get; set; }
    }
}