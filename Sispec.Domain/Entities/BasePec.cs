using System;
using System.Collections.Generic;
using System.Text;

namespace Sispec.Domain.Entities
{
    public abstract class BasePec : BaseEntity
    {
        public virtual string Tema { get; set; }
        public virtual string Descricao { get; set; }
        public virtual Local Local { get; set; }
        public virtual Inscritos Inscritos { get; set; }
    }
} 
