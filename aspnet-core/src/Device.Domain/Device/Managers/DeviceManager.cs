using Device.Domain.Device.Interfaces;
using Device.Domain.Device.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Device.Domain.Device.Managers
{
    public class DeviceManager : IDeviceManager
    {
        private IDevicesRepository _devicesRepository { get; set; }

        public DeviceManager(IDevicesRepository devicesRepository)
        {
            _devicesRepository = devicesRepository;
        }

        public async Task<(int, List<Entities.Device>)> GetDevicesPagedAsync(int skipCount,
                                                                             int maxResultCount,
                                                                             string sorting,
                                                                             string filter,
                                                                             int? status,
                                                                             int? deviceType)
        {
            var (totalCount, result) = await _devicesRepository
                                             .GetDevicesPagedAsync(skipCount,
                                                                   maxResultCount,
                                                                   sorting,
                                                                   filter,
                                                                   status,
                                                                   deviceType);

            return (totalCount, result);
        }

        public async Task<Entities.Device> GetDeviceByIdAsync(Guid id)
        {
            return await _devicesRepository.GetDeviceByIdAsync(id);
        }

        public async Task<int> CountDevicesAsync(string filter,
                                                 int? status,
                                                 int? deviceType)
        {
            return await _devicesRepository.CountDevicesAsync(filter, status, deviceType);
        }

        public async Task<int> CountAllDevicesAsync()
        {
            return await _devicesRepository.CountAllDevicesAsync();
        }

        public async Task<IEnumerable<Entities.Device>> GetMostUsedDevices(int take)
        {
            return await _devicesRepository.GetMostUsedDevices(take);
        }
    }
}
