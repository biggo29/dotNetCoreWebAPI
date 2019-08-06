using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using eTINwebAPI_2.BusinessLayer;
using eTINwebAPI_2.JsonModel;
using eTINwebAPI_2.JWTAuth;
using eTINwebAPI_2.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using eTINwebAPI_2.Helper;

namespace eTINwebAPI_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AuthenticationController : ControllerBase
    {
        readonly IConfiguration _configuration;
        Helper.Utility _utility;
        //private ILogger _Logger;
        public AuthenticationController(Helper.Utility utility,IConfiguration configuration)
        {
            _configuration = configuration;
            _utility = utility;
            // _Logger = logger;
        }

        [HttpPost("token"), AllowAnonymous]
        public ActionResult GetToken([FromBody] Login login)
        {
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                using (var db = new eTINtestContext())
                {
                    NbrUsersBL userService = new NbrUsersBL();
                    NbrUsers nbrUser;

                    if (userService.IsValidUser(login, out nbrUser))
                    {
                        string securityKey = Token.CreateKey(login.UserName);
                        var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));
                        var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);
                        NbrWebApiUser apiUser = new NbrWebApiUser();
                        //using (var db = new eTINtestContext())
                        //{
                            apiUser = db.NbrWebApiUser.FirstOrDefault(x => x.UserNo == nbrUser.UserNo && x.IsActive == true);
                        //}

                        NbrWebApiAuthTracker webApiAuthTracker = AuthTrackerBL.SetAuthTokenHistory(apiUser, _utility);
                        try
                        {
                            db.NbrWebApiAuthTracker.Add(webApiAuthTracker);
                            db.SaveChanges();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                        }

                        ClaimsIdentity claimsIdentity = new ClaimsIdentity(new[]
                        {
                            new Claim(ClaimTypes.Name, login.UserName),
                            new Claim("user_id",nbrUser.UserNo.ToString()),
                            new Claim(ClaimTypes.Role, (apiUser==null)?"":apiUser.UserRole),
                            new Claim("auth_id", (webApiAuthTracker==null)?"":webApiAuthTracker.AuthId.ToString())
                        });


                        var response = new
                        {
                            success = true,
                            token = new JwtSecurityTokenHandler().WriteToken(
                                new JwtSecurityTokenHandler().CreateJwtSecurityToken(
                                    issuer: _configuration["Jwt:Issuer"],
                                    audience: "eTINwebAPI_2",
                                    subject: claimsIdentity,
                                    notBefore: DateTime.Now,
                                    expires: DateTime.Now.AddDays(1),
                                    signingCredentials: signingCredentials
                                    )
                                )
                        };
                        //write code for Auth history
                        //var _utility = new Utility();
                        //NbrWebApiAuthTracker webApiAuthTracker = AuthTrackerBL.SetAuthTokenHistory(apiUser, _utility);
                        //try
                        //{
                        //    db.NbrWebApiAuthTracker.Add(webApiAuthTracker);
                        //    db.SaveChanges();
                        //}catch(Exception ex)
                        //{
                        //    Console.WriteLine(ex);
                        //}
                        scope.Complete();
                        return Ok(response);
                    }
                    return Unauthorized();
                }
            }
        }

        [HttpPost("changepassword")]
        public async Task<ActionResult> ChangePassword([FromBody] Login login)
        {
            if (!login.Password.Equals(login.ConfirmPassword))
            {
                return BadRequest(new
                {
                    success = false,
                    message = "Password and confirm password does not match."
                });
            }
            try
            {
                NbrUsersBL userService = new NbrUsersBL();
                if (userService.ChangePassword(login))
                {
                    Token.key.Remove(login.UserName);
                    return Ok(new
                    {
                        succes = true,
                        message = "Password Changed Successfully."
                    });
                }
            }
            catch (Exception ex)
            {
                return Ok(new
                {
                    success = false,
                    exception = ex
                });
            }

            return Ok(new { success = false });
        }
    }
}