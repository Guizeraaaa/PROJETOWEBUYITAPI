


using Dapper;
using PROJETOWEBUYITAPI.Contracts.Repository;
using PROJETOWEBUYITAPI.DTO;
using PROJETOWEBUYITAPI.Entity;
using PROJETOWEBUYITAPI.Infrastructure;
using MySql.Data.MySqlClient;

namespace PROJETOWEBUYITAPI.Repository
{
    public class CategoryRepository : Connection, ICategoryRepository
    {
     

      public  async Task<IEnumerable<CategoryEntity>> Get()
        {
            string sql = "SELECT * FROM CATEGORY";
            return await GetConnection().QueryAsync<CategoryEntity>(sql);
        }

      /*  async Task<CategoryEntity>GetById(int Id)
        {
            string sql = "SELECT * FROM CATEGORY WHERE Id = @Id)";
            return await GetConnection().QueryFirstAsync<CategoryEntity>(sql, new {Id});
        }

        Task<CategoryEntity> ICategoryRepository.GetById(int id)
        {
            throw new NotImplementedException();
        }

        async Task<CategoryEntity> GetByName(string Name)
        {
            string sql = "SELECT * FROM CATEGORY WHERE Name = @Name)";
            return await GetConnection().QueryFirstAsync<CategoryEntity>(sql, new { Name });
        }

        Task<CategoryEntity> ICategoryRepository.GetByName(string Name)
        {
            throw new NotImplementedException();
        }

        async Task Update(CategoryEntity categoryEntity)
        {
            string sql = @"
                           UPDATE CATEGORY
                            SET Name = @Name
                            ";
            await Execute(sql, categoryEntity);
        }

        Task ICategoryRepository.Update(CategoryEntity categoryEntity)
        {
            throw new NotImplementedException();
        }*/
    }
}
