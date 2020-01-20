using System;
using System.Collections.Generic;
using System.Text;

namespace Sispec.Domain.Entities
{
    public abstract class BasePalestraEventoCurso : BaseEntity
    {
        public virtual string Tema { get; set; }
        public virtual string Descricao { get; set; }
        public virtual Local Local { get; set; }
        public Pessoa Organizador { get; set; }
    }
} 
