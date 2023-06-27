using Dapper;
using Microsoft.Extensions.Configuration;
using MISA.WebFresher042023.Demo.Core.Interface.Repository;
using MISA.WebFresher042023.Demo.Core.NewFolder;
using MySqlConnector;

namespace MISA.WebFresher042023.Demo.Infratructure.Repository
{
    public class AssetRepository : BaseRepository<Asset>, IAssetRepository
    {
        public AssetRepository(IConfiguration configuration) : base(configuration)
        {
        }
        public Task<bool> IsDuplicatedAsync(string code) 
        {
            throw new NotImplementedException();
        }
    }
}
 