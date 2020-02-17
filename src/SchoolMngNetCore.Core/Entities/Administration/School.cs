using SchoolMngNetCore.Core.Contracts;
using SchoolMngNetCore.Core.Entities.Admission;
using SchoolMngNetCore.Core.Entities.Finance;
using SchoolMngNetCore.Core.Entities.HumanResources;
using SchoolMngNetCore.Core.Entities.Schedule;
using System;
using System.Collections.Generic;

namespace SchoolMngNetCore.Core.Entities.Administration
{
    public class School : IAuditableEntity
    {
        public School()
        {
            Departments = new HashSet<Department>();
            Districts = new HashSet<SchoolDistrict>();
            Fees = new HashSet<Fee>();
            FeeTypes = new HashSet<FeeType>();
            Students = new HashSet<StudentAdmission>();
            Staffs = new HashSet<Staff>();
            StaffTypes = new HashSet<StaffType>();
        }

        public School(int? id) : base()
        {
            Id = id;
        }

        public int? Id { get; set; }
        public string Name { get; set; }
        public int AddressId { get; set; }
        public bool IsActive { get; set; }

        public string CreationUser { get; set; }
        public DateTime CreationDateTime { get; set; }
        public string LastUpdateUser { get; set; }
        public DateTime? LastUpdateDateTime { get; set; }
        public byte[] Timestamp { get; set; }

        public virtual Address Address { get; set; }

        public virtual ICollection<Department> Departments { get; set; }
        public virtual ICollection<SchoolDistrict> Districts { get; set; }
        public virtual ICollection<Fee> Fees { get; set; }
        public virtual ICollection<FeeType> FeeTypes { get; set; }
        public virtual ICollection<Semester> Semesters { get; set; }
        public virtual ICollection<StudentAdmission> Students { get; set; }
        public virtual ICollection<Staff> Staffs { get; set; }
        public virtual ICollection<StaffType> StaffTypes { get; set; }
    }
}