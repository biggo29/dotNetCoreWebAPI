using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class WsRequestMaster
    {
        public WsRequestMaster()
        {
            WsRequestDetail = new HashSet<WsRequestDetail>();
        }

        public long WsReqMastNo { get; set; }
        public long? UserNo { get; set; }
        public long? LogonHisNo { get; set; }
        public string IpAddr { get; set; }
        public string SessId { get; set; }
        public DateTime? RequestTime { get; set; }
        public string MethodName { get; set; }

        public ICollection<WsRequestDetail> WsRequestDetail { get; set; }
    }
}
