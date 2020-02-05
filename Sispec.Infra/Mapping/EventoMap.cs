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
            builder.ToTable("evento");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id)
                .HasColumnName("id_evento");

            builder.HasOne(e => e.Local)
                .WithMany(l => l.Evento)
                .HasForeignKey(e => e.IdLocal);


            builder.HasOne(e => e.TipoEvento)
                .WithMany(te => te.Evento)
                .HasForeignKey(e => e.IdTipo);

           // builder.Property(e => e.TipoEvento)
              //  .IsRequired();

        }
    }
}
