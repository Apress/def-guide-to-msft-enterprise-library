using Microsoft.Practices.EnterpriseLibrary.Security.Cryptography;
using Microsoft.Practices.EnterpriseLibrary.Security.Cryptography.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using System.Security.Cryptography;
using System.Collections.Specialized;
namespace DGTEL.CryptograpyLibrary
{
    [ConfigurationElementType(typeof(CustomHashProviderData))]
    public class DemoHashProvider : IHashProvider
    {
        public DemoHashProvider(NameValueCollection attributes)
        {
        }

        #region IHashProvider Members

        public bool CompareHash(byte[] plaintext, byte[] hashedtext)
        {
            MD5CryptoServiceProvider md5Provider = new MD5CryptoServiceProvider();
            byte[] tempHash = md5Provider.ComputeHash(plaintext);

            bool match = false;
            if (hashedtext.Length == tempHash.Length)
            {
                int i = 0;
                while ((i < hashedtext.Length) && (hashedtext[i] == tempHash[i]))
                {
                    i += 1;
                }
                if (i == hashedtext.Length)
                {
                    match = true;
                }
            }

            return match;
        }

        public byte[] CreateHash(byte[] plaintext)
        {
            MD5CryptoServiceProvider md5Provider = new MD5CryptoServiceProvider();
            return md5Provider.ComputeHash(plaintext);
        }

        #endregion
    }
}

