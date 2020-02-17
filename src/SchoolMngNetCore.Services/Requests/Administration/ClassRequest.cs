using System.ComponentModel.DataAnnotations;

namespace SchoolMngNetCore.Services.Requests.Administration
{
    public class ClassRequest
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int SchoolId { get; set; }
    }
}