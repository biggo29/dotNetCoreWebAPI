using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class NbrPassRecovery
    {
        public long RequestNo { get; set; }
        public long UserNo { get; set; }
        public DateTime RequestTime { get; set; }
        public DateTime RequestDate { get; set; }
        public string IpAddr { get; set; }
        public string MobPass { get; set; }
        public long RecoverTypeNum { get; set; }
        public string JobId { get; set; }
        public bool? IsDelivered { get; set; }
        public DateTime? DeliveryTime { get; set; }

        public NbrUsers UserNoNavigation { get; set; }
    }
}
