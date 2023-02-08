using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZeorStack.DeviceCenter.Domain.Aggregates.DeviceAggregate;
using ZeorStack.DeviceCenter.Domain.Repositories;

namespace ZeorStack.DeviceCenter.Domain.Services.Devices
{
    public class DeviceGroupDomainService : IDeviceGroupDomainService
    {
        private readonly IRepository<DeviceGroup, int> _deviceGroupRepository;

        public DeviceGroupDomainService(IRepository<DeviceGroup, int> deviceGroupRepository) => _deviceGroupRepository = deviceGroupRepository;

        public async Task<(List<DeviceGroup> Items, int TotalCount)> GetDeviceGroupListAsync(int? parentId, string? keyword, int pageNumber, int pageSize)
        {
            var specification = new DeviceGroupListSpecification(parentId, keyword, pageNumber, pageSize);

            var items = await _deviceGroupRepository.GetListAsync(specification);

            IQueryable<DeviceGroup> queryable = _deviceGroupRepository.Query;
            specification.WhereExpressions.ToList().ForEach(e => queryable = queryable.Where(e));

            int totalCount = await _deviceGroupRepository.AsyncExecuter.CountAsync(queryable);

            return (items, totalCount);
        }

       
    }
}
