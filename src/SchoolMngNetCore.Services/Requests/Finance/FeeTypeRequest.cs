using System;
using System.ComponentModel.DataAnnotations;

namespace SchoolMngNetCore.Services.Requests.Finance
{
    public class FeeTypeRequest
    {
        [Required]
        public int SchoolId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}