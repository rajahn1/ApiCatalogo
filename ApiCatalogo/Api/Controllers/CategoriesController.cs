using ApiCatalogo.Application.Interfaces;
using ApiCatalogo.Domain.Entities;
using ApiCatalogo.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiCatalogo.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CategoriesController(ICategoryService categoryService) : ControllerBase
    {
        private readonly ICategoryService _categoryService = categoryService;
        // GET: api/<CategoriesController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> GetAll()
        {
            var categories = await _categoryService.GetAll();
            if (categories == null) { 
                return NotFound();
            }
            return Ok(categories);
        }

        // GET api/<CategoriesController>/5
        [HttpGet("{id}", Name="ObterCategoria")]
        public async Task<ActionResult<Category>> Get(int id)
        {
            var category = await _categoryService.GetById(id);
            if (category == null) return NotFound();
           return Ok(category);
        }

        // POST api/<CategoriesController>
        [HttpPost]
        public async Task<ActionResult<Category>> Post(Category category)
        {
            if (category is null) return BadRequest();
            await _categoryService.AddAsync(category);
            await _categoryService.SaveChangesAsync();
            return new CreatedAtRouteResult("ObterCategoria", new { id = category.Id });
        }

        // PUT api/<CategoriesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<CategoriesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
