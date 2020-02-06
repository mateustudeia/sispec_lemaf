using Sispec.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sispec.Domain.Models
{
    public class LocalModel
    {
        public string Nome { get; set; }
        public int Capacidade { get; set; }

        public LocalModel(Local local)
        {
            Nome = local.Nome;
            Capacidade = local.Capacidade;
        }
    }
}
