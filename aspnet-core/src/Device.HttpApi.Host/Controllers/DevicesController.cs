using Device.Application.Contracts;
using Device.Application.Contracts.Devices;
using Device.Application.Contracts.Devices.Dtos;
using Device.Application.Device;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Device.HttpApi.Host.Controllers
{
    [EnableCors("CorsApi")]
    [Route("api/v1/")]
    [ApiController]
    public class DevicesController : ControllerBase
    {
        private readonly IDeviceService _deviceService;
        private readonly IDeviceDetailService _deviceDetailService;

        public DevicesController(IDeviceService deviceService,
                                 IDeviceDetailService deviceDetailService)
        {
            _deviceService = deviceService;
            _deviceDetailService = deviceDetailService;
        }

        [HttpGet]
        [Route("get-devices-paged-async")]
        public async Task<PagedResultDto<DeviceDto>> GetDevicesPagedAsync(string filter,
                                                                          string sorting,                                                         
                                                                          int? status,
                                                                          int? deviceType,
                                                                          int pageNumber = 1,
                                                                          int maxResultCount = 5)
        { 

            var input = new GetDeviceDto()
            {
                Filter = filter,
                DeviceType = deviceType,
                Status = status,
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

        [HttpGet]
        [Route("count-all-devices-usage-async")]
        public async Task<float> CountAllDevicesUsageAsync()
        {
            return await _deviceDetailService.CountAllDevicesUsageAsync();
        }
    }
}
