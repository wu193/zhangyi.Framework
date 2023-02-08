using System.Collections.Generic;
using System.Threading.Tasks;
using ZeorStack.DeviceCenter.Domain.Aggregates.DeviceAggregate;

namespace ZeorStack.DeviceCenter.Domain.Services.Devices
{
    public interface IDeviceGroupDomainService
    {
        Task<(List<DeviceGroup> Items, int TotalCount)> GetDeviceGroupListAsync(int? parentId, string? keyword, int pageNumber, int pageSize);
    }
}
