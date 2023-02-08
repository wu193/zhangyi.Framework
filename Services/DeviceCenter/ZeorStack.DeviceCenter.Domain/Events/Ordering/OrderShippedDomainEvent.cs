using MediatR;
using ZeorStack.DeviceCenter.Domain.Aggregates.OrderAggregate;

namespace ZeorStack.DeviceCenter.Domain.Events.Ordering
{
    public class OrderShippedDomainEvent : INotification
    {
        public Order Order { get; }

        public OrderShippedDomainEvent(Order order)
        {
            Order = order;
        }
    }
}
