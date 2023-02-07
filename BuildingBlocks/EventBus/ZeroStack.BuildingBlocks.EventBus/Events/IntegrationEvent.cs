using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroStack.BuildingBlocks.EventBus.Events
{
    /// <summary>
    /// 集成事件抽象
    /// </summary>
    public class IntegrationEvent
    {
        public IntegrationEvent()
        {
            Id = new Guid();
            CreationDate = DateTimeOffset.Now;
        }

        public IntegrationEvent(Guid id, DateTimeOffset creationDate)
        {
            Id = id;
            CreationDate = creationDate;
        }

        public Guid Id { get; set; }
        public DateTimeOffset CreationDate { get; set; }
    }
}
