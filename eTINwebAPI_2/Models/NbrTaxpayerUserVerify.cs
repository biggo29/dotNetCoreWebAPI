using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class NbrTaxpayerUserVerify
    {
        public long VerifyNo { get; set; }
        public string TaxpayerName { get; set; }
        public long VerifyUserNo { get; set; }
        public long VerifyUserLogonHisNo { get; set; }
        public DateTime VerifyTime { get; set; }
        public bool? IsValid { get; set; }
    }
}
