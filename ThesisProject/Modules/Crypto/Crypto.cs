using System.Text;
using System.Security.Cryptography;
using System.Linq;

namespace ThesisProject.Modules.Crypto
{
    internal class Crypto
    {

        public static string GetMD5(string value)
        {
            var result = default(string);
            using (var algo = new MD5CryptoServiceProvider())
            {
                result = GenerateHashString(algo, value);
            }
            return result;
        }
        private static string GenerateHashString(HashAlgorithm algo, string text)
        {
            algo.ComputeHash(Encoding.UTF8.GetBytes(text));
            var result = algo.Hash;
            return string.Join(
            string.Empty,
            result.Select(x => x.ToString("x2")));
        }
    }
}
