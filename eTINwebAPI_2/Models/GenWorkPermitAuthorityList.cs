using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class GenWorkPermitAuthorityList
    {
        public GenWorkPermitAuthorityList()
        {
            NbrTinInfo = new HashSet<NbrTinInfo>();
        }

        public decimal OrgId { get; set; }
        public string OrgName { get; set; }
        public bool? IsActive { get; set; }
        public int OrderBy { get; set; }

        public ICollection<NbrTinInfo> NbrTinInfo { get; set; }
    }
}
