using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;

namespace zeus.Classess
{
    class PasswordHash
    {
        //encode password to MD5 hash
        public static string encodePassword(string password)
        {
            Byte[] originalBytes;
            Byte[] encodedBytes;
            MD5 md5;

            // Create MD5 Cryptography Service Provider.
            md5 = new MD5CryptoServiceProvider();
            originalBytes = ASCIIEncoding.Default.GetBytes(password);
            encodedBytes = md5.ComputeHash(originalBytes);

            return BitConverter.ToString(encodedBytes);
        }
        //match current password hash and user enterd password hash
        public static bool passwordMatch(string password, string hash)
        {
            if (encodePassword(password) == hash)
            {
                return true;
            }
            return false;
        }
        //generate passsword
        public static string generatePassword()
        {
            string alphabet = "abcdefghijklmnopqrstuwxyzABCDEFGHIJKLMNOPQRSTUWXYZ0123456789";

            string[] pass = new string[8];
            Random rand = new Random();

            for (int i = 0; i < 8; i++)
            {
                int n = rand.Next(0, alphabet.Length);
                pass[i] = alphabet[n].ToString();
            }
            
            return String.Join("", pass);
        }
    }
}
