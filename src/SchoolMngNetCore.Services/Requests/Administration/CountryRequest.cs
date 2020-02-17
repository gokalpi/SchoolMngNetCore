using System.ComponentModel.DataAnnotations;

namespace SchoolMngNetCore.Services.Requests.Administration
{
    public class CountryRequest
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string FormalName { get; set; }

        [Required]
        public string IsoAlpha3Code { get; set; }
    }
}