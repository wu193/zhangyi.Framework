using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ZeorStack.DeviceCenter.Domain.Constants;
using ZeorStack.DeviceCenter.Domain.Repositories;

namespace ZeorStack.DeviceCenter.Domain.Aggregates.DeviceAggregate
{
    public interface IDeviceRepository : IRepository<Device, long>
    {
        Task<List<Device>> GetListAsync(int? productId, int? deviceGroupId, DeviceStatus? status, string? deviceName, int pageNumber = 1, int pageSize = PagingConstants.DefaultPageSize, CancellationToken cancellationToken = default);

        Task<int> GetCountAsync(int? productId, int? deviceGroupId, DeviceStatus? status, string? deviceName, CancellationToken cancellationToken = default);
    }
}