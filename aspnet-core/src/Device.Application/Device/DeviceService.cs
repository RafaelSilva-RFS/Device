using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Device.Application.Contracts;
using Device.Application.Contracts.Devices;
using Device.Application.Contracts.Devices.Dtos;
using Device.Domain.Device.Interfaces;

namespace Device.Application.Device
{
    public class DeviceService : IDeviceService
    {
        private IDeviceManager _devicesManager { get; set; }

        public DeviceService(IDeviceManager devicesManager)
        {
            _devicesManager = devicesManager;
        }

        public async Task<PagedResultDto<DeviceDto>> GetDevicesPagedAsync(GetDeviceDto input)
        {
            var (totalCount, result) = await _devicesManager.GetDevicesPagedAsync(input.SkipCount,
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
            var result = await _devicesManager.GetDeviceByIdAsync(id);

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
            return await _devicesManager.CountDevicesAsync(filter, status, deviceType);
        }

        public async Task<int> CountAllDevicesAsync()
        {
            return await _devicesManager.CountAllDevicesAsync();
        }


        public async Task<List<DeviceDto>> GetMostUsedDevices(int take)
        {
            var result = await _devicesManager.GetMostUsedDevices(take);
            
            return result.Select(x => new DeviceDto()
            {
                Id = x.Id,
                Name = x.Name,
                CreationTime = x.CreationTime,
                Type = x.Type,
                Status = x.Status
            }).ToList();
        }
    }
}
