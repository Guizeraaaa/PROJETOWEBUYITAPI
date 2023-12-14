using Microsoft.AspNetCore.Mvc;
using PROJETOWEBUYITAPI.Contracts.Repository;
using PROJETOWEBUYITAPI.DTO;
using PROJETOWEBUYITAPI.Entity;
using PROJETOWEBUYITAPI.Repository;

namespace PROJETOWEBUYITAPI.Controllers
{
    [ApiController]
    [Route("product")]
    public class ProdutoController : ControllerBase
    {
      private readonly IProdutoRepository _produtoRepository;

    public ProdutoController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _produtoRepository.Get());
        }

        [HttpPost]
        public async  Task<IActionResult> Add(ProdutoDTO produtoDTO)
        {
            await _produtoRepository.Add(produtoDTO);
            return Ok();
        }

        [HttpPut]

        public async Task<IActionResult> Update(ProdutoEntity produtoEntity)
        {
            await _produtoRepository.Update(produtoEntity);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int Id)
        {
            await _produtoRepository.Delete(Id);
                return Ok();

        }

        [HttpGet("{Id}")]

        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _produtoRepository.GetById(id));
        }

        [HttpGet("{Name}")]

        public async Task<IActionResult> GetByName(string Name)
        {
            return Ok(await _produtoRepository.GetByName(Name));
        }

    
    }
}
