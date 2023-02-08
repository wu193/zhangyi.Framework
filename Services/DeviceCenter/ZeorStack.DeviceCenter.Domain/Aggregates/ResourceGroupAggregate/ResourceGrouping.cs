using System;
using System.Diagnostics.CodeAnalysis;
using ZeorStack.DeviceCenter.Domain.Entities;

namespace ZeorStack.DeviceCenter.Domain.Aggregates.ResourceGroupAggregate
{
    public class ResourceGrouping : BaseAggregateRoot<Guid>, IMultiTenant
    {
        [AllowNull]
        public ResourceDescriptor Resource { get; set; }

        public Guid ResourceGroupId { get; set; }

        public Guid? TenantId { get; set; }
    }
}