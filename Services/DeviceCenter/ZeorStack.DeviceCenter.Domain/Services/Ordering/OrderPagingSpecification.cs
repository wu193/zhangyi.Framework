using System;
using ZeorStack.DeviceCenter.Domain.Aggregates.OrderAggregate;
using ZeorStack.DeviceCenter.Domain.Specifications;
using ZeorStack.DeviceCenter.Domain.Specifications.Builder;

namespace ZeorStack.DeviceCenter.Domain.Services.Ordering
{
    public class OrderPagingSpecification : Specification<Order>
    {
        public OrderPagingSpecification(int pageNumber, int pageSize)
        {
            Query.Where(o => o.CreationTime > DateTimeOffset.Now.AddDays(-1));
            Query.Include(o => o.OrderItems);
            Query.Include(o => o.Address).ThenInclude(d => d.Country);
            Query.OrderBy(o => o.CreationTime);
            Query.Skip((pageNumber - 1) * pageSize).Take(pageSize);
        }
    }
}