using AutoMapper;
using MISA.WebFresher042023.Demo.Core.Dto;
using MISA.WebFresher042023.Demo.Core.Interface.Repository;
using MISA.WebFresher042023.Demo.Core.Interface.Service;
using MISA.WebFresher042023.Demo.Core.MISAException;
using MISA.WebFresher042023.Demo.Core.NewFolder;

namespace MISA.WebFresher042023.Demo.Core.Service
{
    public class AssetService
        : BaseService<Asset, AssetDto, AssetCreateDto, AssetUpdateDto>, IAssetService
    {
        private readonly IAssetRepository _assetRepository;
        public AssetService(IAssetRepository assetRepository, IMapper mapper) : base(assetRepository, mapper)
        {
            _assetRepository= assetRepository;
        }

        public async Task<bool> IsDuplicatedAsync(string code)
        {
            var result =await _assetRepository.IsDuplicatedAsync(code);
            return result;
        }
    }
}
