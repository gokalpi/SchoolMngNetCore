using AutoMapper;
using SchoolMngNetCore.Core.Contracts;
using SchoolMngNetCore.Core.Entities.Admission;
using SchoolMngNetCore.Core.Logging;
using SchoolMngNetCore.Core.Paging;
using SchoolMngNetCore.Services.Interfaces.Admission;
using SchoolMngNetCore.Services.Interfaces.Base;
using SchoolMngNetCore.Services.Requests.Admission;
using SchoolMngNetCore.Services.Responses.Admission;
using System;
using System.Threading.Tasks;

namespace SchoolMngNetCore.Services.Services.Admission
{
    public class StudentService : IStudentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IAppLogger<StudentService> _logger;

        public StudentService(IUnitOfWork unitOfWork, IMapper mapper, IAppLogger<StudentService> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public virtual async Task<StudentResponse> CreateStudent(StudentRequest student)
        {
            var newStudent = _mapper.Map<Student>(student);
            _unitOfWork.Students.Add(newStudent);
            await _unitOfWork.SaveChangesAsync();

            _logger.LogInformation("Student successfully added");

            var newStudentModel = _mapper.Map<StudentResponse>(newStudent);
            return newStudentModel;
        }

        public Task<IResponse> DeleteStudentById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ISingleResponse<StudentResponse>> GetStudentById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IListResponse<StudentResponse>> GetStudentList()
        {
            throw new NotImplementedException();
        }

        public Task<IPagedList<StudentResponse>> SearchStudents(PageQueryArgs args)
        {
            throw new NotImplementedException();
        }

        public Task<IResponse> UpdateStudent(StudentRequest student)
        {
            throw new NotImplementedException();
        }

        Task<ISingleResponse<StudentResponse>> IStudentService.CreateStudent(StudentRequest student)
        {
            throw new NotImplementedException();
        }
    }
}