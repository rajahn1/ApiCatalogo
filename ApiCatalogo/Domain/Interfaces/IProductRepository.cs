using ApiCatalogo.Domain.Entities;

namespace ApiCatalogo.Domain.Interfaces;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetAll();
    Task<Product> GetById(int id);
}
