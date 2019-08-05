using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class GenThana
    {
        public GenThana()
        {
            NbrAddrInfo = new HashSet<NbrAddrInfo>();
            NbrInfoEditRequest = new HashSet<NbrInfoEditRequest>();
        }

        public long ThanaNo { get; set; }
        public string ThanaName { get; set; }
        public long DistNo { get; set; }
        public string PoCodeFrom { get; set; }
        public string PoCodeTo { get; set; }

        public GenDistrict DistNoNavigation { get; set; }
        public ICollection<NbrAddrInfo> NbrAddrInfo { get; set; }
        public ICollection<NbrInfoEditRequest> NbrInfoEditRequest { get; set; }
    }
}
