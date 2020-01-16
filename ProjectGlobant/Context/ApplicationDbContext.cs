using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace ProjectGlobant.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
         => options.UseSqlite("Data Source=ProjectDb.db");

        public DbSet<Item> Items { get; set; }

        public DbSet<PaqueteItem> PaqueteItem { get; set; }
        public DbSet<Paquete> Paquetes { get; set; }
    }
}
