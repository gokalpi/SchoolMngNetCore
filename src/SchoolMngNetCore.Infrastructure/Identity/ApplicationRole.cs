using Microsoft.AspNetCore.Identity;
using SchoolMngNetCore.Core.Contracts;

namespace SchoolMngNetCore.Infrastructure.Identity
{
    public class ApplicationRole : IdentityRole<int>, IEntity
    {
    }
}