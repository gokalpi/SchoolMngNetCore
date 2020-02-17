using SchoolMngNetCore.Core.Contracts.Administration;
using SchoolMngNetCore.Core.Entities.Administration;

namespace SchoolMngNetCore.Infrastructure.Data.Repositories.Administration
{
    public class SubjectRepository : RepositoryBase<Subject>, ISubjectRepository
    {
        public SubjectRepository(StudentDbContext context) : base(context)
        {
        }
    }
}