﻿using Sispec.Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sispec.Domain.Entities
{
    public class Evento : BaseEntity
    {
        public string Tema { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public Pessoa Organizador { get; set; }
        public Local Local { get; set; }
        public IList<Pessoa> Inscritos { get; set; }

    }
}
