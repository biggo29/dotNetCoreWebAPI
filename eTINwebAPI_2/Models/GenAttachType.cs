using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class GenAttachType
    {
        public GenAttachType()
        {
            GenRegAttachType = new HashSet<GenRegAttachType>();
            NbrTinAttachment = new HashSet<NbrTinAttachment>();
            NbrUserAttachment = new HashSet<NbrUserAttachment>();
            NbrUserPhotos = new HashSet<NbrUserPhotos>();
        }

        public long AttachTypeNo { get; set; }
        public string AttachType { get; set; }
        public string AttachExtList { get; set; }
        public long? MaxAttach { get; set; }
        public long? MaxSizeInMb { get; set; }

        public ICollection<GenRegAttachType> GenRegAttachType { get; set; }
        public ICollection<NbrTinAttachment> NbrTinAttachment { get; set; }
        public ICollection<NbrUserAttachment> NbrUserAttachment { get; set; }
        public ICollection<NbrUserPhotos> NbrUserPhotos { get; set; }
    }
}
