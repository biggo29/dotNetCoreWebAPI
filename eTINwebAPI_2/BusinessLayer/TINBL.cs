using eTINwebAPI_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.BusinessLayer
{
    public class TINBL: BaseBL
    {
        public NbrTinInfo GetTinInfo(string tin)
        {
            using (var db = new eTINtestContext())
            {
                var tinInfo = db.NbrTinInfo.FirstOrDefault(n => n.NewTin == tin);
                return tinInfo;
            }
        }

        public bool IsTinExist(string tin)
        {
            using (var db = new eTINtestContext())
            {
                var tinInfo = db.NbrTinInfo.Where(n => n.NewTin == tin).Select(t => t.NewTin).FirstOrDefault();
                if (tinInfo != null)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
