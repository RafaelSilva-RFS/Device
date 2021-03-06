using System;
using System.Collections.Generic;
using System.Text;

namespace Device.Application.Contracts.Devices.Dtos
{
    public class GetDeviceDto : PagedAndSortedResultRequestDto
    {
        public int? Status { get; set; }
        public int? DeviceType { get; set; }
    }
}
