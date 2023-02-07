using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroStack.BuildingBlocks.EventBus.RabbitMQ
{
    /// <summary>
    /// mq可靠连接接口
    /// </summary>
    public interface IRabbitMQPersistentConnection
    {
        bool IsConnected { get; }
        /// <summary>
        /// 尝试连接
        /// </summary>
        /// <returns></returns>
        bool TryConnect();

        IModel CreateModel();
    }
}
