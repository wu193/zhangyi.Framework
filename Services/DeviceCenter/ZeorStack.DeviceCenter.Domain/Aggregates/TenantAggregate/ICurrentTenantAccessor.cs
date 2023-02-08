namespace ZeorStack.DeviceCenter.Domain.Aggregates.TenantAggregate
{
    public interface ICurrentTenantAccessor
    {
        TenantInfo? Current { get; set; }
    }
}