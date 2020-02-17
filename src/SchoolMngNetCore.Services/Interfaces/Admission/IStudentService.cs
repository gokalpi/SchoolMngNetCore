using SchoolMngNetCore.Core.Paging;
using SchoolMngNetCore.Services.Interfaces.Base;
using SchoolMngNetCore.Services.Requests.Admission;
using SchoolMngNetCore.Services.Responses.Admission;
using System.Threading.Tasks;

namespace SchoolMngNetCore.Services.Interfaces.Admission
{
    public interface IStudentService
    {
        Task<IListResponse<StudentResponse>> GetStudentList();

        Task<IPagedList<StudentResponse>> SearchStudents(PageQueryArgs args);

        Task<ISingleResponse<StudentResponse>> GetStudentById(int id);

        Task<ISingleResponse<StudentResponse>> CreateStudent(StudentRequest student);

        Task<IResponse> UpdateStudent(StudentRequest student);

        Task<IResponse> DeleteStudentById(int id);
    }
}