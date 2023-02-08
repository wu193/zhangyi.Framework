using System.Diagnostics.CodeAnalysis;

namespace ZeorStack.DeviceCenter.Domain.Aggregates.ResourceGroupAggregate
{
    public partial record ResourceDescriptor
    {
        [AllowNull]
        public string ResourceType { get; set; }

        [AllowNull]
        public string ResourceId { get; set; }
    }
}