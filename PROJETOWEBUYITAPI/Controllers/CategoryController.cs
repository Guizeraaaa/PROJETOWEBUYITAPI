
/*using Microsoft.AspNetCore.Mvc;
using PROJETOWEBUYITAPI.Contracts.Repository;
using PROJETOWEBUYITAPI.DTO;
using PROJETOWEBUYITAPI.Entity;
using PROJETOWEBUYITAPI.Repository;

namespace PROJETOWEBUYITAPI.Controllers
{
    [ApiController]
    [Route("category")]

    public class CategoryController : ControllerBase
    {
  
    private readonly ICategoryRepository _categoryRepository;

    public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpGet]

    public async Task<IActionResult> Get()
        {
            return Ok(await _categoryRepository.Get());
        }

        [HttpPost]

    public async Task<IActionResult> Add(CategoryDTO categoryDTO)
        {
            await _categoryRepository.Add(categoryDTO);
            return Ok();
        }

        [HttpPut]

    public async Task<IActionResult> Update(CategoryEntity categoryEntity)
        {
            await _categoryRepository.Update(categoryEntity);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int Id)
        {
            await _categoryRepository.Delete(Id);
            return Ok();

        }

        [HttpGet("{Id}")]

        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _categoryRepository.GetById(id));
        }

        [HttpGet("{Name}")]

        public async Task<IActionResult> GetByName(string Name)
        {
            return Ok(await _categoryRepository.GetByName(Name));
        }







    }
}
*/