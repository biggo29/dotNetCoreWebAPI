using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class GenConfigType
    {
        public long ConfigTypeNo { get; set; }
        public string ConfigTypeName { get; set; }
        public long DataTypeNo { get; set; }
        public byte[] ConfigValues { get; set; }
        public string StrConfigVal { get; set; }

        public GenDataType DataTypeNoNavigation { get; set; }
    }
}
