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
            this.SuspendLayout();
            // 
            // TextOutput
            // 
            this.TextOutput.BackColor = System.Drawing.SystemColors.InfoText;
            this.TextOutput.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TextOutput.Location = new System.Drawing.Point(12, 12);
            this.TextOutput.Name = "TextOutput";
            this.TextOutput.Size = new System.Drawing.Size(657, 314);
            this.TextOutput.TabIndex = 0;
            this.TextOutput.Text = "";
            this.TextOutput.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Print
            // 
            this.Print.Location = new System.Drawing.Point(12, 332);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(103, 50);
            this.Print.TabIndex = 1;
            this.Print.Text = "Print";
            this.Print.UseVisualStyleBackColor = true;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // TextInput
            // 
            this.TextInput.Location = new System.Drawing.Point(121, 332);
            this.TextInput.Name = "TextInput";
            this.TextInput.Size = new System.Drawing.Size(548, 50);
            this.TextInput.TabIndex = 2;
            this.TextInput.Text = "";
            this.TextInput.TextChanged += new System.EventHandler(this.TextInput_TextChanged);
            // 
            // BlockchainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(681, 481);
            this.Controls.Add(this.TextInput);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.TextOutput);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "BlockchainApp";
            this.Text = "Blockchain App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox TextOutput;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.RichTextBox TextInput;
    }
}

