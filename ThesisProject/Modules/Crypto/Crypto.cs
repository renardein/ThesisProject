using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThesisProject.Modules.Crypto
{
    internal class Crypto
    {
        public static string GetMD5(string value)
        {
            var provider = new System.Security.Cryptography.MD5CryptoServiceProvider();
            var data = Encoding.UTF8.GetBytes(value);
            data = provider.ComputeHash(data);
            return Encoding.UTF8.GetString(data);
        }
    }
}
