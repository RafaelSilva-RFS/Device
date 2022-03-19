using Device.DomainShared.Device.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Device.Application.Contracts.Devices.Dtos
{
    public class DeviceDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public DeviceType Type { get; set; }        

        public DateTime CreationTime { get; set; }
    }
}
