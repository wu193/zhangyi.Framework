using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using ZeorStack.DeviceCenter.Domain.Entities;

namespace ZeorStack.DeviceCenter.Domain.Aggregates.TenantAggregate
{
    public class Tenant : BaseAggregateRoot<Guid>
    {
        [AllowNull]
        public string Name { get; set; }

        public List<TenantConnectionString> ConnectionStrings { get; protected set; } = new List<TenantConnectionString>();
    }
}