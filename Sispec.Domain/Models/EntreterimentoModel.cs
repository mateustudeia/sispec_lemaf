using Sispec.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sispec.Domain.Models
{
    public class EntreterimentoModel
    {
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public PessoaModel Organizador { get; set; }

        public EntreterimentoModel(Entreterimento entreterimento)
        {
            DataInicio = entreterimento.DataInicio;
            DataFim = entreterimento.DataFim;
            Organizador = new PessoaModel(entreterimento.Organizador);
        } 
    }
}
