using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class GenUpazilla
    {
        public GenUpazilla()
        {
            NbrAddrInfo = new HashSet<NbrAddrInfo>();
        }

        public long UpzaNo { get; set; }
        public string UpzaName { get; set; }
        public long DistNo { get; set; }
        public string PoCodeFrom { get; set; }
        public string PoCodeTo { get; set; }

        public GenDistrict DistNoNavigation { get; set; }
        public ICollection<NbrAddrInfo> NbrAddrInfo { get; set; }
    }
}
