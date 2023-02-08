﻿using MediatR;
using System;
using ZeorStack.DeviceCenter.Domain.Aggregates.BuyerAggregate;

namespace ZeorStack.DeviceCenter.Domain.Events.Buyers
{
    public class BuyerAndPaymentMethodVerifiedDomainEvent : INotification
    {
        public Buyer Buyer { get; private set; }

        public PaymentMethod Payment { get; private set; }

        public Guid OrderId { get; private set; }

        public BuyerAndPaymentMethodVerifiedDomainEvent(Buyer buyer, PaymentMethod payment, Guid orderId)
        {
            Buyer = buyer;
            Payment = payment;
            OrderId = orderId;
        }
    }
}
