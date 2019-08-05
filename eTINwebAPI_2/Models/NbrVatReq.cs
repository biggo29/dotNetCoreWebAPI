using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class NbrVatReq
    {
        public long VatReqNo { get; set; }
        public long ReqNo { get; set; }
        public long TinInfoNo { get; set; }
        public string VatRegNumber { get; set; }
        public string VatName { get; set; }
        public bool? IsImported { get; set; }
        public DateTime? InsertTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public long? ReqUserNo { get; set; }
        public long? ReqLogonNo { get; set; }
        public DateTime? ReqTime { get; set; }
        public bool? ApproveStatusNum { get; set; }
        public long? ApproveUserNo { get; set; }
        public long? ApproveLogonNo { get; set; }
        public DateTime? ApproveTime { get; set; }

        public NbrTinStatusReq ReqNoNavigation { get; set; }
    }
}
