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
                .HasDefaultSchema("sisEpec")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Sispec.Domain.Entities.Curso", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("curso_id");

                    b.Property<DateTime>("DataFim");

                    b.Property<DateTime>("DataInicio");

                    b.Property<string>("FerramentasUtilizadas");

                    b.Property<int>("Orientador");

                    b.Property<string>("PreRequisitos");

                    b.Property<string>("TempoDuracao");

                    b.HasKey("Id");

                    b.HasIndex("Orientador");

                    b.ToTable("curso");
                });

            modelBuilder.Entity("Sispec.Domain.Entities.Entreterimento", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("id_entreterimento");

                    b.Property<DateTime>("DataFim");

                    b.Property<DateTime>("DataInicio");

                    b.Property<int>("Organizador");

                    b.HasKey("Id");

                    b.HasIndex("Organizador");

                    b.ToTable("entreterimento");
                });

            modelBuilder.Entity("Sispec.Domain.Entities.Evento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id_evento");

                    b.Property<string>("Descricao");

                    b.Property<int>("IdLocal");

                    b.Property<int>("IdTipo");

                    b.Property<string>("Tema");

                    b.HasKey("Id");

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
                    b.Property<int>("Id")
                        .HasColumnName("palestra_id");

                    b.Property<DateTime>("Data");

                    b.Property<int>("Palestrante");

                    b.Property<DateTime>("tempoDuracao");

                    b.HasKey("Id");

                    b.HasIndex("Palestrante");

                    b.ToTable("palestra");
                });

            modelBuilder.Entity("Sispec.Domain.Entities.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Contato")
                        .HasColumnName("contato");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnName("cpf");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnName("data_nascimento");

                    b.Property<string>("Email")
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
                        .HasForeignKey("Sispec.Domain.Entities.Curso", "Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Sispec.Domain.Entities.Pessoa", "Pessoa")
                        .WithMany("Curso")
                        .HasForeignKey("Orientador")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Sispec.Domain.Entities.Entreterimento", b =>
                {
                    b.HasOne("Sispec.Domain.Entities.Evento", "Evento")
                        .WithOne("Entreterimento")
                        .HasForeignKey("Sispec.Domain.Entities.Entreterimento", "Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Sispec.Domain.Entities.Pessoa", "Pessoa")
                        .WithMany("Entreterimento")
                        .HasForeignKey("Organizador")
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
                        .HasForeignKey("Sispec.Domain.Entities.Palestra", "Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Sispec.Domain.Entities.Pessoa", "Pessoa")
                        .WithMany("Palestra")
                        .HasForeignKey("Palestrante")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
