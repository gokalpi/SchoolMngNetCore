using SchoolMngNetCore.Core.Contracts.Administration;
using SchoolMngNetCore.Core.Entities.Administration;

namespace SchoolMngNetCore.Infrastructure.Data.Repositories.Administration
{
    public class SchoolDistrictRepository : RepositoryBase<SchoolDistrict>, ISchoolDistrictRepository
    {
        public SchoolDistrictRepository(StudentDbContext context) : base(context)
        {
        }
    }
}