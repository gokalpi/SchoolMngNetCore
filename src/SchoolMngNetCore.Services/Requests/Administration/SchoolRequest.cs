using System.ComponentModel.DataAnnotations;

namespace SchoolMngNetCore.Services.Requests.Administration
{
    public class SchoolRequest
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public AddressRequest Address { get; set; }
    }
}