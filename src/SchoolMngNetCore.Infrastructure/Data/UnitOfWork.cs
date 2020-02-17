using SchoolMngNetCore.Core.Contracts;
using SchoolMngNetCore.Core.Contracts.Administration;
using SchoolMngNetCore.Core.Contracts.Admission;
using SchoolMngNetCore.Core.Contracts.Finance;
using SchoolMngNetCore.Core.Contracts.HumanResources;
using SchoolMngNetCore.Core.Contracts.Schedule;
using SchoolMngNetCore.Infrastructure.Data.Repositories.Administration;
using SchoolMngNetCore.Infrastructure.Data.Repositories.Admission;
using SchoolMngNetCore.Infrastructure.Data.Repositories.Finance;
using SchoolMngNetCore.Infrastructure.Data.Repositories.HumanResources;
using SchoolMngNetCore.Infrastructure.Data.Repositories.Schedule;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace SchoolMngNetCore.Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private StudentDbContext _context;
        private IAddressRepository _addressRepository;
        private IAttendanceRepository _attendanceRepository;
        private ICityRepository _cityRepository;
        private IClassRepository _classRepository;
        private ICountryRepository _countryRepository;
        private ICourseRepository _courseRepository;
        private ICourseScheduleRepository _courseScheduleRepository;
        private IDepartmentRepository _departmentRepository;
        private IDistrictRepository _districtRepository;
        private IFeeRepository _feeRepository;
        private IFeeTypeRepository _feeTypeRepository;
        private IParentRepository _parentRepository;
        private ISchoolDistrictRepository _schoolDistrictRepository;
        private ISchoolRepository _schoolRepository;
        private ISemesterRepository _semesterRepository;
        private ISessionRepository _sessionRepository;
        private IStaffRepository _staffRepository;
        private IStaffTypeRepository _staffTypeRepository;
        private IStateRepository _stateRepository;
        private IStudentAdmissionRepository _studentAdmissionRepository;
        private IStudentParentRepository _studentParentRepository;
        private IStudentRepository _studentRepository;
        private ISubjectRepository _subjectRepository;
        private IInstructorRepository _teacherRepository;

        public UnitOfWork(StudentDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IAddressRepository Addresses => _addressRepository ?? (_addressRepository = new AddressRepository(_context));
        public IAttendanceRepository Attendances => _attendanceRepository ?? (_attendanceRepository = new AttendanceRepository(_context));
        public ICityRepository Cities => _cityRepository ?? (_cityRepository = new CityRepository(_context));
        public IClassRepository Classes => _classRepository ?? (_classRepository = new ClassRepository(_context));
        public ICountryRepository Countries => _countryRepository ?? (_countryRepository = new CountryRepository(_context));
        public ICourseRepository Courses => _courseRepository ?? (_courseRepository = new CourseRepository(_context));
        public ICourseScheduleRepository CourseSchedules => _courseScheduleRepository ?? (_courseScheduleRepository = new CourseScheduleRepository(_context));
        public IDepartmentRepository Departments => _departmentRepository ?? (_departmentRepository = new DepartmentRepository(_context));
        public IDistrictRepository Districts => _districtRepository ?? (_districtRepository = new DistrictRepository(_context));
        public IFeeRepository Fees => _feeRepository ?? (_feeRepository = new FeeRepository(_context));
        public IFeeTypeRepository FeeTypes => _feeTypeRepository ?? (_feeTypeRepository = new FeeTypeRepository(_context));
        public IParentRepository Parents => _parentRepository ?? (_parentRepository = new ParentRepository(_context));
        public ISchoolDistrictRepository SchoolDistricts => _schoolDistrictRepository ?? (_schoolDistrictRepository = new SchoolDistrictRepository(_context));
        public ISchoolRepository Schools => _schoolRepository ?? (_schoolRepository = new SchoolRepository(_context));
        public ISemesterRepository Semesters => _semesterRepository ?? (_semesterRepository = new SemesterRepository(_context));
        public ISessionRepository Sessions => _sessionRepository ?? (_sessionRepository = new SessionRepository(_context));
        public IStaffRepository Staffs => _staffRepository ?? (_staffRepository = new StaffRepository(_context));
        public IStaffTypeRepository StaffTypes => _staffTypeRepository ?? (_staffTypeRepository = new StaffTypeRepository(_context));
        public IStateRepository States => _stateRepository ?? (_stateRepository = new StateRepository(_context));
        public IStudentAdmissionRepository StudentAdmissions => _studentAdmissionRepository ?? (_studentAdmissionRepository = new StudentAdmissionRepository(_context));
        public IStudentParentRepository StudentParents => _studentParentRepository ?? (_studentParentRepository = new StudentParentRepository(_context));
        public IStudentRepository Students => _studentRepository ?? (_studentRepository = new StudentRepository(_context));
        public ISubjectRepository Subjects => _subjectRepository ?? (_subjectRepository = new SubjectRepository(_context));
        public IInstructorRepository Instructors => _teacherRepository ?? (_teacherRepository = new InstructorRepository(_context));

        public virtual int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public virtual async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await _context.SaveChangesAsync(cancellationToken);
        }

        #region IDisposable Support

        private bool disposed = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }

                disposed = true;
            }
        }

        ~UnitOfWork()
        {
            Dispose(false);
        }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion IDisposable Support
    }
}