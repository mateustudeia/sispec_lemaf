using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sispec.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sispec.Infra.Mapping
{
    public class InscritoEventoMap : IEntityTypeConfiguration<InscritoEvento>
    {
        public void Configure(EntityTypeBuilder<InscritoEvento> builder)
        {
            builder.HasKey(ie => new { ie.IdPessoa, ie.IdEvento });
            builder.HasOne(ie => ie.Pessoa)
                .WithMany(i => i.Inscritos)
                .HasForeignKey(ie => ie.IdPessoa);
            builder.HasOne(ie => ie.Evento)
                .WithMany(e => e.Inscritos)
                .HasForeignKey(ie => ie.IdEvento);
        }
    }
}
