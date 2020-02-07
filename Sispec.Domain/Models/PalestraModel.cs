using Sispec.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sispec.Domain.Models
{
    public class PalestraModel
    {
        public DateTime Data { get; set; }
        public string TempoDuracao { get; set; }
        public PessoaModel Palestrante { get; set; }

        public PalestraModel()
        {

        }

        public PalestraModel(Palestra palestra)
        {
            Data = palestra.Data;
            TempoDuracao = palestra.TempoDuracao;
            Palestrante = new PessoaModel(palestra.Palestrante);
        }

    }
}
