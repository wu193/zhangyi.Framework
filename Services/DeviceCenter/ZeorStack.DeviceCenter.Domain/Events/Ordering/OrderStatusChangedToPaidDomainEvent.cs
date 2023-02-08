using MediatR;
using System;
using System.Collections.Generic;
using ZeorStack.DeviceCenter.Domain.Aggregates.OrderAggregate;

namespace ZeorStack.DeviceCenter.Domain.Events.Ordering
{
    /// <summary>
    /// Event used when the order is paid
    /// </summary>
    public class OrderStatusChangedToPaidDomainEvent : INotification
    {
        public Guid OrderId { get; }

        public IEnumerable<OrderItem> OrderItems { get; }

        public OrderStatusChangedToPaidDomainEvent(Guid orderId, IEnumerable<OrderItem> orderItems)
        {
            OrderId = orderId;
            OrderItems = orderItems;
        }
    }
}