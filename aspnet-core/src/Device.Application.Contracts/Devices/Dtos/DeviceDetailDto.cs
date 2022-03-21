using System;
using System.Collections.Generic;
using System.Text;

namespace Device.Application.Contracts.Devices.Dtos
{
    public class DeviceDetailDto
    {
        public Guid DeviceId { get; set; }
        public float Temperature { get; set; }
        public float Usage { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
