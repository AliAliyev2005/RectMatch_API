using Microsoft.EntityFrameworkCore;
using RectMatch_API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RectMatch_API.Persistence.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Rectangle> Rectangles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rectangle>()
               .HasIndex(r => r.X1);

                modelBuilder.Entity<Rectangle>()
                    .HasIndex(r => r.Y1);

                modelBuilder.Entity<Rectangle>()
                    .HasIndex(r => r.X2);

                modelBuilder.Entity<Rectangle>()
                    .HasIndex(r => r.Y2);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connStr = "Data Source=HP;Initial Catalog=RectMatchDb;Integrated Security=True;TrustServerCertificate=True";
                optionsBuilder.UseSqlServer(connStr, opt =>
                {
                    opt.EnableRetryOnFailure();
                });
            }
        }
    }
}
