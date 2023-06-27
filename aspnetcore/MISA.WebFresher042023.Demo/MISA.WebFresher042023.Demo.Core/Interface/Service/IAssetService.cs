using MISA.WebFresher042023.Demo.Core.Dto;
using MISA.WebFresher042023.Demo.Core.NewFolder;

namespace MISA.WebFresher042023.Demo.Core.Interface.Service
{
    public interface IAssetService : IBaseService<AssetDto, AssetCreateDto, AssetUpdateDto>
    {
        Task<bool> IsDuplicatedAsync(string code); 

    }
}
