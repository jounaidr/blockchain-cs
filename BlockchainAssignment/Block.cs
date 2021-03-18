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
        const int THREADS = 24;
        const double TARGET_BLOCK_TIME = 0.1;

        public int index;
        public DateTime timestamp;
        public String hash;
        public String previousHash;

        public double nonce = 0;
        public double enonce = 0;
        public int difficulty;

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
            this.timestamp = DateTime.Now; //Set block timestamp to time before hash is mined
            this.index = lastBlock.index + 1; //Incremenet block index
            this.previousHash = lastBlock.hash;

            if (lastBlock.blockTime < TARGET_BLOCK_TIME)
            {
                //If previous blocks block time is less then the target block time, increase difficulty
                this.difficulty = lastBlock.difficulty + 1;
            }
            else
            {
                //Else, decrease the difficulty
                this.difficulty = lastBlock.difficulty - 1;
            }

            this.minerAddress = minerAddress; //Set the address of the miner who is generating the block

            transactions.Add(createRewardTransaction(transactions)); //Add the reward transaction to the block for the miner
            this.transactions = transactions; 
            this.merkleRoot = generateMerkleRoot(transactions); //Calculate merkleroot of transactions

            isHashFound = false; //Set the hash found flag to false before mining hash (used for threading)
            this.mineBlockThreaded(); //Mine the hash
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
            WaitHandle[] waitHandles = new WaitHandle[THREADS]; //Initialise WaitHandle flags for each thread
            Random rnd = new Random();

            for (int i = 0; i < THREADS; i++) //For each thread...
            {
                var handle = new EventWaitHandle(false, EventResetMode.ManualReset); //Initialise the handle flag for the thread

                new Thread(delegate ()
                {
                    //Initialise thread local hash and nonce variables
                    String currentHash = generateHash();
                    int threadNonce = 0;
                    int threadEnone = rnd.Next(1, int.MaxValue);
                    //Generate a string of 0's that satisfies the difficulty (to be used for hash matching)
                    String hashDifficulty = new string('0', difficulty);

                    while (!isHashFound)
                    {
                        threadNonce++; //Increment thread nonce
                        currentHash = new ShaUtil().generateHash( //Generate hash using thread local variables
                                                                index.ToString()
                                                                + timestamp.ToString()
                                                                + previousHash
                                                                + threadNonce.ToString()
                                                                + threadEnone.ToString()
                                                                + reward.ToString()
                                                                + merkleRoot);

                        if (currentHash.StartsWith(hashDifficulty))
                        {
                            //If hash is found in the thread, set the global isHashFound flag to true (so other threads will stop mining)
                            isHashFound = true;

                            TimeSpan timeDiff = DateTime.Now - this.timestamp;
                            blockTime = timeDiff.TotalSeconds; //Calculate blocktime as time diff between block timestamp and time when hash found
                            //Set global block hash and nonce parameters to the thread local parameters 
                            this.nonce = threadNonce;
                            this.enonce = threadEnone;
                            this.hash = currentHash;
                            handle.Set(); //Set the thread handle flag so main thread can continue...
                        }
                    }
                }).Start();
                waitHandles[i] = handle;
            }
            WaitHandle.WaitAny(waitHandles); //Wait until any thread handle flag is set
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
