using MediatR;
using ZeorStack.DeviceCenter.Domain.Aggregates.OrderAggregate;

namespace ZeorStack.DeviceCenter.Domain.Events.Ordering
{
    public class OrderCancelledDomainEvent : INotification
    {
        public Order Order { get; }

        public OrderCancelledDomainEvent(Order order)
        {
            Order = order;
        }
    }
}
