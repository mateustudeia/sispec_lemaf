﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Sispec.Infra.Context;

namespace Sispec.Infra.Migrations
{
    [DbContext(typeof(SispecContext))]
    partial class SispecContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("sispec")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Sispec.Domain.Entities.Curso", b =>
                {
                    b.Property<int>("EventoId")
                        .HasColumnName("curso_id");

                    b.Property<DateTime>("DataFim");

                    b.Property<DateTime>("DataInicio");

                    b.Property<string>("FerramentasUtilizadas");

                    b.Property<int>("IdPessoa");

                    b.Property<string>("PreRequisitos");

                    b.Property<DateTime>("TempoDuracao");

                    b.HasKey("EventoId");

                    b.HasIndex("IdPessoa");

                    b.ToTable("curso");
                });

            modelBuilder.Entity("Sispec.Domain.Entities.Entreterimento", b =>
                {
                    b.Property<int>("EventoId")
                        .HasColumnName("id_entreterimento");

                    b.Property<DateTime>("DataFim");

                    b.Property<DateTime>("DataInicio");

                    b.Property<int>("IdPessoa");

                    b.HasKey("EventoId");

                    b.HasIndex("IdPessoa");

                    b.ToTable("entreterimento");
                });

            modelBuilder.Entity("Sispec.Domain.Entities.Evento", b =>
                {
                    b.Property<int>("IdEvento")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id_evento");

                    b.Property<string>("Descricao");

                    b.Property<int>("IdLocal");

                    b.Property<int>("IdTipo");

                    b.Property<string>("Tema");

                    b.HasKey("IdEvento");

                    b.HasIndex("IdLocal");

                    b.HasIndex("IdTipo");

                    b.ToTable("evento");
                });

            modelBuilder.Entity("Sispec.Domain.Entities.InscritoEvento", b =>
                {
                    b.Property<int>("IdPessoa");

                    b.Property<int>("IdEvento");

                    b.HasKey("IdPessoa", "IdEvento");

                    b.HasIndex("IdEvento");

                    b.ToTable("inscrito_evento");
                });

            modelBuilder.Entity("Sispec.Domain.Entities.Local", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Capacidade");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("local");
                });

            modelBuilder.Entity("Sispec.Domain.Entities.Palestra", b =>
                {
                    b.Property<int>("EventoId")
                        .HasColumnName("palestra_id");

                    b.Property<DateTime>("Data");

                    b.Property<int>("IdPessoa");

                    b.Property<DateTime>("tempoDuracao");

                    b.HasKey("EventoId");

                    b.HasIndex("IdPessoa");

                    b.ToTable("pelestra");
                });

            modelBuilder.Entity("Sispec.Domain.Entities.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Contato")
                        .IsRequired()
                        .HasColumnName("contato");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnName("cpf");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnName("data_nascimento");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.ToTable("pessoa");
                });

            modelBuilder.Entity("Sispec.Domain.Entities.TipoEvento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DescricaoTipo");

                    b.HasKey("Id");

                    b.ToTable("tipo_evento");
                });

            modelBuilder.Entity("Sispec.Domain.Entities.Curso", b =>
                {
                    b.HasOne("Sispec.Domain.Entities.Evento", "Evento")
                        .WithOne("Curso")
                        .HasForeignKey("Sispec.Domain.Entities.Curso", "EventoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Sispec.Domain.Entities.Pessoa", "Orientador")
                        .WithMany("Curso")
                        .HasForeignKey("IdPessoa")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Sispec.Domain.Entities.Entreterimento", b =>
                {
                    b.HasOne("Sispec.Domain.Entities.Evento", "Evento")
                        .WithOne("Entreterimento")
                        .HasForeignKey("Sispec.Domain.Entities.Entreterimento", "EventoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Sispec.Domain.Entities.Pessoa", "Organizador")
                        .WithMany("Entreterimento")
                        .HasForeignKey("IdPessoa")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Sispec.Domain.Entities.Evento", b =>
                {
                    b.HasOne("Sispec.Domain.Entities.Local", "Local")
                        .WithMany("Evento")
                        .HasForeignKey("IdLocal")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Sispec.Domain.Entities.TipoEvento", "TipoEvento")
                        .WithMany("Evento")
                        .HasForeignKey("IdTipo")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Sispec.Domain.Entities.InscritoEvento", b =>
                {
                    b.HasOne("Sispec.Domain.Entities.Evento", "Evento")
                        .WithMany("Inscritos")
                        .HasForeignKey("IdEvento")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Sispec.Domain.Entities.Pessoa", "Pessoa")
                        .WithMany("Inscritos")
                        .HasForeignKey("IdPessoa")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Sispec.Domain.Entities.Palestra", b =>
                {
                    b.HasOne("Sispec.Domain.Entities.Evento", "Evento")
                        .WithOne("Palestra")
                        .HasForeignKey("Sispec.Domain.Entities.Palestra", "EventoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Sispec.Domain.Entities.Pessoa", "Palestrante")
                        .WithMany("Palestra")
                        .HasForeignKey("IdPessoa")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
