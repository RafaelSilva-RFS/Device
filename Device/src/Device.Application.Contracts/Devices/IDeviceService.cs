using Device.Application.Contracts.Devices.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Device.Application.Contracts.Devices
{
    public interface IDeviceService
    {
        Task<PagedResultDto<DeviceDto>> GetDevicesPagedAsync(GetDeviceDto input);
    }
}
