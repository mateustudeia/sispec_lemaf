using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sispec.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sispec.Infra.Mapping
{
    public class TipoEventoMap : IEntityTypeConfiguration<TipoEvento>
    {
        public void Configure(EntityTypeBuilder<TipoEvento> builder)
        {
            builder.ToTable("tipo_evento");
        }
    }
}
