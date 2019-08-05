using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class GenJuriSelectList
    {
        public GenJuriSelectList()
        {
            GenJuriSubList = new HashSet<GenJuriSubList>();
            NbrAddrInfo = new HashSet<NbrAddrInfo>();
            NbrTinInfo = new HashSet<NbrTinInfo>();
        }

        public long JuriSelectListNo { get; set; }
        public long JuriTypeNo { get; set; }
        public long JuriSelectTypeNo { get; set; }
        public long DistNo { get; set; }
        public string ListName { get; set; }
        public long? SlNo { get; set; }
        public bool? IsActive { get; set; }
        public bool IsSubExists { get; set; }
        public bool IsWard { get; set; }
        public bool? IsLocation { get; set; }
        public bool? IsAssesseeName { get; set; }
        public bool? IsInputRequired { get; set; }
        public int? LocalForeignType { get; set; }
        public string PoCodeFrom { get; set; }
        public string PoCodeTo { get; set; }
        public string Descr { get; set; }
        public string Bdescr { get; set; }
        public long? CircleNo { get; set; }

        public GenCircleInfo CircleNoNavigation { get; set; }
        public GenDistrict DistNoNavigation { get; set; }
        public GenJuriSelectType JuriSelectTypeNoNavigation { get; set; }
        public GenJurisdictionType JuriTypeNoNavigation { get; set; }
        public ICollection<GenJuriSubList> GenJuriSubList { get; set; }
        public ICollection<NbrAddrInfo> NbrAddrInfo { get; set; }
        public ICollection<NbrTinInfo> NbrTinInfo { get; set; }
    }
}
