using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class NbrAddrReq
    {
        public long AddrReqNo { get; set; }
        public long ReqNo { get; set; }
        public long TinInfoNo { get; set; }
        public long AddrTypeNo { get; set; }
        public string Addr { get; set; }
        public string Addr1 { get; set; }
        public long? CountNo { get; set; }
        public long? DistNo { get; set; }
        public long? UpzaNo { get; set; }
        public long? ThanaNo { get; set; }
        public long? JuriSelectListNo { get; set; }
        public long? JuriSubListNo { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public bool? IsImported { get; set; }
        public DateTime? InsertTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public long? ContactUpdateReasonNo { get; set; }
        public string UpdateReason { get; set; }
        public long? UpdateUserNo { get; set; }
        public long? UpdateLogonHisNo { get; set; }
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
