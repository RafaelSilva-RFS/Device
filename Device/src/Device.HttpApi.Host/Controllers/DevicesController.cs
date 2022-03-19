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
    [Route("api/[controller]")]
    [ApiController]
    public class DevicesController : ControllerBase
    {
        private readonly IDeviceService _deviceService;

        public DevicesController(IDeviceService deviceService)
        {
            _deviceService = deviceService;
        }


        [HttpGet]
        public async Task<PagedResultDto<DeviceDto>> Get(string filter,
                                                         string sorting,                                                         
                                                         int? deviceType,
                                                         int pageNumber = 1,
                                                         int maxResultCount = 5)
        {
            var input = new GetDeviceDto()
            {
                Filter = filter,
                DeviceType = deviceType,
                MaxResultCount = maxResultCount,
                Sorting = sorting,
                PageNumber = pageNumber
            };

            return await _deviceService.GetDevicesPagedAsync(input);         
        }
    }
}
