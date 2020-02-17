using System;
using System.ComponentModel.DataAnnotations;

namespace SchoolMngNetCore.Services.Requests.Finance
{
    public class FeeRequest
    {
        [Required]
        public int SchoolId { get; set; }

        [Required]
        public double Amount { get; set; }

        [Required]
        public DateTime DueDate { get; set; }

        [Required]
        public int FeeTypeId { get; set; }

        [Required]
        public int StudentId { get; set; }

        public int? SessionId { get; set; }
    }
}