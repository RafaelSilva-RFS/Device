using Device.Application.Contracts.Devices;
using Device.Application.Contracts.Devices.Repositories;
using Device.Application.Device;
using Device.EntityFramework.Devices;
using Microsoft.Extensions.DependencyInjection;

namespace Device.HttpApi.Host.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<IDevicesRepository, DevicesRepository>();
            services.AddScoped<IDeviceDetailsRepository, DeviceDetailsRepository>();
            services.AddScoped<IDeviceService, DeviceService>();
            services.AddScoped<IDeviceDetailService, DeviceDetailService>();

            return services;
        }
    }
}
