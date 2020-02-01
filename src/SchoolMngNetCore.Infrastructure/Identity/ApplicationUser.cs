using Microsoft.AspNetCore.Identity;
using SchoolMngNetCore.Core.Entities.Base;

namespace SchoolMngNetCore.Infrastructure.Identity
{
    public class ApplicationUser : IdentityUser<int>, IEntity<int>
    {
    }
}