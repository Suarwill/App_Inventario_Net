using InventarioApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace InventarioApp.Infrastructure.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    public DbSet<Producto> Productos => Set<Producto>();
}
