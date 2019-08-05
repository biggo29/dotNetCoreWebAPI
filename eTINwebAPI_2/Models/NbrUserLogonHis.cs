using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class NbrUserLogonHis
    {
        public long LogonHisNo { get; set; }
        public long UserNo { get; set; }
        public string SessId { get; set; }
        public string IpAddr { get; set; }
        public DateTime InTime { get; set; }
        public DateTime? OutTime { get; set; }

        public NbrUsers UserNoNavigation { get; set; }
    }
}
