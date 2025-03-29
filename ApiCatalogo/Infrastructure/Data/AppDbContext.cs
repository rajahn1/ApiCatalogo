using ApiCatalogo.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiCatalogo.Infrastructure.Context;

public class AppDbContext: DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base( options )
    {}
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
}
