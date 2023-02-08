using System.Collections.Generic;

namespace ZeorStack.DeviceCenter.Domain.Aggregates.MeasurementAggregate
{
    public class PageableListResult<T>
    {
        public PageableListResult(IReadOnlyList<T> items, int? offset)
        {
            Items = items;
            Offset = offset;
        }

        public IReadOnlyList<T> Items { get; }

        public int? Offset { get; }
    }
}
