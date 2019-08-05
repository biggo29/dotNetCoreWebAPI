using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class NbrContactHistory
    {
        public long ContactHisNo { get; set; }
        public long TinInfoNo { get; set; }
        public string ContactTelephone { get; set; }
        public string ContactFax { get; set; }
        public string ContactEmailAddr { get; set; }
        public long? ContactUpdateReasonNo { get; set; }
        public string BoiNumber { get; set; }
        public DateTime? BoiDate { get; set; }
        public string UpdateReason { get; set; }
        public long? UpdateUserNo { get; set; }
        public long? UpdateLogonHisNo { get; set; }
        public DateTime? UpdateDate { get; set; }

        public NbrTinInfo TinInfoNoNavigation { get; set; }
    }
}
