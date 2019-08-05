using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class NbrUserHistory
    {
        public long UserHisNo { get; set; }
        public long UserNo { get; set; }
        public string AdmFullName { get; set; }
        public string AdmDesignation { get; set; }
        public string AdmDepartment { get; set; }
        public string AdmOrganization { get; set; }
        public string UpdateReason { get; set; }
        public DateTime? UpdateTime { get; set; }
        public long? UpdateUserNo { get; set; }
        public long? UpdateLogonHisNo { get; set; }

        public NbrUsers UserNoNavigation { get; set; }
    }
}
