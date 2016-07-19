using Corp.FARBE.Tasks.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Corp.FARBE.Tasks.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Musteri> Musteriler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(typeof(DatabaseContext).Assembly);
        }
    }
}