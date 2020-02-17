using SchoolMngNetCore.Core.Entities.Schedule;
using SchoolMngNetCore.Core.Contracts.Schedule;

namespace SchoolMngNetCore.Infrastructure.Data.Repositories.Schedule
{
    public class CourseScheduleRepository : RepositoryBase<CourseSchedule>, ICourseScheduleRepository
    {
        public CourseScheduleRepository(StudentDbContext context) : base(context)
        {
        }
    }
}