using System;
using System.Diagnostics.CodeAnalysis;
using ZeorStack.DeviceCenter.Domain.Entities;

namespace ZeorStack.DeviceCenter.Domain.Aggregates.ResourceGroupAggregate
{
    public class ResourceGroup : BaseAggregateRoot<Guid>, IMultiTenant
    {
        public const string DefaultGroup = nameof(DefaultGroup);

        [AllowNull]
        public string Name { get; set; }

        public string? DisplayName { get; set; }

        public Guid? TenantId { get; set; }
    }
}