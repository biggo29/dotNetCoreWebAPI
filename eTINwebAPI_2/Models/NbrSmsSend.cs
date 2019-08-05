using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class NbrSmsSend
    {
        public long SendReqNo { get; set; }
        public string CountCode { get; set; }
        public string Mobile { get; set; }
        public DateTime RequestTime { get; set; }
        public DateTime RequestDate { get; set; }
        public string IpAddr { get; set; }
        public string ActivationCode { get; set; }
        public string NetworkProvider { get; set; }
        public string Gateway { get; set; }
        public string ActualSms { get; set; }
        public string ActionName { get; set; }
        public long ReqTypeNum { get; set; }
        public string JobId { get; set; }
        public bool? IsDelivered { get; set; }
        public DateTime? DeliveryTime { get; set; }
    }
}
