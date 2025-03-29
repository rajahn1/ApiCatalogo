using ApiCatalogo.Domain.Entities;

namespace ApiCatalogo.Application.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAll();
        Task<Product> GetById(int id);
    }
}
