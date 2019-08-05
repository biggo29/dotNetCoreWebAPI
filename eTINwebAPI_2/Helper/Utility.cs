using eTINwebAPI_2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Claims;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Helper
{
    public class Utility
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private IConfiguration _configuration;

        public Utility(IHttpContextAccessor httpContextAccessor, IConfiguration configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
        }

        public string GetUserNo()
        {
            var httphttpContext = _httpContextAccessor.HttpContext;
            ClaimsIdentity identity = httphttpContext.User.Identity as ClaimsIdentity;
            string userId = "";
            if(identity != null)
            {
                userId = identity.FindFirst("user_id").Value;
            }
            return userId;
        }

        public bool sendMail(string email, string password, string userId, eTINtestContext db)
        {
            string emailBody = db.GenConfigType.Where(a => a.ConfigTypeNo == 10).FirstOrDefault().StrConfigVal;
            string emailSubject = db.GenConfigType.Where(a => a.ConfigTypeNo == 11).FirstOrDefault().StrConfigVal;
            emailBody = String.Format(emailBody, "\r\n", userId, password);

            using (var message = new MailMessage())
            {
                message.From=new MailAddress(_configuration["Email:OFFICIAL_EMAIL_ADDR"].Trim(), _configuration["Email:DISPLAY_NAME"].Trim());
                message.To.Add(new MailAddress(email));
                message.Subject = emailSubject;
                message.Body = emailBody;

                var credentials=new NetworkCredential(_configuration["Email:USER_NAME"].Trim(), _configuration["Email:PASSWORD"].Trim());
                var mailClient = new SmtpClient()
                {
                    Port = int.Parse(_configuration["Email:PORT"].Trim()),
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = bool.Parse(_configuration["Email:USE_DEFAULT_CREDENTIAL"].Trim()),
                    Host = _configuration["Email:HOST"].Trim(),
                    EnableSsl = bool.Parse(_configuration["Email:ENABLE_SSL"].Trim()),
                    Credentials = credentials
                };

                mailClient.Send(message);
            }
            return true;
        }
    }
}
