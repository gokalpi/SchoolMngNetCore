using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SchoolMngNetCore.Core.Entities;
using SchoolMngNetCore.Core.Entities.Administration;
using SchoolMngNetCore.Core.Entities.Admission;
using SchoolMngNetCore.Core.Entities.Finance;
using SchoolMngNetCore.Core.Entities.HumanResources;
using SchoolMngNetCore.Core.Entities.Schedule;
using SchoolMngNetCore.Infrastructure.Identity;

namespace SchoolMngNetCore.Infrastructure.Data
{
    public class StudentDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, int>
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options)
            : base(options)
        {
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseSchedule> CourseSchedules { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Fee> Fees { get; set; }
        public DbSet<FeeType> FeeTypes { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<SchoolDistrict> SchoolDistricts { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Semester> Semesters { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<StaffType> StaffTypes { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentAdmission> StudentAdmissions { get; set; }
        public DbSet<StudentParent> StudentParents { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Person> People { get; set; }
    }
}