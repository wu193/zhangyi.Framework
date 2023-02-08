using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel;
using ZeorStack.DeviceCenter.Domain.Aggregates.DeviceAggregate;
using ZeorStack.DeviceCenter.Domain.Aggregates.TenantAggregate;
using ZeorStack.DeviceCenter.Domain.Services.Devices;
using ZeorStack.DeviceCenter.Domain.Services.Ordering;

namespace ZeorStack.DeviceCenter.Domain
{
    public static class DependencyRegistrar
    {
        public static IServiceCollection AddDomainLayer(this IServiceCollection services)
        {
            services.AddTransient<IOrderDomainService, OrderDomainService>();
            services.AddTransient<IDeviceGroupDomainService, DeviceGroupDomainService>();

            services.AddSingleton<ICurrentTenantAccessor, CurrentTenantAccessor>();
            services.AddTransient<ICurrentTenant, CurrentTenant>();

            TypeDescriptor.AddAttributes(typeof(GeoCoordinate), new TypeConverterAttribute(typeof(GeoCoordinateTypeConverter)));

            return services;
        }
    }
}