using ApiCatalogo.Application.Interfaces;
using ApiCatalogo.Domain.Entities;
using ApiCatalogo.Domain.Interfaces;

namespace ApiCatalogo.Application.Services
{
    public class CategoryService(ICategoryRepository categoryRepository) : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository = categoryRepository;

        public async Task AddAsync(Category category)
        {
            await _categoryRepository.AddAsync(category);
        }

        public async Task<IEnumerable<Category>> GetAll()
        {
            var categories = await _categoryRepository.GetAll();
            return categories;
        }

        public async Task<Category> GetById(int id)
        {
            var category = await _categoryRepository.GetById(id);
            return category;
        }

        public async Task SaveChangesAsync()
        {
            await _categoryRepository.SaveChangesAsync();
        }
    }
}
