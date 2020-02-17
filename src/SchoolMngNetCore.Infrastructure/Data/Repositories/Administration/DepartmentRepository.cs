﻿using SchoolMngNetCore.Core.Contracts.Administration;
using SchoolMngNetCore.Core.Entities.Administration;

namespace SchoolMngNetCore.Infrastructure.Data.Repositories.Administration
{
    public class DepartmentRepository : RepositoryBase<Department>, IDepartmentRepository
    {
        public DepartmentRepository(StudentDbContext context) : base(context)
        {
        }
    }
}