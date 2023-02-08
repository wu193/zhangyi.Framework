using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ZeorStack.DeviceCenter.Domain.Repositories;

namespace ZeorStack.DeviceCenter.Domain.Aggregates.PermissionAggregate
{
    public interface IPermissionGrantRepository : IRepository<PermissionGrant, Guid>
    {
        Task<PermissionGrant?> FindAsync(string operationName, string providerName, string providerKey, Guid? resourceGroupId, CancellationToken cancellationToken = default);

        Task<List<PermissionGrant>> GetListAsync(string providerName, string providerKey, Guid? resourceGroupId, CancellationToken cancellationToken = default);

        Task<List<PermissionGrant>> GetListAsync(string[] operationNames, string providerName, string providerKey, Guid? resourceGroupId, CancellationToken cancellationToken = default);
    }
}