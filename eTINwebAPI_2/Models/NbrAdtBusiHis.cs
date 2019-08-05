using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class NbrAdtBusiHis
    {
        public long BusiHisNo { get; set; }
        public long BusiNo { get; set; }
        public long TinInfoNo { get; set; }
        public string BusinessName { get; set; }
        public DateTime? InsertTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public long? InsertUserNo { get; set; }
        public long? InsertLogonNo { get; set; }
        public DateTime? DeleteTime { get; set; }
        public long? DeleteUserNo { get; set; }
        public long? DeleteLogonNo { get; set; }
    }
}
