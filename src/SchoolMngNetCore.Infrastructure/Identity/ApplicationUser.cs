using Microsoft.AspNetCore.Identity;
using SchoolMngNetCore.Core.Contracts;

namespace SchoolMngNetCore.Infrastructure.Identity
{
    public class ApplicationUser : IdentityUser<int>, IEntity
    {
    }
}