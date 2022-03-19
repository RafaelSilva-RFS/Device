using Device.Application.Contracts;
using Device.Application.Contracts.Devices;
using Device.Application.Contracts.Devices.Dtos;
using Device.Application.Device;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Device.HttpApi.Host.Controllers
{
    [Route("api/v1/devices")]
    [ApiController]
    public class DevicesController : ControllerBase
    {
        private readonly IDeviceService _deviceService;

        public DevicesController(IDeviceService deviceService)
        {
            _deviceService = deviceService;
        }

        [HttpGet]
        [Route("get-devices-paged-async")]
        public async Task<PagedResultDto<DeviceDto>> GetDevicesPagedAsync(string filter,
                                                                          string sorting,                                                         
                                                                          int? deviceType,
                                                                          int pageNumber = 1,
                                                                          int maxResultCount = 5)
        { 

            var input = new GetDeviceDto()
            {
                Filter = filter,
                DeviceType = deviceType,
                MaxResultCount = maxResultCount < 1 ? 1 : maxResultCount,
                Sorting = !String.IsNullOrEmpty(sorting) ? sorting : "CreationTime Asc",
                PageNumber = pageNumber < 1 ? 1 : pageNumber
            };

            return await _deviceService.GetDevicesPagedAsync(input);         
        }

        [HttpGet]
        [Route("count-all-devices-async")]
        public async Task<int> CountAllDevicesAsync()
        {
            return await _deviceService.CountAllDevicesAsync();
        }
    }
}
