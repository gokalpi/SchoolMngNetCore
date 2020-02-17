using SchoolMngNetCore.Core.Contracts.Administration;
using SchoolMngNetCore.Core.Entities.Administration;

namespace SchoolMngNetCore.Infrastructure.Data.Repositories.Administration
{
    public class DistrictRepository : RepositoryBase<District>, IDistrictRepository
    {
        public DistrictRepository(StudentDbContext context) : base(context)
        {
        }
    }
}