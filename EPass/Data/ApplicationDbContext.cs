using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EPass.Models;

namespace EPass.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<PassLab> Pass { get; set; } = null!;
        public DbSet<Equipment> Equipments { get; set; } = null!;
        public DbSet<Responsible> Responsibles { get; set; } = null!;
        public DbSet<Furniture> Furnitures { get; set; } = null!;
        public ApplicationDbContext()
        {
            
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data source=Epass.db");
            }
        }
       
    }
}
