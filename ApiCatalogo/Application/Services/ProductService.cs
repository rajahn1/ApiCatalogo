using ApiCatalogo.Application.Interfaces;
using ApiCatalogo.Domain.Interfaces;
using ApiCatalogo.Domain.Entities;
using Microsoft.AspNetCore.Http.HttpResults;

namespace ApiCatalogo.Application.Services
{
    public class ProductService(IProductRepository productRepository) : IProductService
    {
        private readonly IProductRepository _productRepository = productRepository;

        public async Task AddAsync(Product product)
        {
            await _productRepository.AddAsync(product);
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            var products = await _productRepository.GetAll();
            return products;
        }

        public async Task<Product> GetById(int id)
        {
            var product = await _productRepository.GetById(id);
            return product;
        }

        public async Task SaveChangesAsync()
        {
            await _productRepository.SaveChangesAsync();
        }
        
    }
}
