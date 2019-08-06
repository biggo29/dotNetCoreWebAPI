using eTINwebAPI_2.Helper;
using eTINwebAPI_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.BusinessLayer
{
    public class TokenTrackerBL
    {
        public static TinInfoTracker SetTokenHistory(NbrTinInfo tinInfo, Utility utility, NbrUsers userInfo,eTINtestContext db)
        {
            TinInfoTracker tinInfoTracker = new TinInfoTracker();
            tinInfoTracker.NewTin = tinInfo.NewTin;
            tinInfoTracker.UserNo = userInfo.UserNo;
            tinInfoTracker.AssesName = tinInfo.AssesName;
            tinInfoTracker.Mobile = userInfo.Mobile;
            tinInfoTracker.IpAddr = utility.GetRequestIpAddress(); //bring it from eTIN live
            tinInfoTracker.CircleNo = tinInfo.CircleNo;
            tinInfoTracker.Nid = userInfo.Nid;
            return tinInfoTracker;
            //db.
        }
    }
}
