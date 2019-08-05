using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class GenStatusReason
    {
        public GenStatusReason()
        {
            NbrTinStatusReq = new HashSet<NbrTinStatusReq>();
        }

        public long StatusReasonNo { get; set; }
        public string StatusReason { get; set; }

        public ICollection<NbrTinStatusReq> NbrTinStatusReq { get; set; }
    }
}
