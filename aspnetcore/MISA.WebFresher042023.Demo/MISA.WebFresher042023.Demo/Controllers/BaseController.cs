using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISA.WebFresher042023.Demo.Core.Interface.Service;

namespace MISA.WebFresher042023.Demo.Controllers
{
    [ApiController]
    public abstract class BaseController<TEntityDto, TEntityCreateDto, TEntityUpdateDto> : ControllerBase
    {
        protected readonly IBaseService<TEntityDto, TEntityCreateDto, TEntityUpdateDto> _baseService;
        public BaseController(IBaseService<TEntityDto, TEntityCreateDto, TEntityUpdateDto> baseService)
        {
            _baseService = baseService;
        }
        /*
         Get entity by id 
         Created by: DVTAI(20/06/2023)
         */
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(Guid id)
        {
            var entityDto = await _baseService.GetAsync(id);

            return StatusCode(StatusCodes.Status200OK, entityDto);
        }
        /*
         Get all entity 
         Created by: DVTAI(20/06/2023)
        */
        [HttpGet()]
        public async Task<IActionResult> GetAllAsync()
        {
            var entityDtoList = await _baseService.GetAllAsync();

            return StatusCode(StatusCodes.Status200OK, entityDtoList);
        }
        /*
         Delete entity by id 
         Created by: DVTAI(20/06/2023)
         */
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            var result = await _baseService.DeleteAsync(id);

            return StatusCode(StatusCodes.Status200OK, result);
        }
        /*
        Insert  entity 
        Created by: DVTAI(20/06/2023)
        */
        [HttpPost]
        public async Task<IActionResult> InsertAsync(TEntityCreateDto entity)
        {
            var result = await _baseService.InsertAsync(entity);

            return StatusCode(StatusCodes.Status201Created, result);
        }
    }
}
