using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class GenCountry
    {
        public GenCountry()
        {
            GenDistrict = new HashSet<GenDistrict>();
            NbrAddrInfo = new HashSet<NbrAddrInfo>();
            NbrInfoEditRequestAddrCountNoNavigation = new HashSet<NbrInfoEditRequest>();
            NbrInfoEditRequestCountNoNavigation = new HashSet<NbrInfoEditRequest>();
            NbrTinInfo = new HashSet<NbrTinInfo>();
            NbrTinStatusReq = new HashSet<NbrTinStatusReq>();
        }

        public long CountNo { get; set; }
        public string CountName { get; set; }
        public string CountCode { get; set; }
        public string CountCodeNum { get; set; }
        public string Nationality { get; set; }
        public bool? IsLocal { get; set; }
        public string OldCountCodeNum { get; set; }

        public ICollection<GenDistrict> GenDistrict { get; set; }
        public ICollection<NbrAddrInfo> NbrAddrInfo { get; set; }
        public ICollection<NbrInfoEditRequest> NbrInfoEditRequestAddrCountNoNavigation { get; set; }
        public ICollection<NbrInfoEditRequest> NbrInfoEditRequestCountNoNavigation { get; set; }
        public ICollection<NbrTinInfo> NbrTinInfo { get; set; }
        public ICollection<NbrTinStatusReq> NbrTinStatusReq { get; set; }
    }
}
