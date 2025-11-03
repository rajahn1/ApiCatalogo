using ApiCatalogo.Application.Interfaces;
using ApiCatalogo.Application.Services;
using ApiCatalogo.Domain.Entities;
using ApiCatalogo.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Threading.Tasks;

namespace ApiCatalogo.Api.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class ProductsController(IProductService productService, IProductRepository productRepository) : ControllerBase
{
    private readonly IProductService _productService = productService;
    private readonly IProductRepository _productRepository = productRepository;

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Product>>> GetAll()
    {
        var products = await _productService.GetAll();
        if (products == null) return NotFound("Produtos não encontrados");
        return Ok(products);
    }

    [HttpGet("{id}", Name = "ObterProduto")]
    public async Task<ActionResult<Product>> GetById(int id)
    {
        var product = await _productService.GetById(id);

        if (product == null) return NotFound();

        return Ok(product);
    }

    [HttpPost]
    public async Task<ActionResult<Product>> Post(Product product)
    {
        if (product is null) return BadRequest();
        await _productService.AddAsync(product);
        await _productService.SaveChangesAsync();
        return new CreatedAtRouteResult("ObterProduto", new { id = product.Id });
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<Product>> Put(int id, Product product)
    {
        if (id != product.Id) BadRequest();
        _productRepository.En
        return Ok();
        return NoContent();
    }
}

