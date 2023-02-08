using System.Diagnostics.CodeAnalysis;
using ZeorStack.DeviceCenter.Domain.Entities;

namespace ZeorStack.DeviceCenter.Domain.Aggregates.ProductAggregate
{
    public class MeasurementUnit : BaseAggregateRoot<int>
    {
        [AllowNull]
        public string UnitName { get; set; }

        [AllowNull]
        public string Unit { get; set; }

        [AllowNull]
        public string? Remark { get; set; }
    }
}
