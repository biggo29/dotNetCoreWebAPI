using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class GenContactUpdateReason
    {
        public GenContactUpdateReason()
        {
            NbrTinInfo = new HashSet<NbrTinInfo>();
        }

        public long ContactUpdateReasonNo { get; set; }
        public string ContactUpdateReasonName { get; set; }
        public long? SlNo { get; set; }
        public bool? IsActive { get; set; }

        public ICollection<NbrTinInfo> NbrTinInfo { get; set; }
    }
}
