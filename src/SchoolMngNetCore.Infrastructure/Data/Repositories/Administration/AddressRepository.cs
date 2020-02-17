using SchoolMngNetCore.Core.Contracts.Administration;
using SchoolMngNetCore.Core.Entities.Administration;

namespace SchoolMngNetCore.Infrastructure.Data.Repositories.Administration
{
    public class AddressRepository : RepositoryBase<Address>, IAddressRepository
    {
        public AddressRepository(StudentDbContext context) : base(context)
        {
        }
    }
}