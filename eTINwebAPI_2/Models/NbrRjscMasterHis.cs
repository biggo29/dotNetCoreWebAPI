using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class NbrRjscMasterHis
    {
        public NbrRjscMasterHis()
        {
            NbrRjscHis = new HashSet<NbrRjscHis>();
        }

        public long RjscMasHisNo { get; set; }
        public long TinInfoNo { get; set; }
        public string RjscName { get; set; }
        public string RjscAddr { get; set; }
        public DateTime? CreateTime { get; set; }
        public long? CreateUserNo { get; set; }
        public long? CreateLogonHisNo { get; set; }

        public NbrTinInfo TinInfoNoNavigation { get; set; }
        public ICollection<NbrRjscHis> NbrRjscHis { get; set; }
    }
}
