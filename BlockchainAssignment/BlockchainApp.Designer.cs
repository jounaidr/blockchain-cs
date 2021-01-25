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
            // BlockchainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1439, 684);
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
    }
}

