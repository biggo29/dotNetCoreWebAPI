using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class NbrAddrHistory
    {
        public long AddrHisNo { get; set; }
        public long AddrInfoNo { get; set; }
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
    }
}
