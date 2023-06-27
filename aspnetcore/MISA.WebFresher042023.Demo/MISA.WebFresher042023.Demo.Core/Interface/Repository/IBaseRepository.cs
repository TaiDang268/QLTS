using MISA.WebFresher042023.Demo.Core.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.WebFresher042023.Demo.Core.Interface.Repository
{
    public interface IBaseRepository<TEntity>
    {

        /// <summary>
        /// lấy 1 bản ghi 
        /// </summary>
        /// <param >ID </param>
        /// <returns>Bản ghi</returns>
        /// Created by: DVTAI(19-06-2023)
        public Task<TEntity> GetAsync(Guid id);
        public Task<List<TEntity>> GetAllAsync();

        public Task<TEntity> InsertAsync(TEntity entity);
        public Task<TEntity> UpdateAsync(Guid id, TEntity entity);
        public Task<int> DeleteAsync(Guid id);
        public Task<int> DeleteMultipleAsync(List<Guid> ids);
    }
}
