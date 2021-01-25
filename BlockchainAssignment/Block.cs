using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BlockchainAssignment
{
    class Block
    {
        public int index;
        public DateTime timestamp;
        public String hash;
        public String previousHash;

        public Block()
        {
            this.timestamp = DateTime.Now; //possibe future issues with verification here
            this.index = 0;
            this.previousHash = String.Empty;
            this.hash = this.generateHash();
        }

        public Block(int index, String previousHash)
        {
            this.timestamp = DateTime.Now;
            this.index = index + 1;
            this.previousHash = previousHash;

            this.hash = this.generateHash();
        }

        public Block(Block lastBlock)
        {
            this.timestamp = DateTime.Now;
            this.index = lastBlock.index++;
            this.previousHash = lastBlock.hash;

            this.hash = this.generateHash();
        }

        public String generateHash()
        {
            String inputString = index.ToString() + timestamp.ToString() + previousHash;

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

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
