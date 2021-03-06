﻿using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamStore.Interfaces
{
    public interface IPermissionService
    {
        Task<bool> UserHasAccess(int projectId);
        Task<bool> UserHasAccess(Project project);
        Task GrantAccess(Project project);
    }
}
