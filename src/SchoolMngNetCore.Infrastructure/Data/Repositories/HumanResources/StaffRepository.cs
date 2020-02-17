using SchoolMngNetCore.Core.Entities.HumanResources;
using SchoolMngNetCore.Core.Contracts.HumanResources;

namespace SchoolMngNetCore.Infrastructure.Data.Repositories.Admission
{
    public class StaffRepository : RepositoryBase<Staff>, IStaffRepository
    {
        public StaffRepository(StudentDbContext context) : base(context)
        {
        }
    }
}