using SchoolMngNetCore.Core.Entities.Schedule;
using System;
using System.ComponentModel.DataAnnotations;

namespace SchoolMngNetCore.Services.Requests.Schedule
{
    public class AttendanceRequest
    {
        [Required]
        public int StudentId { get; set; }

        [Required]
        public int ClassId { get; set; }

        [Required]
        public DateTime ClassDate { get; set; }

        [Required]
        public EAttendanceStatus Status { get; set; }
    }
}