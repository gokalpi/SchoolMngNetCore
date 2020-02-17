using SchoolMngNetCore.Core.Contracts.Administration;
using SchoolMngNetCore.Core.Entities.Administration;

namespace SchoolMngNetCore.Infrastructure.Data.Repositories.Administration
{
    public class CityRepository : RepositoryBase<City>, ICityRepository
    {
        public CityRepository(StudentDbContext context) : base(context)
        {
        }
    }
}