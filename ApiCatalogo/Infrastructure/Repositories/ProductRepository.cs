using ApiCatalogo.Domain.Interfaces;
using ApiCatalogo.Domain.Entities;
using ApiCatalogo.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace ApiCatalogo.Infrastructure.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly AppDbContext _context;

    public ProductRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Product>> GetAll()
    {
        return await _context.Products.ToListAsync();
    }

    public async Task<Product> GetById(int id)
    {
        return await _context.Products.FindAsync(id);
    }
}
