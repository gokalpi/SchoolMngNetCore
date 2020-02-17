using System;
using System.ComponentModel.DataAnnotations;

namespace SchoolMngNetCore.Services.Requests.Schedule
{
    public class CourseScheduleRequest
    {
        [Required]
        public int CourseId { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        [Required]
        public int InstructorId { get; set; }

        [Required]
        public int LocationId { get; set; }
    }
}