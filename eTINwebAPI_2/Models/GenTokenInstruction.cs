using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class GenTokenInstruction
    {
        public long TokenInstructNo { get; set; }
        public long RegTypeNo { get; set; }
        public string Instruction { get; set; }
        public string InstructDetail { get; set; }
        public long? SlNo { get; set; }

        public GenRegType RegTypeNoNavigation { get; set; }
    }
}
