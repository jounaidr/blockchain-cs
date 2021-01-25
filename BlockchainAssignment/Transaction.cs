using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BlockchainAssignment
{
    class Transaction
    {
        String hash;
        String signature;
        String senderAddress;
        String recipientAddress;

        DateTime timestamp;

        double transactionValue;
        double fee;

        public Transaction(String senderAddress, String recipientAddress, double transactionValue, double fee, String privateKey)
        {
            this.senderAddress = senderAddress;
            this.recipientAddress = recipientAddress;
            this.transactionValue = transactionValue;
            this.fee = fee;

            this.timestamp = DateTime.Now;

            this.hash = generateHash();
            this.signature = Wallet.Wallet.CreateSignature(senderAddress, privateKey, this.hash);
        }

        public String generateHash()
        {
            String inputString = timestamp.ToString() + senderAddress + recipientAddress + transactionValue.ToString() + fee.ToString();

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
