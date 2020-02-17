using SchoolMngNetCore.Core.Entities.Administration;

namespace SchoolMngNetCore.Core.Entities.HumanResources
{
    public class Instructor : Staff
    {
        public int DepartmentId { get; set; }

        public Department Department { get; set; }
    }
}