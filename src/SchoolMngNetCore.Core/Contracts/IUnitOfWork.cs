using SchoolMngNetCore.Core.Contracts.Administration;
using SchoolMngNetCore.Core.Contracts.Admission;
using SchoolMngNetCore.Core.Contracts.Finance;
using SchoolMngNetCore.Core.Contracts.HumanResources;
using SchoolMngNetCore.Core.Contracts.Schedule;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace SchoolMngNetCore.Core.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        IAddressRepository Addresses { get; }
        IAttendanceRepository Attendances { get; }
        ICityRepository Cities { get; }
        IClassRepository Classes { get; }
        ICountryRepository Countries { get; }
        ICourseRepository Courses { get; }
        ICourseScheduleRepository CourseSchedules { get; }
        IDepartmentRepository Departments { get; }
        IDistrictRepository Districts { get; }
        IFeeRepository Fees { get; }
        IFeeTypeRepository FeeTypes { get; }
        IParentRepository Parents { get; }
        ISchoolDistrictRepository SchoolDistricts { get; }
        ISchoolRepository Schools { get; }
        ISemesterRepository Semesters { get; }
        ISessionRepository Sessions { get; }
        IStaffRepository Staffs { get; }
        IStaffTypeRepository StaffTypes { get; }
        IStateRepository States { get; }
        IStudentAdmissionRepository StudentAdmissions { get; }
        IStudentParentRepository StudentParents { get; }
        IStudentRepository Students { get; }
        ISubjectRepository Subjects { get; }
        IInstructorRepository Instructors { get; }

        int SaveChanges();

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}