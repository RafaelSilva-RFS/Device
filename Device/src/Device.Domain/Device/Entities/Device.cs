using Device.DomainShared.Device.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Device.Domain.Device.Entities
{
    [Table("Devices")]
    public class Device : Entity
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public DeviceType Type { get; set; }
    }
}
