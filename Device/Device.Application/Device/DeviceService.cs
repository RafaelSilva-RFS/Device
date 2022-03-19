using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Device.Application.Contracts;
using Device.Application.Contracts.Devices;
using Device.Application.Contracts.Devices.Dtos;
using Device.Application.Contracts.Devices.Repositories;
using Device.EntityFramework.Devices;

namespace Device.Application.Device
{
    public class DeviceService : IDeviceService
    {
        private IDevicesRepository _devicesRepository { get; set; }

        public DeviceService(IDevicesRepository devicesRepository)
        {
            _devicesRepository = devicesRepository;
        }

        public async Task<PagedResultDto<DeviceDto>> GetDevicesPagedAsync(GetDeviceDto input)
        {
            var (totalCount, result) = await _devicesRepository.GetDevicesPagedAsync(input.SkipCount, input.MaxResultCount, input.Sorting, input.Filter, input.DeviceType);

            var devices = result.Select(x => new DeviceDto()
            {
                Id = x.Id,
                Name = x.Name,
                CreationTime = x.CreationTime,
                Type = x.Type
            }).ToList();

            return new PagedResultDto<DeviceDto>(totalCount, devices);
        }
    }
}
