using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using ZeorStack.DeviceCenter.Domain.Entities;

namespace ZeorStack.DeviceCenter.Domain.Aggregates.ProjectAggregate
{
    public class Project : BaseAggregateRoot<int>
    {
        /// <summary>
        /// 产品名称
        /// </summary>  
        [AllowNull]
        
        public string Name { get; set; }

        public DateTimeOffset CreationTime { get; set; } = DateTimeOffset.Now;  

        public List<ProjectGroup> Groups { get; set; } = new();
    }
}