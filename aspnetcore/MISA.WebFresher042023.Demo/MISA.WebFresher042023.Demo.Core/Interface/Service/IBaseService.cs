using MISA.WebFresher042023.Demo.Core.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.WebFresher042023.Demo.Core.Interface.Service
{
    public interface IBaseService<TEntityDto,TEntityCreateDto,TEntityUpdateDto>
    {
        public Task<TEntityDto> GetAsync(Guid id);
        public Task<List<TEntityDto>> GetAllAsync();
        public Task<TEntityDto> InsertAsync(TEntityCreateDto assetCreateDto);
        public Task<TEntityDto> UpdateAsync(Guid id, TEntityUpdateDto asset);
        public Task<int> DeleteAsync(Guid id);
        public Task<int> DeleteMultipleAsync(List<Guid> ids);
    }
}
