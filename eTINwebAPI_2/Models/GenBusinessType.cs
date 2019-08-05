using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class GenBusinessType
    {
        public GenBusinessType()
        {
            GenRegBusinessType = new HashSet<GenRegBusinessType>();
            NbrTinBusinessInfo = new HashSet<NbrTinBusinessInfo>();
        }

        public long BusiTypeNo { get; set; }
        public string BusinessType { get; set; }
        public bool? IsActive { get; set; }
        public string Descr { get; set; }

        public ICollection<GenRegBusinessType> GenRegBusinessType { get; set; }
        public ICollection<NbrTinBusinessInfo> NbrTinBusinessInfo { get; set; }
    }
}
