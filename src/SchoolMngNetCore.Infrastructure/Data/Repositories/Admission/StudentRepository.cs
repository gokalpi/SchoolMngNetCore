using SchoolMngNetCore.Core.Entities.Admission;
using SchoolMngNetCore.Core.Contracts.Admission;

namespace SchoolMngNetCore.Infrastructure.Data.Repositories.Admission
{
    public class StudentRepository : RepositoryBase<Student>, IStudentRepository
    {
        public StudentRepository(StudentDbContext context) : base(context)
        {
        }
    }
}