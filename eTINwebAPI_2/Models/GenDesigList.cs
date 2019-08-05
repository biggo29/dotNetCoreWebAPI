using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class GenDesigList
    {
        public GenDesigList()
        {
            NbrTinInfo = new HashSet<NbrTinInfo>();
            NbrTinStatusReq = new HashSet<NbrTinStatusReq>();
        }

        public long DesigNo { get; set; }
        public string DesigName { get; set; }
        public long RegTypeNo { get; set; }
        public long? SlNo { get; set; }
        public bool? IsActive { get; set; }

        public GenRegType RegTypeNoNavigation { get; set; }
        public ICollection<NbrTinInfo> NbrTinInfo { get; set; }
        public ICollection<NbrTinStatusReq> NbrTinStatusReq { get; set; }
    }
}
