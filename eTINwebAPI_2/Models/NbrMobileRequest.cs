using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class NbrMobileRequest
    {
        public long ReqMobNo { get; set; }
        public long UserNo { get; set; }
        public string CountryCode { get; set; }
        public string ReqMob { get; set; }
        public DateTime? ReqTime { get; set; }
        public string ActivateCode { get; set; }
        public bool? IsActivated { get; set; }
        public DateTime? ActivationTime { get; set; }
        public string ReqIpAddress { get; set; }
        public string ActivateIpAddress { get; set; }
        public bool? IsCancel { get; set; }
        public DateTime? CancelTime { get; set; }
        public string CancelIpAddress { get; set; }
        public long? ReqUserNo { get; set; }
        public long? ReqLogonNo { get; set; }
        public long? ActivateUserNo { get; set; }
        public long? ActiveLogonNo { get; set; }
        public long? CancelUserNo { get; set; }
        public long? CancelLogonNo { get; set; }

        public NbrUsers UserNoNavigation { get; set; }
    }
}
