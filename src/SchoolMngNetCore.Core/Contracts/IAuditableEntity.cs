﻿using System;

namespace SchoolMngNetCore.Core.Contracts
{
    public interface IAuditableEntity : IEntity
    {
        string CreationUser { get; set; }

        DateTime CreationDateTime { get; set; }

        string LastUpdateUser { get; set; }

        DateTime? LastUpdateDateTime { get; set; }
    }
}