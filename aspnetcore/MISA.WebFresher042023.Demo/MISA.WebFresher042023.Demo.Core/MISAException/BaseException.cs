using System.Text.Json;

namespace MISA.WebFresher042023.Demo.Core.MISAException
{
    public class BaseException
    {
        #region Properties
        public int ErrorCode { get; set; }
        public string? DevMessage { get; set; }
        public string? UserMessage { get; set; }

        public string? TraceId { get; set; }

        public string? MoreInfo { get; set; }
        #endregion

        #region Methods
        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
        #endregion


    }
}
