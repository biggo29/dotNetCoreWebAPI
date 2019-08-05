using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class WsRequestDetail
    {
        public long WsReqDetNo { get; set; }
        public long WsReqMastNo { get; set; }
        public string ParamName { get; set; }
        public string ParamVal { get; set; }

        public WsRequestMaster WsReqMastNoNavigation { get; set; }
    }
}
