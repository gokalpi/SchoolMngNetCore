using System.ComponentModel.DataAnnotations;

namespace SchoolMngNetCore.Services.Requests.Admission
{
    public class StudentParentRequest
    {
        [Required]
        public int StudentId { get; set; }

        [Required]
        public int ParentId { get; set; }
    }
}