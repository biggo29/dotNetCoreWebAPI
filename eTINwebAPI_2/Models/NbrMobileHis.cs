using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class NbrMobileHis
    {
        public long MobHisNo { get; set; }
        public long UserNo { get; set; }
        public string Mobile { get; set; }
        public DateTime CreatedTime { get; set; }
        public NbrUsers UserNoNavigation { get; set; }
    }
}
