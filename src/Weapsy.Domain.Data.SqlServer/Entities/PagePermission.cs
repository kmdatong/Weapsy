﻿using System;
using Weapsy.Domain.Model.Pages;

namespace Weapsy.Domain.Data.SqlServer.Entities
{
    public class PagePermission : IDbEntity
    {
        public Guid PageId { get; set; }  
        public PermissionType Type { get; set; }
        public string RoleId { get; set; }

        public virtual Page Page { get; set; }
    }
}
