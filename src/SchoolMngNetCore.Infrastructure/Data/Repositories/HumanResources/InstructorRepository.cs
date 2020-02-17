using SchoolMngNetCore.Core.Entities.HumanResources;
using SchoolMngNetCore.Core.Contracts.HumanResources;

namespace SchoolMngNetCore.Infrastructure.Data.Repositories.HumanResources
{
    public class InstructorRepository : RepositoryBase<Instructor>, IInstructorRepository
    {
        public InstructorRepository(StudentDbContext context) : base(context)
        {
        }
    }
}