namespace BlockchainAssignment
{
    partial class BlockchainApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextOutput = new System.Windows.Forms.RichTextBox();
            this.Print = new System.Windows.Forms.Button();
            this.TextInput = new System.Windows.Forms.RichTextBox();
            this.generateWallet = new System.Windows.Forms.Button();
            this.publicKeyTextBox = new System.Windows.Forms.TextBox();
            this.privateKeyTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.validateKeys = new System.Windows.Forms.Button();
            this.generateBlockButton = new System.Windows.Forms.Button();
            this.createTransactionButton = new System.Windows.Forms.Button();
            this.amountTextBox = new System.Windows.Forms.RichTextBox();
            this.feeTextBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.recipientKeyTextBox = new System.Windows.Forms.TextBox();
            this.validateChainButton = new System.Windows.Forms.Button();
            this.checkBalanceButton = new System.Windows.Forms.Button();
            this.generateBlockAltruisticButton = new System.Windows.Forms.Button();
            this.generateBlockUnpredicatbleButton = new System.Windows.Forms.Button();
            this.generateBlockGreedyButton = new System.Windows.Forms.Button();
            this.generateBlockAddressBasedButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextOutput
            // 
            this.TextOutput.BackColor = System.Drawing.SystemColors.InfoText;
            this.TextOutput.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TextOutput.Location = new System.Drawing.Point(12, 12);
            this.TextOutput.Name = "TextOutput";
            this.TextOutput.Size = new System.Drawing.Size(1415, 569);
            this.TextOutput.TabIndex = 0;
            this.TextOutput.Text = "";
            this.TextOutput.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Print
            // 
            this.Print.Location = new System.Drawing.Point(12, 587);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(70, 22);
            this.Print.TabIndex = 1;
            this.Print.Text = "Print Block";
            this.Print.UseVisualStyleBackColor = true;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // TextInput
            // 
            this.TextInput.Location = new System.Drawing.Point(88, 587);
            this.TextInput.Name = "TextInput";
            this.TextInput.Size = new System.Drawing.Size(50, 22);
            this.TextInput.TabIndex = 2;
            this.TextInput.Text = "";
            this.TextInput.TextChanged += new System.EventHandler(this.TextInput_TextChanged);
            // 
            // generateWallet
            // 
            this.generateWallet.Location = new System.Drawing.Point(1330, 585);
            this.generateWallet.Name = "generateWallet";
            this.generateWallet.Size = new System.Drawing.Size(97, 52);
            this.generateWallet.TabIndex = 3;
            this.generateWallet.Text = "Generate Wallet";
            this.generateWallet.UseVisualStyleBackColor = true;
            this.generateWallet.Click += new System.EventHandler(this.generateWallet_Click);
            // 
            // publicKeyTextBox
            // 
            this.publicKeyTextBox.Location = new System.Drawing.Point(1084, 589);
            this.publicKeyTextBox.Name = "publicKeyTextBox";
            this.publicKeyTextBox.Size = new System.Drawing.Size(240, 20);
            this.publicKeyTextBox.TabIndex = 4;
            // 
            // privateKeyTextBox
            // 
            this.privateKeyTextBox.Location = new System.Drawing.Point(1084, 617);
            this.privateKeyTextBox.Name = "privateKeyTextBox";
            this.privateKeyTextBox.Size = new System.Drawing.Size(240, 20);
            this.privateKeyTextBox.TabIndex = 6;
            this.privateKeyTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1021, 592);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Public Key";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1017, 620);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Private Key";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // validateKeys
            // 
            this.validateKeys.Location = new System.Drawing.Point(1330, 646);
            this.validateKeys.Name = "validateKeys";
            this.validateKeys.Size = new System.Drawing.Size(97, 26);
            this.validateKeys.TabIndex = 9;
            this.validateKeys.Text = "Validate Keys";
            this.validateKeys.UseVisualStyleBackColor = true;
            this.validateKeys.Click += new System.EventHandler(this.validateKeys_Click);
            // 
            // generateBlockButton
            // 
            this.generateBlockButton.Location = new System.Drawing.Point(12, 649);
            this.generateBlockButton.Name = "generateBlockButton";
            this.generateBlockButton.Size = new System.Drawing.Size(95, 49);
            this.generateBlockButton.TabIndex = 10;
            this.generateBlockButton.Text = "Generate Block (default)";
            this.generateBlockButton.UseVisualStyleBackColor = true;
            this.generateBlockButton.Click += new System.EventHandler(this.generateBlockButton_Click);
            // 
            // createTransactionButton
            // 
            this.createTransactionButton.Location = new System.Drawing.Point(12, 704);
            this.createTransactionButton.Name = "createTransactionButton";
            this.createTransactionButton.Size = new System.Drawing.Size(95, 49);
            this.createTransactionButton.TabIndex = 11;
            this.createTransactionButton.Text = "Create Transaction";
            this.createTransactionButton.UseVisualStyleBackColor = true;
            this.createTransactionButton.Click += new System.EventHandler(this.createTransactionButton_Click);
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(162, 704);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(50, 20);
            this.amountTextBox.TabIndex = 12;
            this.amountTextBox.Text = "";
            this.amountTextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged_1);
            // 
            // feeTextBox
            // 
            this.feeTextBox.Location = new System.Drawing.Point(162, 733);
            this.feeTextBox.Name = "feeTextBox";
            this.feeTextBox.Size = new System.Drawing.Size(50, 20);
            this.feeTextBox.TabIndex = 13;
            this.feeTextBox.Text = "";
            this.feeTextBox.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 708);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Amount";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 740);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Fee";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 708);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Recipient Key";
            // 
            // recipientKeyTextBox
            // 
            this.recipientKeyTextBox.Location = new System.Drawing.Point(306, 704);
            this.recipientKeyTextBox.Name = "recipientKeyTextBox";
            this.recipientKeyTextBox.Size = new System.Drawing.Size(240, 20);
            this.recipientKeyTextBox.TabIndex = 17;
            // 
            // validateChainButton
            // 
            this.validateChainButton.Location = new System.Drawing.Point(1330, 678);
            this.validateChainButton.Name = "validateChainButton";
            this.validateChainButton.Size = new System.Drawing.Size(97, 26);
            this.validateChainButton.TabIndex = 18;
            this.validateChainButton.Text = "Validate Chain";
            this.validateChainButton.UseVisualStyleBackColor = true;
            this.validateChainButton.Click += new System.EventHandler(this.validateChainButton_Click);
            // 
            // checkBalanceButton
            // 
            this.checkBalanceButton.Location = new System.Drawing.Point(1330, 710);
            this.checkBalanceButton.Name = "checkBalanceButton";
            this.checkBalanceButton.Size = new System.Drawing.Size(97, 26);
            this.checkBalanceButton.TabIndex = 19;
            this.checkBalanceButton.Text = "Check Balance";
            this.checkBalanceButton.UseVisualStyleBackColor = true;
            this.checkBalanceButton.Click += new System.EventHandler(this.checkBalanceButton_Click);
            // 
            // generateBlockAltruisticButton
            // 
            this.generateBlockAltruisticButton.Location = new System.Drawing.Point(117, 649);
            this.generateBlockAltruisticButton.Name = "generateBlockAltruisticButton";
            this.generateBlockAltruisticButton.Size = new System.Drawing.Size(95, 49);
            this.generateBlockAltruisticButton.TabIndex = 20;
            this.generateBlockAltruisticButton.Text = "Generate Block (altruistic)";
            this.generateBlockAltruisticButton.UseVisualStyleBackColor = true;
            this.generateBlockAltruisticButton.Click += new System.EventHandler(this.generateBlockAltruisticButton_Click);
            // 
            // generateBlockUnpredicatbleButton
            // 
            this.generateBlockUnpredicatbleButton.Location = new System.Drawing.Point(218, 649);
            this.generateBlockUnpredicatbleButton.Name = "generateBlockUnpredicatbleButton";
            this.generateBlockUnpredicatbleButton.Size = new System.Drawing.Size(95, 49);
            this.generateBlockUnpredicatbleButton.TabIndex = 21;
            this.generateBlockUnpredicatbleButton.Text = "Generate Block (unpredicatble)";
            this.generateBlockUnpredicatbleButton.UseVisualStyleBackColor = true;
            this.generateBlockUnpredicatbleButton.Click += new System.EventHandler(this.generateBlockUnpredicatbleButton_Click);
            // 
            // generateBlockGreedyButton
            // 
            this.generateBlockGreedyButton.Location = new System.Drawing.Point(319, 649);
            this.generateBlockGreedyButton.Name = "generateBlockGreedyButton";
            this.generateBlockGreedyButton.Size = new System.Drawing.Size(95, 49);
            this.generateBlockGreedyButton.TabIndex = 22;
            this.generateBlockGreedyButton.Text = "Generate Block (greedy)";
            this.generateBlockGreedyButton.UseVisualStyleBackColor = true;
            this.generateBlockGreedyButton.Click += new System.EventHandler(this.generateBlockGreedyButton_Click);
            // 
            // generateBlockAddressBasedButton
            // 
            this.generateBlockAddressBasedButton.Location = new System.Drawing.Point(420, 649);
            this.generateBlockAddressBasedButton.Name = "generateBlockAddressBasedButton";
            this.generateBlockAddressBasedButton.Size = new System.Drawing.Size(95, 49);
            this.generateBlockAddressBasedButton.TabIndex = 23;
            this.generateBlockAddressBasedButton.Text = "Generate Block (personal)";
            this.generateBlockAddressBasedButton.UseVisualStyleBackColor = true;
            this.generateBlockAddressBasedButton.Click += new System.EventHandler(this.generateBlockAddressBasedButton_Click);
            // 
            // BlockchainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1441, 767);
            this.Controls.Add(this.generateBlockAddressBasedButton);
            this.Controls.Add(this.generateBlockGreedyButton);
            this.Controls.Add(this.generateBlockUnpredicatbleButton);
            this.Controls.Add(this.generateBlockAltruisticButton);
            this.Controls.Add(this.checkBalanceButton);
            this.Controls.Add(this.validateChainButton);
            this.Controls.Add(this.recipientKeyTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.feeTextBox);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.createTransactionButton);
            this.Controls.Add(this.generateBlockButton);
            this.Controls.Add(this.validateKeys);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.privateKeyTextBox);
            this.Controls.Add(this.publicKeyTextBox);
            this.Controls.Add(this.generateWallet);
            this.Controls.Add(this.TextInput);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.TextOutput);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "BlockchainApp";
            this.Text = "Blockchain App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox TextOutput;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.RichTextBox TextInput;
        private System.Windows.Forms.Button generateWallet;
        private System.Windows.Forms.TextBox publicKeyTextBox;
        private System.Windows.Forms.TextBox privateKeyTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button validateKeys;
        private System.Windows.Forms.Button generateBlockButton;
        private System.Windows.Forms.Button createTransactionButton;
        private System.Windows.Forms.RichTextBox amountTextBox;
        private System.Windows.Forms.RichTextBox feeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox recipientKeyTextBox;
        private System.Windows.Forms.Button validateChainButton;
        private System.Windows.Forms.Button checkBalanceButton;
        private System.Windows.Forms.Button generateBlockAltruisticButton;
        private System.Windows.Forms.Button generateBlockUnpredicatbleButton;
        private System.Windows.Forms.Button generateBlockGreedyButton;
        private System.Windows.Forms.Button generateBlockAddressBasedButton;
    }
}

