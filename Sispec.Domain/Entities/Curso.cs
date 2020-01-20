﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sispec.Domain.Entities
{
    public class Curso : BasePalestraEventoCurso 
    {
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public DateTime TempoDuracao { get; set; }
        public string PreRequisitos { get; set; }
        public string FerramentasUtilizadas { get; set; }
        public Pessoa Orientador { get; set; }
        public virtual IList<Pessoa> Inscritos { get; set; }
    }
}
