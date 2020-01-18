using Microsoft.EntityFrameworkCore;
using Sispec.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sispec.Infra.Context
{
    class SispecContext : DbContext
    {
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Palestra> Palestras { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Local> Locais { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host = localhost; Database = dbsispec; Username = tudeia; Password = 123456");
        
    }
}
