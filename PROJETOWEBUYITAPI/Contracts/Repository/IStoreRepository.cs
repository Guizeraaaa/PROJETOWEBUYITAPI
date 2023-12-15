using PROJETOWEBUYITAPI.Entity;

namespace PROJETOWEBUYITAPI.Contracts.Repository
{
    public interface IStoreRepository
    {
        Task<IEnumerable<StoreEntity>> Get();

    }
}
