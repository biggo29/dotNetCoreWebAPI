using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class GenCircleInfo
    {
        public GenCircleInfo()
        {
            GenJuriSelectList = new HashSet<GenJuriSelectList>();
            GenJuriSubList = new HashSet<GenJuriSubList>();
            NbrTinInfo = new HashSet<NbrTinInfo>();
            NbrUsers = new HashSet<NbrUsers>();
        }

        public long CircleNo { get; set; }
        public long ZoneNo { get; set; }
        public long? RangeNo { get; set; }
        public string CircleCode { get; set; }
        public string CircleName { get; set; }
        public string CircleType { get; set; }
        public string CircleCodeBack { get; set; }
        public string CircleNameBack { get; set; }
        public string AdmName { get; set; }
        public string AdmAddr { get; set; }
        public string AdmContact { get; set; }
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public string DistName { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string EmailAddr { get; set; }
        public string OfficerName { get; set; }
        public string Designation { get; set; }
        public string PayCodeInd { get; set; }
        public string PayCodeComp { get; set; }
        public string PayCodeOth { get; set; }

        public GenRangeInfo RangeNoNavigation { get; set; }
        public GenZoneInfo ZoneNoNavigation { get; set; }
        public ICollection<GenJuriSelectList> GenJuriSelectList { get; set; }
        public ICollection<GenJuriSubList> GenJuriSubList { get; set; }
        public ICollection<NbrTinInfo> NbrTinInfo { get; set; }
        public ICollection<NbrUsers> NbrUsers { get; set; }
    }
}
