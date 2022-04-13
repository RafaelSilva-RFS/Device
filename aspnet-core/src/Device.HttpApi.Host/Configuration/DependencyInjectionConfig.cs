using Device.Application.Contracts.Devices;
using Device.Application.Device;
using Device.Domain.Device.Interfaces;
using Device.Domain.Device.Managers;
using Device.Domain.Device.Repositories;
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

            services.AddScoped<IDeviceManager, DeviceManager>();
            services.AddScoped<IDeviceDetailManager, DeviceDetailManager>();

            services.AddScoped<IDeviceService, DeviceService>();
            services.AddScoped<IDeviceDetailService, DeviceDetailService>();

            return services;
        }
    }
}
