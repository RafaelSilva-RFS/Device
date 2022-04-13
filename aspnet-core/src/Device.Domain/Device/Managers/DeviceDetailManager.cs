using Device.Domain.Device.Interfaces;
using Device.Domain.Device.Repositories;
using System.Threading.Tasks;

namespace Device.Domain.Device.Managers
{
    public class DeviceDetailManager : IDeviceDetailManager
    {
        private IDeviceDetailsRepository _deviceDetailRepository { get; set; }

        public DeviceDetailManager(IDeviceDetailsRepository deviceDetailRepository)
        {
            _deviceDetailRepository = deviceDetailRepository;
        }

        public async Task<float> CountAllDevicesUsageAsync()
        {
            return await _deviceDetailRepository.CountAllDevicesUsageAsync();
        }
    }
}
