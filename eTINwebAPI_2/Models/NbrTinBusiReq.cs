using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class NbrTinBusiReq
    {
        public long BusiReqNo { get; set; }
        public long ReqNo { get; set; }
        public long TinInfoNo { get; set; }
        public long BusiTypeNo { get; set; }
        public string BusiName { get; set; }
        public string BusiTin { get; set; }
        public string EcTitle { get; set; }
        public string EcName { get; set; }
        public string EcNid { get; set; }
        public DateTime? EcDob { get; set; }
        public string RjscBusiName { get; set; }
        public string RjscBusiTin { get; set; }
        public string OldTinBusiName { get; set; }
        public string OldTinBusiTin { get; set; }
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
        public string CountryName { get; set; }

        public NbrTinStatusReq ReqNoNavigation { get; set; }
    }
}
