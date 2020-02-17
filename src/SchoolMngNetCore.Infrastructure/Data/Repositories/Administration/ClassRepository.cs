using SchoolMngNetCore.Core.Contracts.Administration;
using SchoolMngNetCore.Core.Entities.Administration;

namespace SchoolMngNetCore.Infrastructure.Data.Repositories.Administration
{
    public class ClassRepository : RepositoryBase<Class>, IClassRepository
    {
        public ClassRepository(StudentDbContext context) : base(context)
        {
        }
    }
}