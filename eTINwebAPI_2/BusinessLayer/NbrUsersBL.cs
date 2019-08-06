using eTINwebAPI_2.Helper;
using eTINwebAPI_2.JsonModel;
using eTINwebAPI_2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.BusinessLayer
{
    public class NbrUsersBL
    {
        public bool IsValidUser(Login login, out NbrUsers nbrUser)
        {
            bool IsValid = false;
            nbrUser = null;
            using (var db = new eTINtestContext())
            {
                var user = db.NbrUsers.FirstOrDefault(x => x.LogonName == login.UserName);
                if (user != null)
                {
                    if (user.LogonPass == CustomSecurity.DecryptPassword(login.Password, user.PassSalt))
                    {
                        IsValid = true;
                        nbrUser = user;
                    }
                }
            }
            return IsValid;
        }

        public bool ChangePassword(Login login)
        {
            bool IsValid = true;
            using (var db = new eTINtestContext())
            {
                var user = db.NbrUsers.FirstOrDefault(x => x.LogonName == login.UserName);
                if(user == null)
                {
                    throw new Exception("User not found");
                }

                string salt;
                string encrypted_pass = CustomSecurity.EncryptPassword(login.UserName.Trim(), login.Password.Trim(), out salt);
                user.LogonPass = encrypted_pass;
                user.PassSalt = salt;
                try
                {
                    db.Entry(user).State = EntityState.Modified;
                    db.SaveChanges();
                }catch(Exception ex)
                {
                    IsValid = false;
                }
            }
            return IsValid;
        }


        public static NbrUsers createNbrUser(NbrTinInfo nbrTinInfo, Utility utility, eTINtestContext db, out string password)
        {
            NbrUsers nbrUser = new NbrUsers();
            password = "";
            try
            {
                //  using (var db = new eTINContext())
                //  {
                string logonName = generateLogonName(nbrTinInfo.AssesName);
                while (db.NbrUsers.Where(x => x.LogonName == logonName).Any())
                {
                    logonName = generateLogonName(nbrTinInfo.AssesName);
                }
                string logonPassword = generatePassword(nbrTinInfo.AssesName);
                password = logonPassword;
                string passwordSalt;
                string encryptPassord = CustomSecurity.EncryptPassword(logonName, logonPassword, out passwordSalt);
                nbrUser.LogonName = logonName;
                nbrUser.LogonPass = encryptPassord;
                nbrUser.PassSalt = passwordSalt;
                nbrUser.UserTypeNo = 4;
                nbrUser.EmailAddr = nbrTinInfo.ContactEmailAddr;
                nbrUser.Mobile = nbrTinInfo.ContactTelephone;
                nbrUser.RegisterTime = DateTime.Now;
                nbrUser.IsEmailActivated = false;
                nbrUser.IsMobileActivated = false;
                nbrUser.CreateTime = DateTime.Now;
                string createUser = utility.GetUserNo();
                nbrUser.CreateUserNo = Convert.ToInt32(createUser);
                nbrUser.IsActive = true;
                nbrUser.IsTinRequest = true;
                nbrUser.IsCancel = false;
                nbrUser.IsPassChangeReq = true;
                //db.Add(nbrUser);
                // db.SaveChanges();
                //   }

            }
            catch (Exception ex) { }
            return nbrUser;
        }

        public NbrUsers GetUserInfo(long tinInfoNo)
        {
            using (var db = new eTINtestContext())
            {
                try
                {
                    var userInfo = db.NbrUsers.Where(a => a.TinInfoNo == tinInfoNo).FirstOrDefault();
                    return userInfo;
                }
                catch(Exception ex)
                {
                    return null;
                }
            }
        }

        private static string generateLogonName(string name)
        {
            string tempLogonName = name.Trim().ToLower().Replace(" ", "_");
            string randomNameStr = CustomSecurity.RandomNumber(3).ToString();
            string logonName = tempLogonName + randomNameStr;
            return logonName;
        }

        private static string generatePassword(string pass)
        {
            string logonPassword = pass.Length > 5 ? pass.Substring(0, 5) : pass;
            string randomStr = CustomSecurity.RandomNumber(4).ToString();
            logonPassword = logonPassword + randomStr;
            return logonPassword;
        }
    }
}
