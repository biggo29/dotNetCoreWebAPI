using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class GenJuriSelectType
    {
        public GenJuriSelectType()
        {
            GenJuriSelectList = new HashSet<GenJuriSelectList>();
            GenJuriSelections = new HashSet<GenJuriSelections>();
            NbrTinInfo = new HashSet<NbrTinInfo>();
        }

        public long JuriSelectTypeNo { get; set; }
        public string SelectTypeName { get; set; }
        public long? SlNo { get; set; }

        public ICollection<GenJuriSelectList> GenJuriSelectList { get; set; }
        public ICollection<GenJuriSelections> GenJuriSelections { get; set; }
        public ICollection<NbrTinInfo> NbrTinInfo { get; set; }
    }
}
