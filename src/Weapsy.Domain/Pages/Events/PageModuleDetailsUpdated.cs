﻿using System;
using Weapsy.Infrastructure.Domain;

namespace Weapsy.Domain.Pages.Events
{
    public class PageModuleDetailsUpdated : DomainEvent
    {
        public Guid SiteId { get; set; }
        public PageModule PageModule { get; set; }
    }
}
