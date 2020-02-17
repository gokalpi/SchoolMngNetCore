using System.ComponentModel.DataAnnotations;

namespace SchoolMngNetCore.Services.Requests.Administration
{
    public class CityRequest
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int CountryId { get; set; }
    }
}