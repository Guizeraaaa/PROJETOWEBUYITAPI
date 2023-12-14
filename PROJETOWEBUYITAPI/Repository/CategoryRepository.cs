/*


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
        async Task ICategoryRepository.Add(CategoryDTO categoryDTO)
        {
            string sql = @"                                      
                        INSERT INTO CATEGORY(Name)
                        VALUE(@Name)
                            ";
            await Execute(sql, categoryDTO);
        
        }

        async Task ICategoryRepository.Delete(int id)
        {
            string sql = "DELETE FROM CATEGORY WHERE iD = @iD";
            await Execute(sql, new {id});
                
                
                
        }

        async Task<IEnumerable<CategoryEntity>> ICategoryRepository.Get()
        {
            string sql = "SELECT * FROM CATEGORY";
            return await GetConnection().QueryAsync<CategoryEntity>(sql);
        }

        async Task<CategoryEntity> ICategoryRepository.GetById(int Id)
        {
            string sql = "SELECT * FROM CATEGORY WHERE Id = @Id)";
            return await GetConnection().QueryFirstAsync<CategoryEntity>(sql, new {Id});
        }

        async Task<CategoryEntity> ICategoryRepository.GetByName(string Name)
        {
            string sql = "SELECT * FROM CATEGORY WHERE Name = @Name)";
            return await GetConnection().QueryFirstAsync<CategoryEntity>(sql, new { Name });
        }



        async Task ICategoryRepository.Update(CategoryEntity categoryEntity)
        {
            string sql = @"
                           UPDATE CATEGORY
                            SET Name = @Name
                            ";
            await Execute(sql, categoryEntity);
        }
    }
}
*/