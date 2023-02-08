﻿using System.Threading;

namespace ZeorStack.DeviceCenter.Domain.Aggregates.TenantAggregate
{
    public class CurrentTenantAccessor : ICurrentTenantAccessor
    {
        private readonly AsyncLocal<TenantInfo?> _currentScope = new();

        public TenantInfo? Current { get => _currentScope.Value; set => _currentScope.Value = value; }

        public CurrentTenantAccessor() => _currentScope = new AsyncLocal<TenantInfo?>();
    }
}
