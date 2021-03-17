using BlockchainAssignment.HashCode;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BlockchainAssignment
{
    class Block
    {
        const int THREADS = 12;

        public int index;
        public DateTime timestamp;
        public String hash;
        public String previousHash;

        public double nonce = 0;
        public double enonce = 0;
        public int difficulty = 5;

        public double reward = 1.0;
        public double fees = 0.0;

        public String minerAddress = "";
        public List<Transaction> transactions = new List<Transaction>();
        public string merkleRoot;

        public double blockTime;
        bool isHashFound;

        public Block()
        {
            this.timestamp = DateTime.Now;
            this.index = 0;
            this.previousHash = String.Empty;
            this.hash = this.generateHash();
        }

        public Block(Block lastBlock, List<Transaction> transactions, String minerAddress = "")
        {
            this.timestamp = DateTime.Now;
            this.index = lastBlock.index + 1;
            this.previousHash = lastBlock.hash;

            this.minerAddress = minerAddress;

            transactions.Add(createRewardTransaction(transactions));
            this.transactions = transactions;
            this.merkleRoot = generateMerkleRoot(transactions);

            isHashFound = false;
            this.mineBlockThreaded();
        }

        public String generateHash()
        {
            String hash = new ShaUtil().generateHash(
                                                    index.ToString() 
                                                    + timestamp.ToString() 
                                                    + previousHash
                                                    + nonce.ToString()
                                                    + enonce.ToString()
                                                    + reward.ToString()
                                                    + merkleRoot);

            return hash;
        }

        public void mineBlockThreaded()
        {
            List<Thread> threads = new List<Thread>();
            WaitHandle[] waitHandles = new WaitHandle[THREADS];

            for (int i = 0; i < THREADS; i++)
            {
                
                Random rnd = new Random();
                var handle = new EventWaitHandle(false, EventResetMode.ManualReset);

                new Thread(delegate ()
                {

                    String currentHash = generateHash();
                    String hashDifficulty = new string('0', difficulty);
                    int threadNonce = 0;
                    int threadEnone = rnd.Next(1, int.MaxValue);

                    while (!isHashFound)
                    {
                        threadNonce++;
                        currentHash = new ShaUtil().generateHash(
                                                                index.ToString()
                                                                + timestamp.ToString()
                                                                + previousHash
                                                                + threadNonce.ToString()
                                                                + threadEnone.ToString()
                                                                + reward.ToString()
                                                                + merkleRoot);

                        if (currentHash.StartsWith(hashDifficulty))
                        {
                            isHashFound = true;

                            TimeSpan timeDiff = DateTime.Now - this.timestamp;
                            blockTime = timeDiff.TotalSeconds;

                            this.nonce = threadNonce;
                            this.enonce = threadEnone;
                            this.hash = currentHash;
                            handle.Set();
                        }
                    }
                }).Start();
                waitHandles[i] = handle;
            }

            WaitHandle.WaitAny(waitHandles);
        }

        public String mineBlock()
        {
            String hash = generateHash();
            String hashDifficulty = new string('0', difficulty);

            while (!hash.StartsWith(hashDifficulty))
            {
                nonce++;
                hash = generateHash();
            }

            TimeSpan timeDiff = DateTime.Now - this.timestamp;
            this.blockTime = timeDiff.TotalSeconds;

            return hash;
        }

        public Transaction createRewardTransaction(List<Transaction> transactions)
        {
            this.fees = transactions.Aggregate(0.0, (acc, t) => acc + t.fee);
            return new Transaction("Miner Rewards", minerAddress , (reward + fees), 0, ""); 
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static String generateMerkleRoot(List<Transaction> transactions)
        {
            List<String> hashes = transactions.Select(t => t.hash).ToList(); // Get a list of transaction hashes for "combining"

            if (hashes.Count == 0) 
            {
                return "";
            }
            if (hashes.Count == 1) 
            {
                return HashCode.HashTools.combineHash(hashes[0], hashes[0]);
            }
            while (hashes.Count != 1) 
            {
                List<String> merkleLeaves = new List<String>(); 

                for (int i = 0; i < hashes.Count; i += 2) 
                {
                    if (i == hashes.Count - 1)
                    {
                        merkleLeaves.Add(HashCode.HashTools.combineHash(hashes[i], hashes[i]));
                    }
                    else
                    {
                        merkleLeaves.Add(HashCode.HashTools.combineHash(hashes[i], hashes[i + 1]));
                    }
                }
                hashes = merkleLeaves; 
            }
            return hashes[0];
        }
    }
}
