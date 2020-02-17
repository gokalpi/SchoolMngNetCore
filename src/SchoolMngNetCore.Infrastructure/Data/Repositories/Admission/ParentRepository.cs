using SchoolMngNetCore.Core.Contracts.Admission;
using SchoolMngNetCore.Core.Entities.Admission;

namespace SchoolMngNetCore.Infrastructure.Data.Repositories.Admission
{
    public class ParentRepository : RepositoryBase<Parent>, IParentRepository
    {
        public ParentRepository(StudentDbContext context) : base(context)
        {
        }
    }
}