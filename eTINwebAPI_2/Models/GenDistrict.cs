using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class GenDistrict
    {
        public GenDistrict()
        {
            GenJuriSelectList = new HashSet<GenJuriSelectList>();
            GenThana = new HashSet<GenThana>();
            GenUpazilla = new HashSet<GenUpazilla>();
            GenZoneInfo = new HashSet<GenZoneInfo>();
            NbrAddrInfo = new HashSet<NbrAddrInfo>();
            NbrInfoEditRequest = new HashSet<NbrInfoEditRequest>();
            NbrTinInfo = new HashSet<NbrTinInfo>();
            NbrUsers = new HashSet<NbrUsers>();
        }

        public long DistNo { get; set; }
        public string DistName { get; set; }
        public long CountNo { get; set; }
        public string PoCodeFrom { get; set; }
        public string PoCodeTo { get; set; }
        public long? JuriParentDistNo { get; set; }

        public GenCountry CountNoNavigation { get; set; }
        public ICollection<GenJuriSelectList> GenJuriSelectList { get; set; }
        public ICollection<GenThana> GenThana { get; set; }
        public ICollection<GenUpazilla> GenUpazilla { get; set; }
        public ICollection<GenZoneInfo> GenZoneInfo { get; set; }
        public ICollection<NbrAddrInfo> NbrAddrInfo { get; set; }
        public ICollection<NbrInfoEditRequest> NbrInfoEditRequest { get; set; }
        public ICollection<NbrTinInfo> NbrTinInfo { get; set; }
        public ICollection<NbrUsers> NbrUsers { get; set; }
    }
}
