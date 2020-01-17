using Microsoft.EntityFrameworkCore;
using Sispec.Infra.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sispec.Infra.Context
{
    class SispecContext : DbContext
    {
        public DbSet<MPec> Pecs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host = 127.0.0.1; Database = dbsispec; Username = tudeia; Password = 123456");
        
    }
}
