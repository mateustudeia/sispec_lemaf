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
            builder.ToTable("Curso");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id)
                .HasColumnName("id");
            builder.HasOne(c => c.Orientador)
                .WithMany(pe => pe.Curso)
                .HasForeignKey(c => c.IdPessoa);
        }
    }
}
