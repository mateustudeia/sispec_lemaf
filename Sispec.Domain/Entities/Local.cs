using System;
using System.Collections.Generic;
using System.Text;

namespace Sispec.Domain.Entities
{
    public class Local : BaseEntity
    {
        public string Nome { get; set; }
        public int Capacidade { get; set; }

    }
}
