using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using eTINwebAPI_2.Models;
using eTINwebAPI_2.BusinessLayer;
using eTINwebAPI_2.Responses;
using Microsoft.Extensions.Configuration;
using eTINwebAPI_2.Helper;
using Microsoft.AspNetCore.Authorization;

namespace eTINwebAPI_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "USER_BIDA")]
    public class TinInfoController : ControllerBase
    {
        //private readonly eTINtestContext _context;

        //public TinInfoController(eTINtestContext context)
        //{
        //    _context = context;
        //}

        //// GET: api/TinInfo
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<NbrTinInfo>>> GetNbrTinInfo()
        //{
        //    return await _context.NbrTinInfo.ToListAsync();
        //}

        //// GET: api/TinInfo/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<NbrTinInfo>> GetNbrTinInfo(long id)
        //{
        //    var nbrTinInfo = await _context.NbrTinInfo.FindAsync(id);

        //    if (nbrTinInfo == null)
        //    {
        //        return NotFound();
        //    }

        //    return nbrTinInfo;
        //}
        public static string sda = "DFS";
        readonly IConfiguration _configuration;
        Utility _utility;
        public TinInfoController(IConfiguration configuration, Utility utility)
        {
            _configuration = configuration;
            _utility = utility;
        }

        [HttpGet, Route("TIN/{tin}")]
        public ActionResult GetTin(string tin)
        {
            TINBL tINBL = new TINBL();
            var tinInfo = tINBL.GetTinInfo(tin);
            if (tinInfo != null)
            {
                var info = new
                {
                    tin = tinInfo.NewTin,
                    AssessName = tinInfo.AssesName
                };
                return Ok(info);
            }
            TINApiResponse apiResponse = new TINApiResponse();
            apiResponse.isError = 1;
            apiResponse.errorDescription = "TIN not found";
            return Ok(apiResponse);
        }


        //private bool NbrTinInfoExists(long id)
        //{
        //    return _context.NbrTinInfo.Any(e => e.TinInfoNo == id);
        //}
    }
}
