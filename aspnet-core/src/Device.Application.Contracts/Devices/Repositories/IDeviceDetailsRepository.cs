using Device.Application.Contracts.Devices.Dtos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Device.Application.Contracts.Devices.Repositories
{
    public interface IDeviceDetailsRepository
    {
        Task<IEnumerable<GetMostUsedDevicesDto>> GetMostUsedDevices(int take);

        Task<float> CountAllDevicesUsageAsync();
    }
}
