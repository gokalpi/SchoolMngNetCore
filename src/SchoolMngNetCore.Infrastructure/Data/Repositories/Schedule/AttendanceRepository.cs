using SchoolMngNetCore.Core.Entities.Schedule;
using SchoolMngNetCore.Core.Contracts.Schedule;

namespace SchoolMngNetCore.Infrastructure.Data.Repositories.Schedule
{
    public class AttendanceRepository : RepositoryBase<Attendance>, IAttendanceRepository
    {
        public AttendanceRepository(StudentDbContext context) : base(context)
        {
        }
    }
}