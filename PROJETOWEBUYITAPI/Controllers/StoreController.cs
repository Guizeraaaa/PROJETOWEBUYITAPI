using Microsoft.AspNetCore.Mvc;
using PROJETOWEBUYITAPI.Contracts.Repository;
using PROJETOWEBUYITAPI.DTO;
using PROJETOWEBUYITAPI.Entity;
using PROJETOWEBUYITAPI.Repository;

namespace PROJETOWEBUYITAPI.Controllers
{
    [ApiController]
    [Route("store")]
    public class StoreController : ControllerBase
    {
     private readonly IStoreRepository _storeRepository;

        public StoreController(IStoreRepository storeRepository)
        {
            _storeRepository = storeRepository;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _storeRepository.Get());
        }
    
    }
}
