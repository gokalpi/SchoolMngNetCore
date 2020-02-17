using SchoolMngNetCore.Core.Entities.Schedule;
using System.ComponentModel.DataAnnotations;

namespace SchoolMngNetCore.Services.Requests.Schedule
{
    public class CourseRequest
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int SemesterId { get; set; }

        [Required]
        public int SubjectId { get; set; }

        [Required]
        public ECourseFrequency Frequency { get; set; }

        [Required]
        public ECourseType Type { get; set; }

        [Required]
        public ECourseFormat Format { get; set; }
    }
}