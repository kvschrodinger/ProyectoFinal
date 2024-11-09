using Microsoft.EntityFrameworkCore;

namespace ProyectoFinal.Models
{
    
        public class MyDbContext : DbContext
        {
            public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
            public DbSet<Cliente> Clientes { get; set; }


            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);
                modelBuilder.Entity<Cliente>().HasKey(cliente => cliente.IdCliente);

            }
        }
    }

    