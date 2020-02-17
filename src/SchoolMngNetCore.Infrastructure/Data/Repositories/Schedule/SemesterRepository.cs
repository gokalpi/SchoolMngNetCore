using SchoolMngNetCore.Core.Entities.Schedule;
using SchoolMngNetCore.Core.Contracts.Schedule;

namespace SchoolMngNetCore.Infrastructure.Data.Repositories.Schedule
{
    public class SemesterRepository : RepositoryBase<Semester>, ISemesterRepository
    {
        public SemesterRepository(StudentDbContext context) : base(context)
        {
        }
    }
}