﻿using System;
using Weapsy.Infrastructure.Domain;

namespace Weapsy.Domain.Pages.Commands
{
    public class RemoveModule : ICommand
    {
        public Guid SiteId { get; set; }
        public Guid PageId { get; set; }
        public Guid ModuleId { get; set; }
    }
}