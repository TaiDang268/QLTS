using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.WebFresher042023.Demo.Core.Dto
{
    public class AssetUpdateDto
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
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }

    }
}
