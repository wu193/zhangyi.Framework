﻿namespace ZeorStack.DeviceCenter.Domain.Entities
{
    public interface ISoftDelete
    {
        bool IsDeleted { get; set; }
    }
}
