using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace eTINwebAPI_2.JWTAuth
{
    public class Token
    {
        public static Dictionary<string, string> key = new Dictionary<string, string>();

        public static bool IsKeyExist(string keyId, ref string keyValue)
        {
            if (Token.key.ContainsKey(keyId))
            {
                keyValue = Token.key[keyId];
                return true;
            }
            return false;
        }

        public static string CreateKey(string keyId)
        {
            RNGCryptoServiceProvider rNG = new RNGCryptoServiceProvider();
            byte[] buff = new byte[32];
            rNG.GetBytes(buff);

            string base64Secret = Convert.ToBase64String(buff);
            if (!Token.IsKeyExist(keyId, ref base64Secret))
            {
                Token.key.Add(keyId, base64Secret);
            }
            return base64Secret;
        }
    }
}
