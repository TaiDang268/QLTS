using Dapper;
using Microsoft.Extensions.Configuration;
using MISA.WebFresher042023.Demo.Core.Interface.Repository;
using MISA.WebFresher042023.Demo.Core.NewFolder;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.WebFresher042023.Demo.Infratructure.Repository
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity>
    {
        protected readonly string? _connectionString;
        public BaseRepository(IConfiguration configuration)
        {
            _connectionString = configuration["ConnectionString"];
        }
        /*
        Get all entity  
        Created by: DVTAI ̣̣(20/06/2023)
        */
        public async Task<List<TEntity>> GetAllAsync()
        {
            var tableName = typeof(TEntity).Name;
            var mySQLConnection = new MySqlConnection(_connectionString);
            await mySQLConnection.OpenAsync();
            var sql = $"SELECT * FROM {tableName};";
            var entityList = await mySQLConnection.QueryAsync<TEntity>(sql);
            await mySQLConnection.CloseAsync();
            return entityList.ToList();

        }
        /*
         Get entity by id 
         Created by: DVTAI ̣̣(19/06/2023)
         */
        public async Task<TEntity> GetAsync(Guid id)
        {
            var tableName = typeof(TEntity).Name;
            var mySQLConnection = new MySqlConnection(_connectionString);
            await mySQLConnection.OpenAsync();
            var param = new DynamicParameters();
            param.Add("id", id);
            var sql = $"SELECT * FROM {tableName} WHERE {tableName}Id = @id;";
            var entity = await mySQLConnection.QueryFirstOrDefaultAsync<TEntity>(sql, param);
            await mySQLConnection.CloseAsync();
            return entity;
        }
        /*
        Delete entity by id 
        Created by: DVTAI ̣̣(20/06/2023)
        */
        public async Task<int> DeleteAsync(Guid id)
        {
            var tableName = typeof(TEntity).Name;
            var mySQLConnection = new MySqlConnection(_connectionString);
            await mySQLConnection.OpenAsync();
            var param = new DynamicParameters();
            param.Add("id", id);
            var sql = $"DELETE FROM {tableName} WHERE {tableName}Id = @id;";
            var result = await mySQLConnection.ExecuteAsync(sql, param);
            await mySQLConnection.CloseAsync();
            return result;
        }


        /*
        Insert entity 
        Created by: DVTAI ̣̣(20/06/2023)
        */
        public async Task<TEntity> InsertAsync(TEntity entity)
        {
            var tableName = typeof(TEntity).Name;
            var mySQLConnection = new MySqlConnection(_connectionString);
            await mySQLConnection.OpenAsync();
            var columns = string.Join(", ", entity.GetType().GetProperties().Select(p => p.Name));
            var values = string.Join(", ", entity.GetType().GetProperties().Select(p => $"@{p.Name}"));
            var sql = $"INSERT INTO  {tableName}  ({columns}) VALUES ({values}) ;";
            var result = await mySQLConnection.ExecuteAsync(sql,entity);
            await mySQLConnection.CloseAsync();
            return entity;
        }
        /*
        Delete multiple entity 
        Created by: DVTAI ̣̣(20/06/2023)
        */
        public Task<int> DeleteMultipleAsync(List<Guid> ids)
        {
            throw new NotImplementedException();
        }

        /*
        Update entity 
        Created by: DVTAI ̣̣(20/06/2023)
        */

        public Task<TEntity> UpdateAsync(Guid id, TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
