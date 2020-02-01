using Microsoft.AspNetCore.Identity;
using SchoolMngNetCore.Core.Entities.Base;

namespace SchoolMngNetCore.Infrastructure.Identity
{
    public class ApplicationRole : IdentityRole<int>, IEntity<int>
    {
    }
}