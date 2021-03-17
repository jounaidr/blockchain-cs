using BlockchainAssignment.HashCode;
using Newtonsoft.Json;
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
        public String hash;
        public String signature;
        public String senderAddress;
        public String recipientAddress;

        public DateTime timestamp;

        public double transactionValue;
        public double fee;

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
            String hash = new ShaUtil().generateHash(
                timestamp.ToString() 
                + senderAddress 
                + recipientAddress 
                + transactionValue.ToString() 
                + fee.ToString());

            return hash;
        }

        public override string ToString()
        {
            return "TRANSACTION: " + JsonConvert.SerializeObject(this);
        }
    }
}
