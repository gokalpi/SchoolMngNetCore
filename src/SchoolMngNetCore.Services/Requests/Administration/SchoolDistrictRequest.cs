using System.ComponentModel.DataAnnotations;

namespace SchoolMngNetCore.Services.Requests.Administration
{
    public class SchoolDistrictRequest
    {
        [Required]
        public int SchoolId { get; set; }

        [Required]
        public int DistrictId { get; set; }
    }
}