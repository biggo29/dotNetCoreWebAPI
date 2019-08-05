using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class GenRegType
    {
        public GenRegType()
        {
            GenDesigList = new HashSet<GenDesigList>();
            GenRegAddrType = new HashSet<GenRegAddrType>();
            GenRegAttachType = new HashSet<GenRegAttachType>();
            GenRegBusinessType = new HashSet<GenRegBusinessType>();
            GenRegEditTypes = new HashSet<GenRegEditTypes>();
            GenRegJuriType = new HashSet<GenRegJuriType>();
            GenRegUploadType = new HashSet<GenRegUploadType>();
            GenRegUserType = new HashSet<GenRegUserType>();
            GenTokenInstruction = new HashSet<GenTokenInstruction>();
            GenTokenRejectReason = new HashSet<GenTokenRejectReason>();
            NbrTinInfo = new HashSet<NbrTinInfo>();
            NbrTinStatusReq = new HashSet<NbrTinStatusReq>();
        }

        public long RegTypeNo { get; set; }
        public string RegTypeName { get; set; }
        public string CertName { get; set; }
        public bool? IsForLocal { get; set; }
        public bool? IsForForeign { get; set; }
        public long? SlNo { get; set; }
        public bool? IsTokenForOld { get; set; }
        public bool? IsTokenForNew { get; set; }
        public long? RegTypeNum { get; set; }
        public long? RegTypeMastNo { get; set; }
        public bool? IsActive { get; set; }
        public string ToolTips { get; set; }

        public GenRegTypeMaster RegTypeMastNoNavigation { get; set; }
        public ICollection<GenDesigList> GenDesigList { get; set; }
        public ICollection<GenRegAddrType> GenRegAddrType { get; set; }
        public ICollection<GenRegAttachType> GenRegAttachType { get; set; }
        public ICollection<GenRegBusinessType> GenRegBusinessType { get; set; }
        public ICollection<GenRegEditTypes> GenRegEditTypes { get; set; }
        public ICollection<GenRegJuriType> GenRegJuriType { get; set; }
        public ICollection<GenRegUploadType> GenRegUploadType { get; set; }
        public ICollection<GenRegUserType> GenRegUserType { get; set; }
        public ICollection<GenTokenInstruction> GenTokenInstruction { get; set; }
        public ICollection<GenTokenRejectReason> GenTokenRejectReason { get; set; }
        public ICollection<NbrTinInfo> NbrTinInfo { get; set; }
        public ICollection<NbrTinStatusReq> NbrTinStatusReq { get; set; }
    }
}
