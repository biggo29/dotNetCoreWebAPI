using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class GenTokenRejectReason
    {
        public GenTokenRejectReason()
        {
            NbrTinInfo = new HashSet<NbrTinInfo>();
        }

        public long TokenRejectReasonNo { get; set; }
        public string RejectReason { get; set; }
        public long? RegTypeNo { get; set; }
        public long? SlNo { get; set; }
        public bool? IsActive { get; set; }

        public GenRegType RegTypeNoNavigation { get; set; }
        public ICollection<NbrTinInfo> NbrTinInfo { get; set; }
    }
}
