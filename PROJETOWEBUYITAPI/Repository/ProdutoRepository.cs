using Dapper;
using PROJETOWEBUYITAPI.Contracts.Repository;
using PROJETOWEBUYITAPI.DTO;
using PROJETOWEBUYITAPI.Entity;
using PROJETOWEBUYITAPI.Infrastructure;
using MySql.Data.MySqlClient;

namespace PROJETOWEBUYITAPI.Repository
{
    public class ProdutoRepository : Connection, IProdutoRepository
    {
        async Task IProdutoRepository.Add(ProdutoDTO produtoDTO)
        {
            string sql = @"
              INSERT INTO PRODUCT (Name, Description, OriginalPrice, CurrentPrice, Discount,Buyers)
              VALUE(@Name, @Description, @OriginalPrice, @CurrentPrice, @Discount, @Buyers)
             ";
            await Execute(sql, produtoDTO);
        
        }

        public async Task  Delete(int id)
        {
            string sql = "DELETE FROM PRODUCT WHERE iD = @iD";
            await Execute(sql, new { id });
        }

       public async Task<IEnumerable<ProdutoEntity>> Get()
        {
            string sql = "SELECT * FROM PRODUCT";
            return await GetConnection().QueryAsync<ProdutoEntity>(sql);
        }

       public async Task<ProdutoEntity> GetById(int Id)
        {
            string sql = "SELECT * FROM PRODUCT WHERE Id = @Id";
            return await GetConnection().QueryFirstAsync<ProdutoEntity>(sql, new {Id});
        }

        /*  async Task<ProdutoEntity> IProdutoRepository.GetByName(string Name)
          {
              string sql = "SELECT * FROM PRODUCT WHERE Name = @Name";
              return await GetConnection().QueryFirstAsync(sql,new { Name});
          }*/
        public async Task<ProdutoEntity> GetByName(string Name)
        {
            string sql = "SELECT * FROM PRODUCT WHERE Name = @Name";
            return await GetConnection().QueryFirstOrDefaultAsync<ProdutoEntity>(sql, new { Name });
        }

        async Task IProdutoRepository.Update(ProdutoEntity produtoEntity)
        {
            string sql = @"
                 UPDATE PRODUCT 
                   SET Name = @Name,
                       Description = @Description,
                       OriginalPrice = @OriginalPrice,
                       CurrentPrice = @CurrentPrice, 
                       Discount = @Discount,
                       Buyers = @Buyers
                    ";
            await Execute(sql, produtoEntity);
        }
    }
}
