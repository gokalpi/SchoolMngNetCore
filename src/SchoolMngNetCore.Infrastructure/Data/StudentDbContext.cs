using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SchoolMngNetCore.Core.Entities;
using SchoolMngNetCore.Infrastructure.Identity;

namespace SchoolMngNetCore.Infrastructure.Data
{
    public class StudentDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, int>
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}