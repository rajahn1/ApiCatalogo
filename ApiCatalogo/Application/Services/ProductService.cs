using ApiCatalogo.Application.Interfaces;
using ApiCatalogo.Domain.Interfaces;
using ApiCatalogo.Domain.Entities;

namespace ApiCatalogo.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            var products = await _productRepository.GetAll();
            return products;
        }

        public async Task<Product> GetById(int id)
        {
            var product = await _productRepository.GetById(id);

            if (product == null) return null;

            return product;
        }
    }
}
