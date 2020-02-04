using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sispec.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sispec.Infra.Mapping
{
    public class CursoMap : IEntityTypeConfiguration<Curso>
    {
        public void Configure(EntityTypeBuilder<Curso> builder)
        {
            builder.ToTable("curso");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .HasColumnName("curso_id");

            builder.HasOne(c => c.Evento)
                .WithOne(e => e.Curso)
                .HasForeignKey<Curso>(c => c.Id);

            builder.HasOne(c => c.Pessoa)
                .WithMany(pe => pe.Curso)
                .HasForeignKey(c => c.Orientador);
        }
    }
}
