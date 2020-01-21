using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sispec.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sispec.Infra.Mapping
{
    public class EventoMap : IEntityTypeConfiguration<Evento>
    {
        public void Configure(EntityTypeBuilder<Evento> builder)
        {
            builder.ToTable("Evento");
            builder.HasKey(e => e.Id);
            builder.Property(c => c.Id)
                .HasColumnName("id");
            builder.HasOne(e => e.Local)
                .WithMany(l => l.Evento)
                .HasForeignKey(e => e.IdLocal);
        }
    }
}
