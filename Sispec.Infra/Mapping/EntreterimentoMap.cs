using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sispec.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sispec.Infra.Mapping
{
    public class EntreterimentoMap : IEntityTypeConfiguration<Entreterimento>
    {
        public void Configure(EntityTypeBuilder<Entreterimento> builder)
        {
            builder.HasOne(e => e.Organizador)
                .WithMany(pe => pe.Entreterimento)
                .HasForeignKey(e => e.IdPessoa);
        }
    }
}
