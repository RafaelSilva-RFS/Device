using Device.Application.Contracts.Devices.Repositories;
using Device.DomainShared.Device.Enums;
using Device.EntityFramework.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;
using DeviceDomain = Device.Domain.Device.Entities;

namespace Device.EntityFramework.Devices
{
    public class DevicesRepository : IDevicesRepository
    {
        private DeviceDbContext _deviceDbContext { get; set; }

        public DevicesRepository(DeviceDbContext DeviceDbContext)
        {
            _deviceDbContext = DeviceDbContext;
        }

        public async Task<(int, List<DeviceDomain.Device>)> GetDevicesPagedAsync(int skipCount,
                                                                          int maxResultCount,
                                                                          string sorting,
                                                                          string filter,
                                                                          int? status,
                                                                          int? deviceType)
        {
            var result = await _deviceDbContext.Devices
                        .WhereIf(!String.IsNullOrEmpty(filter), x => x.Name.Contains(filter))
                        .WhereIf(deviceType != null, x => x.Type == (DeviceType)deviceType)
                        .WhereIf(status != null, x => x.Status == (DeviceStatus)status)
                        .Where(x => !x.IsDeleted)
                        .OrderBy(String.IsNullOrEmpty(sorting) ? "CreationTime Asc" : sorting)
                        .Skip(skipCount)
                        .Take(maxResultCount)
                        .ToListAsync();

            var totalCount = await _deviceDbContext.Devices
                            .Where(x => x.Name.Contains((!String.IsNullOrEmpty(filter) ? filter : "")) && !x.IsDeleted)
                            .WhereIf(status != null, x => x.Status == (DeviceStatus)status)
                            .CountAsync();

            return (totalCount, result);
        }

        public async Task<DeviceDomain.Device> GetDeviceByIdAsync(Guid id)
        {
            return await _deviceDbContext.Devices
                        .Where(x => x.Id == id && !x.IsDeleted)
                        .Include(x => x.DeviceDetails)
                        .FirstOrDefaultAsync();
        }

        public async Task<int> CountDevicesAsync(string filter,
                                                 int? status,
                                                 int? deviceType)
        {
            return await _deviceDbContext.Devices
                        .WhereIf(!String.IsNullOrEmpty(filter), x => x.Name.Contains(filter))
                        .WhereIf(deviceType != null, x => x.Type == (DeviceType)deviceType)
                        .WhereIf(status != null, x => x.Status == (DeviceStatus)status)
                        .Where(x => !x.IsDeleted).CountAsync();
        }

        public async Task<int> CountAllDevicesAsync()
        {
            return await _deviceDbContext.Devices.Where(x => !x.IsDeleted).CountAsync();
        }
    }
}
