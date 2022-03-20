using Device.DomainShared.Device.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Device.Domain.Device.Entities
{
    [Table("DeviceDetails")]
    public class DeviceDetails : Entity
    {
        public Guid DeviceId { get; set; }
        public Device Device { get; set; }

        public float Temperature { get; set; }
        public float Usage { get; set; }     
    }
}
