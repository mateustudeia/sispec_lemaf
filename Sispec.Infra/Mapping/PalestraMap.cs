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
            builder.ToTable("Palestra");
            builder.HasKey(p => p.Id);
            builder.Property(c => c.Id)
                .HasColumnName("Id");
            builder.HasOne(pa => pa.Palestrante)
                .WithMany(pe => pe.Palestra)
                .HasForeignKey(pa => pa.IdPessoa);
        }
    }
}
