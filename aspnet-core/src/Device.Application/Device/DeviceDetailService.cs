using Device.Application.Contracts.Devices;
using Device.Domain.Device.Interfaces;
using Device.Domain.Device.Managers;
using System.Threading.Tasks;

namespace Device.Application.Device
{
    public class DeviceDetailService : IDeviceDetailService
    {
        private IDeviceDetailManager _deviceDetailManager { get; set; }

        public DeviceDetailService(IDeviceDetailManager deviceDetailManager)
        {
            _deviceDetailManager = deviceDetailManager;
        }

        public async Task<float> CountAllDevicesUsageAsync()
        {
            return await _deviceDetailManager.CountAllDevicesUsageAsync();
        }
    }
}
