using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class TrnTinLog
    {
        public long LogNo { get; set; }
        public long TinInfoNo { get; set; }
        public string LogMode { get; set; }
        public DateTime LogTime { get; set; }
        public bool IsSync { get; set; }
        public bool IsLocked { get; set; }
    }
}
