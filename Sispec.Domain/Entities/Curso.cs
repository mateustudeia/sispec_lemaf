using Sispec.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sispec.Domain.Entities
{
    public class Curso : BaseEntity
    {
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public string TempoDuracao { get; set; }
        public string PreRequisitos { get; set; }
        public string FerramentasUtilizadas { get; set; }
        public int IdPessoa { get; set; }
        public virtual Pessoa Orientador { get; set; }

        public virtual Evento Evento { get; set; }

        public Curso()
        {

        }

        public Curso(CursoModel cursoModel)
        {
            DataInicio = cursoModel.DataInicio;
            DataFim = cursoModel.DataFim;
            TempoDuracao = cursoModel.TempoDuracao;
            PreRequisitos = cursoModel.PreRequisitos;
            FerramentasUtilizadas = cursoModel.FerramentasUtilizadas;
            IdPessoa = cursoModel.Orientador.Id;
        }
    }
}
