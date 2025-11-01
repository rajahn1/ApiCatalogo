using ApiCatalogo.Domain.Entities;

namespace ApiCatalogo.Application.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAll();
        Task<Category> GetById(int id);
        Task AddAsync(Category category);
        Task SaveChangesAsync();
    }
}
