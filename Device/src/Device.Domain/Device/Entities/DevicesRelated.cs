using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Device.Domain.Device.Entities
{
    public class DevicesRelated : Entity
    {
        [Required]
        public Guid DeviceId { get; set; }
        public Device Device { get; set; }

        [Required]
        public Guid RelatedDeviceId { get; set; }
        public Device RelatedDevice { get; set; }
    }
}
