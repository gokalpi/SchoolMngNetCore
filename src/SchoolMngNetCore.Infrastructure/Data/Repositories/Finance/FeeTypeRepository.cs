using SchoolMngNetCore.Core.Entities.Finance;
using SchoolMngNetCore.Core.Contracts.Finance;

namespace SchoolMngNetCore.Infrastructure.Data.Repositories.Finance
{
    public class FeeTypeRepository : RepositoryBase<FeeType>, IFeeTypeRepository
    {
        public FeeTypeRepository(StudentDbContext context) : base(context)
        {
        }
    }
}