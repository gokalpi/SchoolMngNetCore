using SchoolMngNetCore.Core.Entities.Finance;
using SchoolMngNetCore.Core.Contracts.Finance;

namespace SchoolMngNetCore.Infrastructure.Data.Repositories.Finance
{
    public class FeeRepository : RepositoryBase<Fee>, IFeeRepository
    {
        public FeeRepository(StudentDbContext context) : base(context)
        {
        }
    }
}