using System.Diagnostics.CodeAnalysis;

namespace ZeorStack.DeviceCenter.Domain.Aggregates.ProductAggregate
{
    public class DataParameter
    {
        [AllowNull]
        public string Identifier { get; set; }

        [AllowNull]
        public string ParameterName { get; set; }

        [AllowNull]
        public DataType DataType { get; set; }
    }
}
