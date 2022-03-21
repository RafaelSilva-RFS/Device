using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Device.Application.Contracts.Devices.Repositories
{
    public interface IDeviceDetailsRepository
    {
        Task<float> CountAllDevicesUsageAsync();
    }
}
