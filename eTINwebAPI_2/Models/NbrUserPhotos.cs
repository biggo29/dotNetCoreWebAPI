using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class NbrUserPhotos
    {
        public long UserPhotoNo { get; set; }
        public long UserNo { get; set; }
        public long AttachTypeNo { get; set; }
        public string AttachName { get; set; }
        public byte[] AttachData { get; set; }
        public string AttachExt { get; set; }

        public GenAttachType AttachTypeNoNavigation { get; set; }
        public NbrUsers UserNoNavigation { get; set; }
    }
}
