﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeorStack.DeviceCenter.Domain.Entities
{
    public interface IMultiTenant
    {
        Guid? TenantId { get; set; }
    }
}
