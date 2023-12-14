using PROJETOWEBUYITAPI.DTO;
using PROJETOWEBUYITAPI.Entity;

namespace PROJETOWEBUYITAPI.Contracts.Repository
{
    public interface IProdutoRepository
    {
      Task Add(ProdutoDTO produtoDTO);

     Task Update(ProdutoEntity produtoEntity);

    Task Delete(int id);

    Task<ProdutoEntity> GetById(int id);

    Task<ProdutoEntity> GetByName(string name);

        Task<IEnumerable<ProdutoEntity>> Get();
    
    }
}
