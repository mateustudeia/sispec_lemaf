using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sispec.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sispec.Infra.Mapping
{
    public class PalestraMap : IEntityTypeConfiguration<Palestra>
    {
        public void Configure(EntityTypeBuilder<Palestra> builder)
        {
            builder.ToTable("palestra");
            builder.HasKey(pa => pa.Id);

            builder.Property(pa => pa.Id)
                .HasColumnName("palestra_id");

            builder.HasOne(p => p.Evento)
                .WithOne(e => e.Palestra)
                .HasForeignKey<Palestra>(p => p.Id);

            builder.HasOne(pa => pa.Palestrante)
                .WithMany(pe => pe.Palestra)
                .HasForeignKey(pa => pa.IdPessoa);
        }
    }
}
