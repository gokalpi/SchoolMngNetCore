using SchoolMngNetCore.Core.Contracts.Administration;
using SchoolMngNetCore.Core.Entities.Administration;

namespace SchoolMngNetCore.Infrastructure.Data.Repositories.Administration
{
    public class StateRepository : RepositoryBase<State>, IStateRepository
    {
        public StateRepository(StudentDbContext context) : base(context)
        {
        }
    }
}