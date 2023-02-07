using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroStack.BuildingBlocks.EventBus.Abstractions
{
    /// <summary>
    /// 动态集成事件接口
    /// </summary>
    public interface IDynamicIntegrationEventHandler: IIntegrationEventHandler
    {
        Task HandleAsync(dynamic eventData);
    }
}
