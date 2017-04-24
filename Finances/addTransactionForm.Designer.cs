namespace Finances
{
    partial class addTransactionForm
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
            this.transactionSource = new System.Windows.Forms.ComboBox();
            this.transactionValueInput = new System.Windows.Forms.TextBox();
            this.transactionSourceLabel = new System.Windows.Forms.Label();
            this.transactionValueLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // transactionSource
            // 
            this.transactionSource.FormattingEnabled = true;
            this.transactionSource.Location = new System.Drawing.Point(48, 44);
            this.transactionSource.Name = "transactionSource";
            this.transactionSource.Size = new System.Drawing.Size(121, 21);
            this.transactionSource.TabIndex = 0;
            // 
            // transactionValueInput
            // 
            this.transactionValueInput.Location = new System.Drawing.Point(217, 44);
            this.transactionValueInput.Name = "transactionValueInput";
            this.transactionValueInput.Size = new System.Drawing.Size(100, 20);
            this.transactionValueInput.TabIndex = 1;
            // 
            // transactionSourceLabel
            // 
            this.transactionSourceLabel.AutoSize = true;
            this.transactionSourceLabel.Location = new System.Drawing.Point(48, 25);
            this.transactionSourceLabel.Name = "transactionSourceLabel";
            this.transactionSourceLabel.Size = new System.Drawing.Size(100, 13);
            this.transactionSourceLabel.TabIndex = 2;
            this.transactionSourceLabel.Text = "Transaction Source";
            // 
            // transactionValueLabel
            // 
            this.transactionValueLabel.AutoSize = true;
            this.transactionValueLabel.Location = new System.Drawing.Point(217, 25);
            this.transactionValueLabel.Name = "transactionValueLabel";
            this.transactionValueLabel.Size = new System.Drawing.Size(93, 13);
            this.transactionValueLabel.TabIndex = 3;
            this.transactionValueLabel.Text = "Transaction Value";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(51, 200);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // addTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 261);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.transactionValueLabel);
            this.Controls.Add(this.transactionSourceLabel);
            this.Controls.Add(this.transactionValueInput);
            this.Controls.Add(this.transactionSource);
            this.Name = "addTransactionForm";
            this.Text = "addTransactionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox transactionSource;
        private System.Windows.Forms.TextBox transactionValueInput;
        private System.Windows.Forms.Label transactionSourceLabel;
        private System.Windows.Forms.Label transactionValueLabel;
        private System.Windows.Forms.Button submitButton;
    }
}