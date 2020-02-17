using SchoolMngNetCore.Core.Entities.Schedule;
using SchoolMngNetCore.Core.Contracts.Schedule;

namespace SchoolMngNetCore.Infrastructure.Data.Repositories.Schedule
{
    public class SessionRepository : RepositoryBase<Session>, ISessionRepository
    {
        public SessionRepository(StudentDbContext context) : base(context)
        {
        }
    }
}