using Device.DomainShared.Device.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Device.Domain.Device.Entities
{
    public class Device : Entity
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public DeviceType Type { get; set; }
    }
}
