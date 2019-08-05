using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class GenJuriSubList
    {
        public GenJuriSubList()
        {
            NbrAddrInfo = new HashSet<NbrAddrInfo>();
            NbrTinInfo = new HashSet<NbrTinInfo>();
        }

        public long JuriSubListNo { get; set; }
        public long JuriSelectListNo { get; set; }
        public string SubListName { get; set; }
        public long? SlNo { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsLocation { get; set; }
        public string PoCodeFrom { get; set; }
        public string PoCodeTo { get; set; }
        public bool? IsLetterMatch { get; set; }
        public bool? IsInputRequired { get; set; }
        public string Descr { get; set; }
        public string Bdescr { get; set; }
        public long CircleNo { get; set; }

        public GenCircleInfo CircleNoNavigation { get; set; }
        public GenJuriSelectList JuriSelectListNoNavigation { get; set; }
        public ICollection<NbrAddrInfo> NbrAddrInfo { get; set; }
        public ICollection<NbrTinInfo> NbrTinInfo { get; set; }
    }
}
