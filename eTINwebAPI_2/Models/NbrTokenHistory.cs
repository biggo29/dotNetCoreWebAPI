using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class NbrTokenHistory
    {
        public long TokenHisNo { get; set; }
        public long TinInfoNo { get; set; }
        public string TokenIssued { get; set; }
        public DateTime? TokenDate { get; set; }
        public DateTime? TokenExpiryDate { get; set; }
        public string TokenComments { get; set; }
        public long? TokenUserNo { get; set; }
        public long? TokenLogonHisNo { get; set; }

        public NbrTinInfo TinInfoNoNavigation { get; set; }
    }
}
