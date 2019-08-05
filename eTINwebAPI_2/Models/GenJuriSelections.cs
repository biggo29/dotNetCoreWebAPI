using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class GenJuriSelections
    {
        public long JuriSelectNo { get; set; }
        public long JuriTypeNo { get; set; }
        public long JuriSelectTypeNo { get; set; }
        public bool? IsActive { get; set; }

        public GenJuriSelectType JuriSelectTypeNoNavigation { get; set; }
        public GenJurisdictionType JuriTypeNoNavigation { get; set; }
    }
}
