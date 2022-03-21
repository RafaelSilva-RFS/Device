using Device.Application.Contracts.Devices;
using Device.Application.Contracts.Devices.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Device.Application.Device
{
    public class DeviceDetailService : IDeviceDetailService
    {
        private IDeviceDetailsRepository _deviceDetailRepository { get; set; }

        public DeviceDetailService(IDeviceDetailsRepository deviceDetailRepository)
        {
            _deviceDetailRepository = deviceDetailRepository;
        }

        public async Task<float> CountAllDevicesUsageAsync()
        {
            return await _deviceDetailRepository.CountAllDevicesUsageAsync();
        }
    }
}
