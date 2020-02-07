using Sispec.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sispec.Domain.Models
{
    public class CursoModel
    {
        public int Id { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public string TempoDuracao { get; set; }
        public string PreRequisitos { get; set; }
        public string FerramentasUtilizadas { get; set; }
        public PessoaModel Orientador { get; set; }

        public CursoModel(Curso curso)
        {
            Id = curso.Id;
            DataInicio = curso.DataInicio;
            DataFim = curso.DataFim;
            TempoDuracao = curso.TempoDuracao;
            PreRequisitos = curso.PreRequisitos;
            FerramentasUtilizadas = curso.FerramentasUtilizadas;
            Orientador = new PessoaModel(curso.Orientador);
        }

        public CursoModel(EventoModel evento) 
        {

        }
        public CursoModel()
        {

        }
    }
}
