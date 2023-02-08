using System;
using ZeorStack.DeviceCenter.Domain.Entities;
using ZeorStack.DeviceCenter.Domain.Exceptions;

namespace ZeorStack.DeviceCenter.Domain.Aggregates.OrderAggregate
{
    public class OrderItem : BaseEntity<Guid>
    {
        public int ProductId { get; private set; }

        public decimal UnitPrice { get; private set; }

        public int Units { get; private set; }

        public OrderItem(int productId, decimal unitPrice, int units = 1)
        {
            if (units <= 0)
            {
                throw new OrderingDomainException("Invalid number of units");
            }

            if (unitPrice * units < byte.MaxValue)
            {
                throw new OrderingDomainException("The total of order item is lower than applied discount");
            }

            ProductId = productId;
            UnitPrice = unitPrice;
            Units = units;
        }

        public void AddUnits(int units)
        {
            if (units < 0)
            {
                throw new OrderingDomainException("Invalid units");
            }

            Units += units;
        }
    }
}
