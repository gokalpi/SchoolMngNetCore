using System.ComponentModel.DataAnnotations;

namespace SchoolMngNetCore.Services.Requests.Administration
{
    public class AddressRequest
    {
        [Required]
        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        [Required]
        public int CityId { get; set; }

        public int? StateId { get; set; }

        [Required]
        public int CountryId { get; set; }
    }
}