using Desafio02Library.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio02Library
{
    public class DevContext : DbContext
    {
        public DbSet<Squad> Squads { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\;Initial Catalog=Desafio;Persist Security Info=True;User ID=sa;Password=sqladmin;MultipleActiveResultSets=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Squad>().ToTable("Squads");
        }
    }


}
