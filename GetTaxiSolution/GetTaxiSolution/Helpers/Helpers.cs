using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace GetTaxiSolution.Helpers
{
    public class Helpers
    {
        public const string PASSWORD_SALT = "test";
        public static string GetPasswordHash(string salt)
        {
            byte[] hash = new SHA1Managed().ComputeHash(Encoding.UTF8.GetBytes(salt));
            string hashstr = BitConverter.ToString(hash).Replace("-", "X");
            return hashstr;
        }
    }
}