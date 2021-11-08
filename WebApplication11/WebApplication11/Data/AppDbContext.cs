using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication11.Data
{
    public class AppDbContext : DbContext
    {
        public  AppDbContext (DbContextOptions<AppDbContext> options ) : base(options)
        {

        }

        public DbSet <produto> produtos { get; set; }
            
            protected override void OnModelCreating(ModelBuilder modelbuilder)
            {
            modelbuilder.Entity<produto>()
                .Property(p => p.Nome)
                    .HasMaxLength(80);

            modelbuilder.Entity<produto>()
                .Property(p => p.Preco)
                    .HasPrecision(10,2);



            modelbuilder.Entity<produto>()
                .HasData(
                    new produto { Id = 1, Nome = "Iphone XR", Estoque = 10, Preco = 2500 },
                    new produto { Id = 2, Nome = "Iphone 13", Estoque = 5, Preco = 9500 },
                    new produto { Id = 3, Nome = "ASUS Rog Phone 5", Estoque = 8, Preco = 5500 }                   
                );
            }
    }
}
