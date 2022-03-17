using System;
using System.Collections.Generic;
using System.Text;

namespace Device.Domain
{
    public abstract class Entity
    {
        public Guid Id { get; set; }

        public DateTime CreationTime { get; set; }

        public bool IsDeleted { get; set; }

        protected Entity()
        {
            Id = Guid.NewGuid();
        }
    }
}
