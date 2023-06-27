
using MISA.WebFresher042023.Demo.Core.Entity;

namespace MISA.WebFresher042023.Demo.Core.NewFolder
{
    public class Asset : BaseEntity
    {
        public Guid AssetId { get; set; }
        public string AssetCode { get; set; }
        public string AssetName { get; set; }
        public Guid DepartmentId { get; set; }
        public string DepartmentCode { get; set; }
        public string DepartmentName { get; set; }
        public Guid CategoryId { get; set; }
        public string CategoryCode { get; set; }
        public string CategoryName { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal Cost { get; set; }
        public int Quantity { get; set; }
        public int DepreciationRate { get; set; }
        public int TrackedYear { get; set; }
        public int LifeTime { get; set; }
        public int ProductionYear { get; set; }
        public int Active { get; set; }

    }
}
