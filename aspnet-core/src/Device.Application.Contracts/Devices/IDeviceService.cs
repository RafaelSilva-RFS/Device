using Device.Application.Contracts.Devices.Dtos;
using System;
using System.Threading.Tasks;

namespace Device.Application.Contracts.Devices
{
    public interface IDeviceService
    {
        Task<PagedResultDto<DeviceDto>> GetDevicesPagedAsync(GetDeviceDto input);

        Task<DeviceDto> GetDeviceByIdAsync(Guid id);

        Task<int> CountDevicesAsync(string filter, int? status, int? deviceType);

        Task<int> CountAllDevicesAsync();
    }
}
