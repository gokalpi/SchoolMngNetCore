using SchoolMngNetCore.Core.Entities.Admission;
using SchoolMngNetCore.Core.Contracts.Admission;

namespace SchoolMngNetCore.Infrastructure.Data.Repositories.Admission
{
    public class StudentAdmissionRepository : RepositoryBase<StudentAdmission>, IStudentAdmissionRepository
    {
        public StudentAdmissionRepository(StudentDbContext context) : base(context)
        {
        }
    }
}