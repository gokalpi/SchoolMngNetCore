using System.ComponentModel.DataAnnotations;

namespace SchoolMngNetCore.Services.Requests.Administration
{
    public class DistrictRequest
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int CityId { get; set; }
    }
}