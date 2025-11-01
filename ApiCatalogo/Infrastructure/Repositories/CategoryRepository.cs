using ApiCatalogo.Domain.Interfaces;
using ApiCatalogo.Domain.Entities;
using ApiCatalogo.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;


namespace ApiCatalogo.Infrastructure.Repositories;

public class CategoryRepository(AppDbContext context) : ICategoryRepository
{
  private readonly AppDbContext _context = context;

  public async Task<IEnumerable<Category>> GetAll()
  {
    return await _context.Categories.ToListAsync();
  }

  public async Task<Category> GetById(int id)
  {
    return await _context.Categories.FindAsync(id);
  }

    public async Task AddAsync(Category category)
    {
        await _context.Categories.AddAsync(category);
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
}
