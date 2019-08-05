using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class OldTinInfo
    {
        public long OldTinNo { get; set; }
        public string OldTin { get; set; }
        public string AssesName { get; set; }
        public string FathName { get; set; }
        public string MothName { get; set; }
        public DateTime? Dob { get; set; }
        public string SpouseName { get; set; }
        public string ContactTelephone { get; set; }
        public string ContactFax { get; set; }
        public string ContactEmailAddr { get; set; }
    }
}
