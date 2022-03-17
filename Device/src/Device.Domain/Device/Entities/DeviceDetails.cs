using Device.DomainShared.Device.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Device.Domain.Device.Entities
{
    public class DeviceDetails : Entity
    {
        public float Temperature { get; set; }
        public float Usage { get; set; }
        public DeviceStatus Status { get; set; }
    }
}
