using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class GenJurisdictionType
    {
        public GenJurisdictionType()
        {
            GenJuriSelectList = new HashSet<GenJuriSelectList>();
            GenJuriSelections = new HashSet<GenJuriSelections>();
            GenRegJuriType = new HashSet<GenRegJuriType>();
            NbrTinInfo = new HashSet<NbrTinInfo>();
        }

        public long JuriTypeNo { get; set; }
        public string JuriTypeName { get; set; }
        public string Descr { get; set; }
        public string Bdescr { get; set; }
        public long? SlNo { get; set; }
        public bool? IsActive { get; set; }

        public ICollection<GenJuriSelectList> GenJuriSelectList { get; set; }
        public ICollection<GenJuriSelections> GenJuriSelections { get; set; }
        public ICollection<GenRegJuriType> GenRegJuriType { get; set; }
        public ICollection<NbrTinInfo> NbrTinInfo { get; set; }
    }
}
