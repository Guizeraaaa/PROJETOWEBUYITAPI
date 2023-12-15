using Dapper;
using PROJETOWEBUYITAPI.Contracts.Repository;
using PROJETOWEBUYITAPI.DTO;
using PROJETOWEBUYITAPI.Entity;
using PROJETOWEBUYITAPI.Infrastructure;

namespace PROJETOWEBUYITAPI.Repository
{
    public class StoreRepository : Connection, IStoreRepository
    {
        public async Task<IEnumerable<StoreEntity>> Get()
        {
            string sql = "SELECT * FROM STORE";
            return await GetConnection().QueryAsync<StoreEntity>(sql);
        }
    }
}
