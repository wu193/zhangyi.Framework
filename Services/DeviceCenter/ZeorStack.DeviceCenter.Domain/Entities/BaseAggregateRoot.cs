﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeorStack.DeviceCenter.Domain.Entities
{
    public abstract class BaseAggregateRoot : BaseEntity, IAggregateRoot, IDomainEvents
    {
        private readonly List<INotification> _domainEvents = new();

        public IReadOnlyCollection<INotification> DomainEvents => _domainEvents.AsReadOnly();

        public void AddDomainEvent(INotification eventItem) => _domainEvents.Add(eventItem);

        public void RemoveDomainEvent(INotification eventItem) => _domainEvents?.Remove(eventItem);

        public void ClearDomainEvents() => _domainEvents?.Clear();
    }

    public abstract class BaseAggregateRoot<TKey> : BaseEntity<TKey>, IAggregateRoot, IDomainEvents
    {
        private readonly List<INotification> _domainEvents = new();

        public IReadOnlyCollection<INotification> DomainEvents => _domainEvents.AsReadOnly();

        public void AddDomainEvent(INotification eventItem) => _domainEvents.Add(eventItem);

        public void RemoveDomainEvent(INotification eventItem) => _domainEvents?.Remove(eventItem);

        public void ClearDomainEvents() => _domainEvents?.Clear();
    }
}
