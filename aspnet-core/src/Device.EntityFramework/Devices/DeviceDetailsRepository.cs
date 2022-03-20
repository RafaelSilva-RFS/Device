using Device.Application.Contracts.Devices.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Device.EntityFramework.Devices
{
    public class DeviceDetailsRepository : IDeviceDetailsRepository
    {
        private DeviceDbContext _deviceDbContext { get; set; }

        public DeviceDetailsRepository(DeviceDbContext DeviceDbContext)
        {
            _deviceDbContext = DeviceDbContext;
        }

        public async Task<float> CountAllDevicesUsageAsync()
        {
            var result = await _deviceDbContext.DeviceDetails
                .Where(x => !x.IsDeleted)
                .Select(x => x.Usage)
                .ToListAsync();

            float devicesUsage = 0;

            foreach(var item in result)
            {
                devicesUsage += item;
            }

            return devicesUsage;
        }
    }
}
