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
                                                            int? deviceType);

        Task<int> CountAllDevicesAsync();
    }
}
