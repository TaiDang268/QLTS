using Microsoft.AspNetCore.Mvc;
using MISA.WebFresher042023.Demo.Core.Dto;
using MISA.WebFresher042023.Demo.Core.Interface.Service;
using MISA.WebFresher042023.Demo.Core.NewFolder;

namespace MISA.WebFresher042023.Demo.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class AssetsController : BaseController< AssetDto, AssetCreateDto, AssetUpdateDto>
    {
        
       
        private readonly IAssetService _assetService; 
        public AssetsController(IAssetService assetService):base(assetService)
        {
           _assetService = assetService;
        }
    }
}











