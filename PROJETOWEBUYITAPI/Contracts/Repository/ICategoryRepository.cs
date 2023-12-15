using PROJETOWEBUYITAPI.DTO;
using PROJETOWEBUYITAPI.Entity;

namespace PROJETOWEBUYITAPI.Contracts.Repository
{
    public interface ICategoryRepository
    {

        Task<IEnumerable<CategoryEntity>> Get();


    }
}
