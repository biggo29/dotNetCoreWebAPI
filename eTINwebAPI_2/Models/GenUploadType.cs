using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class GenUploadType
    {
        public GenUploadType()
        {
            GenRegUploadType = new HashSet<GenRegUploadType>();
            NbrTinUpload = new HashSet<NbrTinUpload>();
        }

        public long UploadTypeNo { get; set; }
        public string UploadType { get; set; }
        public string UploadExtList { get; set; }
        public long? MaxUpload { get; set; }
        public long? MaxSizeInMb { get; set; }

        public ICollection<GenRegUploadType> GenRegUploadType { get; set; }
        public ICollection<NbrTinUpload> NbrTinUpload { get; set; }
    }
}
