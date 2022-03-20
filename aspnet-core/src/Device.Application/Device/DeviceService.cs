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
            var (totalCount, result) = await _devicesRepository.GetDevicesPagedAsync(input.SkipCount, 
                                                                                     input.MaxResultCount, 
                                                                                     input.Sorting, 
                                                                                     input.Filter,
                                                                                     input.Status, 
                                                                                     input.DeviceType);

            var devices = result.Select(x => new DeviceDto()
            {
                Id = x.Id,
                Name = x.Name,
                CreationTime = x.CreationTime,
                Type = x.Type,
                Status = x.Status
            }).ToList();

            return new PagedResultDto<DeviceDto>(totalCount, devices);
        }

        public async Task<DeviceDto> GetDeviceByIdAsync(Guid id)
        {
            var result = await _devicesRepository.GetDeviceByIdAsync(id);

            return new DeviceDto()
            {
                Id = result.Id,
                Name = result.Name,
                CreationTime = result.CreationTime,
                Type = result.Type,
                Status = result.Status,
                DeviceDetail = result.DeviceDetails.Select(x => new DeviceDetailDto
                {
                    DeviceId = result.Id,
                    Temperature = x.Temperature,
                    Usage = x.Usage,
                    CreationTime = x.CreationTime
                }).ToList()
            };
        }

        public async Task<int> CountDevicesAsync(string filter,
                                                 int? status,
                                                 int? deviceType)
        {
            return await _devicesRepository.CountDevicesAsync(filter, status, deviceType);
        }

        public async Task<int> CountAllDevicesAsync()
        {
            return await _devicesRepository.CountAllDevicesAsync();
        }
    }
}
