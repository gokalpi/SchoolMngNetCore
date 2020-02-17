using SchoolMngNetCore.Core.Entities.Admission;
using SchoolMngNetCore.Core.Contracts.Admission;

namespace SchoolMngNetCore.Infrastructure.Data.Repositories.Admission
{
    public class StudentParentRepository : RepositoryBase<StudentParent>, IStudentParentRepository
    {
        public StudentParentRepository(StudentDbContext context) : base(context)
        {
        }
    }
}