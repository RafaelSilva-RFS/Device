using System;
using System.Collections.Generic;
using System.Text;

namespace Device.Application.Contracts.Devices.Dtos
{
    public class GetMostUsedDevicesDto
    {
        public Guid DeviceId { get; set; }
        public float TotalUsage { get; set; }
    }
}
