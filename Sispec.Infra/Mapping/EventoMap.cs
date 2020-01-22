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
            //builder.ToTable("Evento");

            builder.HasKey(e => e.IdEvento);
            builder.Property(e => e.IdEvento)
                .HasColumnName("EventoId"); ;

            builder.HasOne(e => e.Local)
                .WithMany(l => l.Evento)
                .HasForeignKey(e => e.IdLocal);

            builder.Property(e => e.TipoEvento)
                .HasColumnName("Tipo")
                .IsRequired();
        }
    }
}
