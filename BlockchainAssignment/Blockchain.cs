using MoreLinq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockchainAssignment
{
    class Blockchain
    {
        public List<Block> chain = new List<Block>();
        public List<Transaction> transactionPool = new List<Transaction>();

        private const int MAX_TRANSACTIONS = 5;

        public Blockchain()
        {
            chain.Add(new Block()); //could be done with builder
        }

        public Block getLastBlock()
        {
            return chain.LastOrDefault(); //different record this
        }

        public List<Transaction> getTrasnactions()
        {
            int n = Math.Min(MAX_TRANSACTIONS, transactionPool.Count);
            List<Transaction> pendingTransactions = transactionPool.GetRange(0, n);
            transactionPool.RemoveRange(0, n);

            return pendingTransactions;
        }

        public List<Transaction> getTrasnactionsOldest()
        {
            int n = Math.Min(MAX_TRANSACTIONS, transactionPool.Count);

            List<Transaction> pendingTransactions = transactionPool.OrderBy(transaction => transaction.timestamp).Take(n).ToList();
            transactionPool = transactionPool.OrderBy(transaction => transaction.timestamp).Skip(n).ToList();

            return pendingTransactions;
        }

        public List<Transaction> getTrasnactionsRandom()
        {
            int n = Math.Min(MAX_TRANSACTIONS, transactionPool.Count);
            List<Transaction> pendingTransactions = new List<Transaction>();

            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                int randomIndex = rnd.Next(transactionPool.Count - 1);

                pendingTransactions.Add(transactionPool[randomIndex]);
                transactionPool.RemoveAt(randomIndex);
            }

            return pendingTransactions;
        }

        public List<Transaction> getTrasnactionsGreedy()
        {
            int n = Math.Min(MAX_TRANSACTIONS, transactionPool.Count);

            List<Transaction> pendingTransactions = transactionPool.OrderByDescending(transaction => transaction.fee).Take(n).ToList();
            transactionPool = transactionPool.OrderByDescending(transaction => transaction.fee).Skip(n).ToList();

            return pendingTransactions;
        }

        public List<Transaction> getTrasnactionsAddress(String address)
        {
            int n = Math.Min(MAX_TRANSACTIONS, transactionPool.Count);
            List<Transaction> pendingTransactions = new List<Transaction>();

            for (int i = 0; i < n; i++)
            {
                int addressIndex = transactionPool.FindIndex(transaction => transaction.senderAddress == address);
                if(addressIndex != -1)
                {
                    pendingTransactions.Add(transactionPool[addressIndex]);
                    transactionPool.RemoveAt(addressIndex);
                }
            }

            return pendingTransactions;
        }

        public double getBalance(String address)
        {
            double balance = 0.0;

            foreach(Block block in chain)
            {
                foreach (Transaction transaction in block.transactions)
                {
                    if (transaction.recipientAddress.Equals(address))
                    {
                        balance += transaction.transactionValue;
                    }
                    if (transaction.senderAddress.Equals(address))
                    {
                        balance -= (transaction.transactionValue + transaction.fee);
                    }
                }
            }

            return balance;
        }
        public bool validateHash(Block block)
        {
            return block.hash.Equals(block.generateHash());
        }
        public bool validateMerkleRoot(Block block)
        {
            return block.merkleRoot.Equals(Block.generateMerkleRoot(block.transactions));
        }

        public override string ToString()
        {
            return "BLOCKCHAIN: \n" + string.Join("\n", chain) 
                + "\nTRANSACTION POOL: \n" + string.Join("\n", transactionPool);
        }
    }
}
