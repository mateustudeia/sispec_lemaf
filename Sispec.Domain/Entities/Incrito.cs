using System;
using System.Collections.Generic;
using System.Text;

namespace Sispec.Domain.Entities
{
    public class Incrito : Pessoa
    {
        public BasePalestraEventoCurso BasePec { get; set; }
    }
}
