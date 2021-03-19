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
            chain.Add(new Block()); //Initialise blockchain with genensis block
        }

        public Block getLastBlock()
        {
            return chain.LastOrDefault();
        }

        public List<Transaction> getTrasnactions()
        {
            int n = Math.Min(MAX_TRANSACTIONS, transactionPool.Count); //Calculate the number of transactions to take from the pool (max 5)

            List<Transaction> pendingTransactions = transactionPool.GetRange(0, n); //Take the first n transations (either max transactions or all the transactions in the pool) 
            transactionPool.RemoveRange(0, n); //Remove the first n transactions from the transaction pool

            return pendingTransactions; //Return selected transactions
        }

        public List<Transaction> getTrasnactionsOldest()
        {
            int n = Math.Min(MAX_TRANSACTIONS, transactionPool.Count); //Calculate the number of transactions to take from the pool (max 5)

            List<Transaction> pendingTransactions = transactionPool.OrderBy(transaction => transaction.timestamp).Take(n).ToList(); //Order the transaction pool by timestamp and take the oldest n transactions
            transactionPool = transactionPool.OrderBy(transaction => transaction.timestamp).Skip(n).ToList(); //Remove oldest n transactions from transaction pool

            return pendingTransactions; //Return selected transactions
        }

        public List<Transaction> getTrasnactionsRandom()
        {
            int n = Math.Min(MAX_TRANSACTIONS, transactionPool.Count); //Calculate the number of transactions to take from the pool (max 5)
            List<Transaction> pendingTransactions = new List<Transaction>();

            Random rnd = new Random();

            for (int i = 0; i < n; i++) //For each transaction to take...
            {
                int randomIndex = rnd.Next(transactionPool.Count - 1); //Select a random integer
                //Take the transaction at selected index and remove it from the pool
                pendingTransactions.Add(transactionPool[randomIndex]);
                transactionPool.RemoveAt(randomIndex);
            }

            return pendingTransactions; //Return selected transactions
        }

        public List<Transaction> getTrasnactionsGreedy()
        {
            int n = Math.Min(MAX_TRANSACTIONS, transactionPool.Count); //Calculate the number of transactions to take from the pool (max 5)

            List<Transaction> pendingTransactions = transactionPool.OrderByDescending(transaction => transaction.fee).Take(n).ToList(); //Order the transaction pool by fee and take the highest fee n transactions
            transactionPool = transactionPool.OrderByDescending(transaction => transaction.fee).Skip(n).ToList(); //Remove selected transaction from transaction pool

            return pendingTransactions; //Return selected transactions
        }

        public List<Transaction> getTrasnactionsAddress(String address)
        {
            int n = Math.Min(MAX_TRANSACTIONS, transactionPool.Count); //Calculate the number of transactions to take from the pool (max 5)
            List<Transaction> pendingTransactions = new List<Transaction>();

            for (int i = 0; i < n; i++) //For each transaction to take...
            {
                //Search the transaction pool for the first occurance of a transaction with the specified sender address
                int addressIndex = transactionPool.FindIndex(transaction => transaction.senderAddress == address); 
                if(addressIndex != -1) //If there is a match...
                {
                    //Take the transaction at selected index and remove it from the pool
                    pendingTransactions.Add(transactionPool[addressIndex]);
                    transactionPool.RemoveAt(addressIndex);
                }
            }

            return pendingTransactions; //Return selected transactions
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

        public bool validateTransactionPool()
        {
            return transactionPool.All(transaction => Wallet.Wallet.ValidateSignature(transaction.senderAddress, transaction.hash, transaction.signature));
        }

        public override string ToString()
        {
            return "BLOCKCHAIN: \n" + string.Join("\n", chain) 
                + "\nTRANSACTION POOL: \n" + string.Join("\n", transactionPool);
        }
    }
}
