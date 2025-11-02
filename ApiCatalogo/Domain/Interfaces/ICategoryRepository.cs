using ApiCatalogo.Domain.Entities;

namespace ApiCatalogo.Domain.Interfaces
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAll();
        Task<Category> GetById(int id);
        Task AddAsync(Category category);
        Task SaveChangesAsync();
    }
}
