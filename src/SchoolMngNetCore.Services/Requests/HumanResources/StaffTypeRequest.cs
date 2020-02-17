using System.ComponentModel.DataAnnotations;

namespace SchoolMngNetCore.Services.Requests.HumanResources
{
    public class StaffTypeRequest
    {
        [Required]
        public int SchoolId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}