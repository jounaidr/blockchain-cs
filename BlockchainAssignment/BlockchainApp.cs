using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BlockchainAssignment
{
    public partial class BlockchainApp : Form
    {
        Blockchain blockchain;
        public BlockchainApp()
        {
            InitializeComponent();
            this.blockchain = new Blockchain();

            TextOutput.Text = "New Blockchain initialised";
        }

        private void print(String input)
        {
            TextOutput.Text = input;
        }

        private void Print_Click(object sender, EventArgs e)
        {
            int index = 0;
            if (Int32.TryParse(TextInput.Text, out index))
            {
                print(this.blockchain.chain[index].ToString());
            }
            else
            {
                print(this.blockchain.ToString());
            }
        }

        private void generateWallet_Click(object sender, EventArgs e)
        {
            String privateKey;
            Wallet.Wallet newWallet = new Wallet.Wallet(out privateKey);
            publicKeyTextBox.Text = newWallet.publicID;
            privateKeyTextBox.Text = privateKey;
        }

        private void validateKeys_Click(object sender, EventArgs e)
        {
            if (Wallet.Wallet.ValidatePrivateKey(privateKeyTextBox.Text, publicKeyTextBox.Text))
            {
                print("Keys validation successful!");
            }
            else
            {
                print("Keys validation unsuccsessful!");
            }
        }

        private void generateBlockButton_Click(object sender, EventArgs e)
        {
            List<Transaction> transactions = blockchain.getTrasnactions();

            Block newBlock = new Block(blockchain.getLastBlock(), transactions, publicKeyTextBox.Text);
            blockchain.chain.Add(newBlock);

            print(blockchain.getLastBlock().ToString());
        }

        private void createTransactionButton_Click(object sender, EventArgs e)
        {
            // Check wallet has sufficent balance before creating transaction
            if ((Double.Parse(amountTextBox.Text) + Double.Parse(feeTextBox.Text)) <= blockchain.getBalance(publicKeyTextBox.Text))
            {
                Transaction transaction = new Transaction(publicKeyTextBox.Text, recipientKeyTextBox.Text, Double.Parse(amountTextBox.Text), Double.Parse(feeTextBox.Text), privateKeyTextBox.Text);
                if (Wallet.Wallet.ValidateSignature(transaction.senderAddress, transaction.hash, transaction.signature))
                {
                    blockchain.transactionPool.Add(transaction);
                    print(transaction.ToString());
                }
                else
                {
                    print("Transaction invalid");
                }
            }
            else
            {
                print("Insufficient Balance");
            }

        }

        private void validateChainButton_Click(object sender, EventArgs e)
        {
            if (!blockchain.validateTransactionPool())
            {
                print("Transaction pool has invalid transactions");
            }
            if (blockchain.chain.Count == 1)
            {
                if (!blockchain.validateHash(blockchain.chain[0]))
                    print("Blockchain is invalid");
                else
                    print("Blockchain is valid");
                return;
            }

            for (int i = 1; i < blockchain.chain.Count - 1; i++)
            {
                if (
                    blockchain.chain[i].previousHash != blockchain.chain[i - 1].hash ||
                    !blockchain.validateHash(blockchain.chain[i]) ||
                    !blockchain.validateMerkleRoot(blockchain.chain[i])
                )
                {
                    print("Blockchain is invalid");
                    return;
                }
            }
            print("Blockchain is valid");
        }

        private void checkBalanceButton_Click(object sender, EventArgs e)
        {
            print(blockchain.getBalance(publicKeyTextBox.Text).ToString());
        }

        private void generateBlockAltruisticButton_Click(object sender, EventArgs e)
        {
            List<Transaction> transactions = blockchain.getTrasnactionsOldest();

            Block newBlock = new Block(blockchain.getLastBlock(), transactions, publicKeyTextBox.Text);
            blockchain.chain.Add(newBlock);

            print(blockchain.getLastBlock().ToString());
        }

        private void generateBlockUnpredicatbleButton_Click(object sender, EventArgs e)
        {
            List<Transaction> transactions = blockchain.getTrasnactionsRandom();

            Block newBlock = new Block(blockchain.getLastBlock(), transactions, publicKeyTextBox.Text);
            blockchain.chain.Add(newBlock);

            print(blockchain.getLastBlock().ToString());
        }

        private void generateBlockGreedyButton_Click(object sender, EventArgs e)
        {
            List<Transaction> transactions = blockchain.getTrasnactionsGreedy();

            Block newBlock = new Block(blockchain.getLastBlock(), transactions, publicKeyTextBox.Text);
            blockchain.chain.Add(newBlock);

            print(blockchain.getLastBlock().ToString());
        }

        private void generateBlockAddressBasedButton_Click(object sender, EventArgs e)
        {
            List<Transaction> transactions = blockchain.getTrasnactionsAddress(publicKeyTextBox.Text);

            Block newBlock = new Block(blockchain.getLastBlock(), transactions, publicKeyTextBox.Text);
            blockchain.chain.Add(newBlock);

            print(blockchain.getLastBlock().ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //TODO: UNUSED GENERATED HANDLE, REMOVE
        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            //TODO: UNUSED GENERATED HANDLE, REMOVE
        }

        private void TextInput_TextChanged(object sender, EventArgs e)
        {
            //TODO: UNUSED GENERATED HANDLE, REMOVE
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //TODO: UNUSED GENERATED HANDLE, REMOVE
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //TODO: UNUSED GENERATED HANDLE, REMOVE
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //TODO: UNUSED GENERATED HANDLE, REMOVE
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //TODO: UNUSED GENERATED HANDLE, REMOVE
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //TODO: UNUSED GENERATED HANDLE, REMOVE
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            //TODO: UNUSED GENERATED HANDLE, REMOVE
        }
    }
}
