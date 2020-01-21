using Microsoft.EntityFrameworkCore;
using Sispec.Domain.Entities;
using Sispec.Infra.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sispec.Infra.Context
{
    class SispecContext : DbContext
    {
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Palestra> Palestras { get; set; }
        public DbSet<Entreterimento> Entreterimentos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Local> Locais { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host = localhost; Database = dbsispec; Username = postgres; Password = postgres");
            //=> optionsBuilder.UseNpgsql("Host = localhost; Database = sispec; Username = postgres; Password = postgre");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasDefaultSchema("sispec");
            modelBuilder.Entity<Pessoa>(new PessoaMap().Configure);
            modelBuilder.Entity<InscritoEvento>(new InscritoEventoMap().Configure);
            modelBuilder.Entity<Evento>(new EventoMap().Configure);
            modelBuilder.Entity<Palestra>(new PalestraMap().Configure);
            modelBuilder.Entity<Curso>(new CursoMap().Configure);
            modelBuilder.Entity<Entreterimento>(new EntreterimentoMap().Configure);
        }





    }
}
