using Microsoft.Practices.EnterpriseLibrary.Security.Cryptography;
using Microsoft.Practices.EnterpriseLibrary.Security.Cryptography.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using System.Collections.Specialized;
using System;

namespace DGTEL.CryptograpyLibrary
{
    [ConfigurationElementType(typeof(CustomSymmetricCryptoProviderData))]
    public class DemoSymmetricProvider : ISymmetricCryptoProvider
    {
        public DemoSymmetricProvider(NameValueCollection attributes)
        {
        }

        #region ISymmetricCryptoProvider Members

        public byte[] Decrypt(byte[] ciphertext)
        {
            byte[] result = new byte[ciphertext.Length];
            // This code is to show where to place code.  It is not intended to show
            // an effective encryption algorithm
            for (int idx = 0; idx < ciphertext.Length; idx++)
            {
                result[idx] = (byte)(ciphertext[idx] ^ Convert.ToByte('A'));
            }

            return result;
        }

        public byte[] Encrypt(byte[] plaintext)
        {
            byte[] result = new byte[plaintext.Length];
            // This code is to show where to place code.  It is not intended to show
            // an effective encryption algorithm
            for (int idx = 0; idx < plaintext.Length; idx++)
            {
                result[idx] = (byte)(plaintext[idx] ^ Convert.ToByte('A'));
            }

            return result;
        }

        #endregion
    }
}

