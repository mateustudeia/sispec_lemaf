using Sispec.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sispec.Domain.Models
{
    public class CursoModel : EventoModel
    {
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public string TempoDuracao { get; set; }
        public string PreRequisitos { get; set; }
        public string FerramentasUtilizadas { get; set; }
        public PessoaModel Orientador { get; set; }

        public CursoModel(Evento evento) : base(evento)
        {
            DataInicio = evento.Curso.DataInicio;
            DataFim = evento.Curso.DataFim;
            TempoDuracao = evento.Curso.TempoDuracao;
            PreRequisitos = evento.Curso.PreRequisitos;
            FerramentasUtilizadas = evento.Curso.FerramentasUtilizadas;
            Orientador = new PessoaModel(evento.Curso.Pessoa);
        }
    }
}
