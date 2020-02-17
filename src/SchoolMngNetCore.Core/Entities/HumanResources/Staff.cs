using SchoolMngNetCore.Core.Entities.Administration;
using System;

namespace SchoolMngNetCore.Core.Entities.HumanResources
{
    public class Staff : Person
    {
        public DateTime HireDate { get; set; }
        public int SchoolId { get; set; }
        public int StaffTypeId { get; set; }

        public virtual School School { get; set; }
        public virtual StaffType Type { get; set; }
    }
}