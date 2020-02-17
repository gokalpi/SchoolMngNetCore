using SchoolMngNetCore.Core.Entities.HumanResources;
using SchoolMngNetCore.Core.Contracts.HumanResources;

namespace SchoolMngNetCore.Infrastructure.Data.Repositories.HumanResources
{
    public class StaffTypeRepository : RepositoryBase<StaffType>, IStaffTypeRepository
    {
        public StaffTypeRepository(StudentDbContext context) : base(context)
        {
        }
    }
}