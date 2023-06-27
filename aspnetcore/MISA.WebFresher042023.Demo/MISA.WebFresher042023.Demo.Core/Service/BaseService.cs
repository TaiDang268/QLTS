using AutoMapper;
using MISA.WebFresher042023.Demo.Core.Dto;
using MISA.WebFresher042023.Demo.Core.Interface.Repository;
using MISA.WebFresher042023.Demo.Core.Interface.Service;
using MISA.WebFresher042023.Demo.Core.MISAException;
using MISA.WebFresher042023.Demo.Core.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.WebFresher042023.Demo.Core.Service
{
    public abstract class BaseService<TEntity, TEntityDto, TEntityCreateDto, TEntityUpdateDto>
        : IBaseService<TEntityDto, TEntityCreateDto, TEntityUpdateDto>
    {
        protected readonly IBaseRepository<TEntity> _baseRepository;
        protected readonly IMapper _mapper;
        protected BaseService(IBaseRepository<TEntity> baseRepository, IMapper mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }
        /*
         Get entity by id
         Created by: DVTAI(20/06/2023)
         */
        public async Task<TEntityDto> GetAsync(Guid id)
        {
            var entity = await _baseRepository.GetAsync(id);
            if (entity == null)
            {
                throw new NotFoundException();
            }
            var entityDto = _mapper.Map<TEntityDto>(entity);
            return entityDto;
        }
        /*
         Delete entity by id
         Created by: DVTAI(20/06/2023)
         */
        public async Task<int> DeleteAsync(Guid id)
        {
            var result = await _baseRepository.DeleteAsync(id);
            return result;
        }
        /*
        Delete multiple entity by list id
        Created by: DVTAI(20/06/2023)
        */
        public Task<int> DeleteMultipleAsync(List<Guid> ids)
        {
            throw new NotImplementedException();
        }
        /*
        Get all entity 
        Created by: DVTAI(20/06/2023)
        */
        public async Task<List<TEntityDto>> GetAllAsync()
        {
            var entityList = await _baseRepository.GetAllAsync();
            var entityDtoList = new List<TEntityDto>();
            foreach (var item in entityList)
            {
                var entityDto = _mapper.Map<TEntityDto>(item);
                entityDtoList.Add(entityDto);
            }
            return entityDtoList;

        }

        /*
        Insert entity 
        Created by: DVTAI(20/06/2023)
        */

        public Task<TEntityDto> InsertAsync(TEntityCreateDto assetCreateDto)
        {
            throw new NotImplementedException();
        }
        /*
        Update entity 
        Created by: DVTAI(20/06/2023)
        */
        public Task<TEntityDto> UpdateAsync(Guid id, TEntityUpdateDto asset)
        {
            throw new NotImplementedException();
        }
    }
}
