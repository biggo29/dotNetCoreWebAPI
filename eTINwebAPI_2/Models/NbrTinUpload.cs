using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class NbrTinUpload
    {
        public long UploadNo { get; set; }
        public long TinInfoNo { get; set; }
        public long UploadTypeNo { get; set; }
        public string UploadName { get; set; }
        public byte[] UploadData { get; set; }
        public string UploadExt { get; set; }
        public bool? IsImported { get; set; }
        public DateTime? InsertTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public long? UpdateUserNo { get; set; }
        public long? UpdateLogonNo { get; set; }
        public string UpdateReason { get; set; }

        public NbrTinInfo TinInfoNoNavigation { get; set; }
        public GenUploadType UploadTypeNoNavigation { get; set; }
    }
}
