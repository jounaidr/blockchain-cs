using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Print_Click(object sender, EventArgs e)
        {
            int index = 0;
            if(Int32.TryParse(TextInput.Text, out index))
            {
                TextOutput.Text = this.blockchain.getBlockAsString(index);
            }
        }

        private void TextInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            if(Wallet.Wallet.ValidatePrivateKey(privateKeyTextBox.Text, publicKeyTextBox.Text))
            {
                TextOutput.Text = "Keys validation successful!";
            }
            else
            {
                TextOutput.Text = "Keys validation unsuccsessful!";
            }
        }
    }
}
