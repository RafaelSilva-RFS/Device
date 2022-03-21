using Device.Application.Contracts.Devices;
using Device.Application.Contracts.Devices.Dtos;
using Device.Application.Contracts.Devices.Repositories;
using System;
using System.Collections;
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

        public async Task<IEnumerable<GetMostUsedDevicesDto>> GetMostUsedDevices(int take)
        {
            return await _deviceDetailRepository.GetMostUsedDevices(take);
        }

        public async Task<float> CountAllDevicesUsageAsync()
        {
            return await _deviceDetailRepository.CountAllDevicesUsageAsync();
        }
    }
}
