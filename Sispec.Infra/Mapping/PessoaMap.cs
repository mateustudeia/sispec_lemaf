using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sispec.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sispec.Infra.Mapping
{
    public class PessoaMap : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.ToTable("Pessoa");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Cpf)
                .IsRequired()
                .HasColumnName("cpf");
            builder.Property(c => c.Contato)
                .IsRequired()
                .HasColumnName("contato");
            builder.Property(c => c.Email)
                .IsRequired()
                .HasColumnName("email");
            builder.Property(c => c.DataNascimento)
                .IsRequired()
                .HasColumnName("data_nascimento");
        }
    }
}
