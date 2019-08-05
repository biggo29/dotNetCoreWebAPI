using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class NbrInfoUpdate
    {
        public long InfoUpdateNo { get; set; }
        public long TinInfoNo { get; set; }
        public string TableName { get; set; }
        public string FieldName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public long UserNo { get; set; }
        public long LogonHisNo { get; set; }
        public DateTime? UpdateTime { get; set; }

        public NbrTinInfo TinInfoNoNavigation { get; set; }
    }
}
