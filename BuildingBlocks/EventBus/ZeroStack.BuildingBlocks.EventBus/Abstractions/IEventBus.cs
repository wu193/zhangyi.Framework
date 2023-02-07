using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static ZeroStack.BuildingBlocks.EventBus.Abstractions.IIntegrationEventHandler;
using ZeroStack.BuildingBlocks.EventBus.Events;

namespace ZeroStack.BuildingBlocks.EventBus.Abstractions
{
    public interface IEventBus
    {
        /// <summary>
        /// 发布事件
        /// </summary>
        /// <param name="event">事件</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task PublishAsync(IntegrationEvent @event, CancellationToken cancellationToken = default);
        /// <summary>
        /// 强类型订阅事件
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TH"></typeparam>
        void Subscribe<T, TH>() where T : IntegrationEvent where TH : IIntegrationEventHandler<T>;
        /// <summary>
        /// 强类型取消订阅
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TH"></typeparam>
        void Unsubscribe<T, TH>() where T : IntegrationEvent where TH : IIntegrationEventHandler<T>;
        /// <summary>
        /// 弱类型订阅
        /// </summary>
        /// <typeparam name="TH"></typeparam>
        /// <param name="eventName"></param>
        void SubscribeDynamic<TH>(string eventName) where TH : IDynamicIntegrationEventHandler;
        /// <summary>
        /// 强类型取消订阅
        /// </summary>
        /// <typeparam name="TH"></typeparam>
        /// <param name="eventName"></param>
        void UnsubscribeDynamic<TH>(string eventName) where TH : IDynamicIntegrationEventHandler;
    }
}
