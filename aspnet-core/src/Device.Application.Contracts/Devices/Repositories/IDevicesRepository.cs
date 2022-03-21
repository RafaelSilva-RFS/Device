using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DeviceDomain = Device.Domain.Device.Entities;

namespace Device.Application.Contracts.Devices.Repositories
{
    public interface IDevicesRepository
    {
        Task<(int, List<DeviceDomain.Device>)> GetDevicesPagedAsync(int skipCount,
                                                            int maxResultCount,
                                                            string sorting,
                                                            string filter,
                                                            int? status,
                                                            int? deviceType);

        Task<DeviceDomain.Device> GetDeviceByIdAsync(Guid id);

        Task<int> CountDevicesAsync(string filter, int? status, int? deviceType);

        Task<int> CountAllDevicesAsync();
    }
}
