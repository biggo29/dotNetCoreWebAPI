using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class OldNbrTinData
    {
        public long OldTinNo { get; set; }
        public string Tin { get; set; }
        public string Aname { get; set; }
        public string Fname { get; set; }
        public string Mname { get; set; }
        public string DobInc { get; set; }
        public string Issuedate { get; set; }
        public string Spname { get; set; }
        public string Anid { get; set; }
        public string MobileNo { get; set; }
        public string CurLoc { get; set; }
        public string TakenNm { get; set; }
        public string CurrAddr { get; set; }
        public string PerAdd { get; set; }
        public string IsValid { get; set; }
        public string OldCurLocV1 { get; set; }
        public long? CreateUserNo { get; set; }
        public long? CreateLogonHisNo { get; set; }
        public string CreateReason { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
