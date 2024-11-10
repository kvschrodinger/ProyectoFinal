using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Models;

namespace ProyectoFinal.Models
{
    
        public class MyDbContext : DbContext
        {
            public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
            public DbSet<Cliente> Clientes { get; set; }
            public DbSet<Pelicula> Peliculas { get; set; }
            public DbSet<Alquiler> Alquileres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);
                modelBuilder.Entity<Cliente>().HasKey(cliente => cliente.IdCliente);
                modelBuilder.Entity<Pelicula>().HasKey(pelicula => pelicula.IdPelicula);
                modelBuilder.Entity<Alquiler>().HasKey(alquiler => alquiler.IdAlquiler);

        }
    

        }
    }

    