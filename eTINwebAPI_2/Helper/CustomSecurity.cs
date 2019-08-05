using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Helper
{
    public class CustomSecurity
    {

        private static string CreateSalt(string UserName)
        {
            Rfc2898DeriveBytes hasher = new Rfc2898DeriveBytes(UserName,
            System.Text.Encoding.Default.GetBytes("tlaSIFCNBRTINSalt"), 100);
            return Convert.ToBase64String(hasher.GetBytes(20));
        }

        private static string HashPassword(string Salt, string Password)
        {
            Rfc2898DeriveBytes Hasher = new Rfc2898DeriveBytes(Password,
                System.Text.Encoding.Default.GetBytes(Salt), 100);
            return Convert.ToBase64String(Hasher.GetBytes(20));
        }

        public static string EncryptPassword(string LogonName, string password, out string Salt)
        {
            Salt = CustomSecurity.CreateSalt(LogonName);
            return CustomSecurity.HashPassword(Salt, password);
        }

        public static string DecryptPassword(string password, string Salt)
        {
            return CustomSecurity.HashPassword(Salt, password);
        }

        public static string RandomString(int size)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

            return builder.ToString();
        }

        public static int RandomNumber(int size)
        {
            int ret_val = 0;
            int int_min_val = 0;
            int int_max_val = 0;

            string str_start_val = "";
            string str_end_val = "";
            try
            {
                for (int i = 0; i < size; i++)
                {
                    str_start_val += "0";
                    str_end_val += "9";
                }

                int_min_val = int.Parse(str_start_val);
                int_max_val = int.Parse(str_end_val);

                Random rand = new Random();

                ret_val = rand.Next(int_min_val, int_max_val);

            }
            catch (Exception ex)
            {
            }


            return ret_val;
        }

        // Create a method to encrypt a text and save it to a specific file using a RSA algorithm public key   
        public static string EncryptText(string publicKey, string text)
        {
            // Convert the text to an array of bytes   
            UnicodeEncoding byteConverter = new UnicodeEncoding();
            byte[] dataToEncrypt = byteConverter.GetBytes(text);

            // Create a byte array to store the encrypted data in it   
            byte[] encryptedData;
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                // Set the rsa pulic key   
                rsa.FromXmlString(publicKey);

                // Encrypt the data and store it in the encyptedData Array   
                encryptedData = rsa.Encrypt(dataToEncrypt, false);
            }
            // Save the encypted data array into a file   
            //File.WriteAllBytes(fileName, encryptedData);

            Console.WriteLine("Data has been encrypted");
            return byteConverter.GetString(encryptedData);
        }

        // Method to decrypt the data withing a specific file using a RSA algorithm private key   
        public static string DecryptData(string privateKey, byte[] dataToDecrypt)
        {
            // Create an array to store the decrypted data in it   
            byte[] decryptedData;
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                // Set the private key of the algorithm   
                rsa.FromXmlString(privateKey);
                decryptedData = rsa.Decrypt(dataToDecrypt, false);
            }

            // Get the string value from the decryptedData byte array   
            UnicodeEncoding byteConverter = new UnicodeEncoding();
            return byteConverter.GetString(decryptedData);
        }
    }
}
