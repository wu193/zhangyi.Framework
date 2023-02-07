using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroStack.BuildingBlocks.EventBus.Events;

namespace ZeroStack.BuildingBlocks.EventBus.Abstractions
{
    /// <summary>
    /// 集成事件接口
    /// </summary>
    public interface IIntegrationEventHandler
    {
        public interface IIntegrationEventHandler { }

        public interface IIntegrationEventHandler<in TIntegrationEvent> : IIntegrationEventHandler where TIntegrationEvent : IntegrationEvent
        {
            Task HandleAsync(TIntegrationEvent @event);
        }
    }
}
