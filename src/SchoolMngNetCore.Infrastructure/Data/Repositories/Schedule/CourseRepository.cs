using SchoolMngNetCore.Core.Entities.Schedule;
using SchoolMngNetCore.Core.Contracts.Schedule;

namespace SchoolMngNetCore.Infrastructure.Data.Repositories.Schedule
{
    public class CourseRepository : RepositoryBase<Course>, ICourseRepository
    {
        public CourseRepository(StudentDbContext context) : base(context)
        {
        }
    }
}