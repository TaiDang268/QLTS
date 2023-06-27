using MISA.WebFresher042023.Demo.Core.NewFolder;
namespace MISA.WebFresher042023.Demo.Core.Interface.Repository
{
    public interface IAssetRepository : IBaseRepository<Asset>
    {
        Task<bool> IsDuplicatedAsync(string code);

    }
}
