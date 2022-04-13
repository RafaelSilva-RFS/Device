using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Device.Domain.Device.Repositories
{
    public interface IDevicesRepository
    {
        Task<(int, List<Entities.Device>)> GetDevicesPagedAsync(int skipCount,
                                                            int maxResultCount,
                                                            string sorting,
                                                            string filter,
                                                            int? status,
                                                            int? deviceType);

        Task<Entities.Device> GetDeviceByIdAsync(Guid id);

        Task<int> CountDevicesAsync(string filter, int? status, int? deviceType);

        Task<int> CountAllDevicesAsync();

        Task<IEnumerable<Entities.Device>> GetMostUsedDevices(int take);
    }
}
