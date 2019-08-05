using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class NbrTinBusiHis
    {
        public long BusiHisNo { get; set; }
        public long BusiInfoNo { get; set; }
        public long TinInfoNo { get; set; }
        public long BusiTypeNo { get; set; }
        public string BusiName { get; set; }
        public string BusiTin { get; set; }
        public string EcTitle { get; set; }
        public string EcName { get; set; }
        public string EcNid { get; set; }
        public DateTime? EcDob { get; set; }
        public string RjscBusiName { get; set; }
        public string RjscBusiTin { get; set; }
        public string OldTinBusiName { get; set; }
        public string OldTinBusiTin { get; set; }
        public bool? IsImported { get; set; }
        public DateTime? InsertTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string CountryName { get; set; }
    }
}
