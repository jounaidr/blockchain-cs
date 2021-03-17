using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BlockchainAssignment.HashCode
{
    class ShaUtil
    {
        public String generateHash(String inputString)
        {
            Byte[] inputBytes = Encoding.UTF8.GetBytes(inputString);
            SHA256Managed messageDigest = new SHA256Managed();
            Byte[] hash = messageDigest.ComputeHash(inputBytes);

            string hashString = string.Empty;
            foreach (byte i in hash)
            {
                hashString += String.Format("{0:x2}", i);
            }

            return hashString;
        }
    }
}
