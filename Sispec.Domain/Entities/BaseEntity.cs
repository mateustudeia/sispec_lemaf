using System;
using System.Collections.Generic;
using System.Text;

namespace Sispec.Domain.Entities
{
    public  abstract class BaseEntity
    {
        public virtual int id { get; set; }
    }
}
