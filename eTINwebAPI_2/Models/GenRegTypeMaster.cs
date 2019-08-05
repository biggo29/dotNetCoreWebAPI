using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class GenRegTypeMaster
    {
        public GenRegTypeMaster()
        {
            GenRegType = new HashSet<GenRegType>();
        }

        public long RegTypeMastNo { get; set; }
        public string RegTypeMastName { get; set; }
        public long? SlNo { get; set; }
        public bool? IsActive { get; set; }
        public string ToolTips { get; set; }

        public ICollection<GenRegType> GenRegType { get; set; }
    }
}
