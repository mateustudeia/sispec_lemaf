using Microsoft.EntityFrameworkCore;
using Sispec.Domain.Entities;
using Sispec.Infra.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sispec.Infra.Context
{
    public class SispecContext : DbContext
    {
        public DbSet<Evento> Evento { get; set; }
        public DbSet<Palestra> Palestra { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Entreterimento> Entreterimento { get; set; }
        public virtual DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Local> Local { get; set; }
        public DbSet<TipoEvento> TipoEvento { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLazyLoadingProxies()
                .UseNpgsql("Host = localhost; Database = dbsispec; Username = postgres; Password = postgres");
            //=> optionsBuilder.UseNpgsql("Host = localhost; Database = sispec; Username = postgres; Password = postgre");

            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("sisEpec");
            modelBuilder.ApplyConfiguration(new EventoMap()); 
            modelBuilder.ApplyConfiguration(new PalestraMap());
            modelBuilder.ApplyConfiguration(new CursoMap());
            modelBuilder.ApplyConfiguration(new EntreterimentoMap());
            modelBuilder.ApplyConfiguration(new PessoaMap());
            modelBuilder.ApplyConfiguration(new InscritoEventoMap());
            modelBuilder.ApplyConfiguration(new TipoEventoMap());
            modelBuilder.ApplyConfiguration(new LocalMap());

        }





    }
}
