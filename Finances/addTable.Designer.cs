namespace Finances
{
    partial class addTableForm
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
            this.addTable = new System.Windows.Forms.Button();
            this.tableNameLabel = new System.Windows.Forms.Label();
            this.initValueInput = new System.Windows.Forms.TextBox();
            this.initValueLabel = new System.Windows.Forms.Label();
            this.isBankAccount = new System.Windows.Forms.RadioButton();
            this.isCreditCard = new System.Windows.Forms.RadioButton();
            this.tableNameInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addTable
            // 
            this.addTable.Location = new System.Drawing.Point(12, 109);
            this.addTable.Name = "addTable";
            this.addTable.Size = new System.Drawing.Size(75, 23);
            this.addTable.TabIndex = 0;
            this.addTable.Text = "Add Financial SOurce";
            this.addTable.UseVisualStyleBackColor = true;
            this.addTable.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableNameLabel
            // 
            this.tableNameLabel.AutoSize = true;
            this.tableNameLabel.Location = new System.Drawing.Point(9, 35);
            this.tableNameLabel.Name = "tableNameLabel";
            this.tableNameLabel.Size = new System.Drawing.Size(65, 13);
            this.tableNameLabel.TabIndex = 2;
            this.tableNameLabel.Text = "Table Name";
            // 
            // initValueInput
            // 
            this.initValueInput.Location = new System.Drawing.Point(145, 13);
            this.initValueInput.Name = "initValueInput";
            this.initValueInput.Size = new System.Drawing.Size(100, 20);
            this.initValueInput.TabIndex = 3;
            // 
            // initValueLabel
            // 
            this.initValueLabel.AutoSize = true;
            this.initValueLabel.Location = new System.Drawing.Point(142, 46);
            this.initValueLabel.Name = "initValueLabel";
            this.initValueLabel.Size = new System.Drawing.Size(61, 13);
            this.initValueLabel.TabIndex = 4;
            this.initValueLabel.Text = "Initial Value";
            // 
            // isBankAccount
            // 
            this.isBankAccount.AutoSize = true;
            this.isBankAccount.Checked = true;
            this.isBankAccount.Location = new System.Drawing.Point(12, 63);
            this.isBankAccount.Name = "isBankAccount";
            this.isBankAccount.Size = new System.Drawing.Size(93, 17);
            this.isBankAccount.TabIndex = 5;
            this.isBankAccount.TabStop = true;
            this.isBankAccount.Text = "Bank Account";
            this.isBankAccount.UseVisualStyleBackColor = true;
            // 
            // isCreditCard
            // 
            this.isCreditCard.AutoSize = true;
            this.isCreditCard.Location = new System.Drawing.Point(12, 86);
            this.isCreditCard.Name = "isCreditCard";
            this.isCreditCard.Size = new System.Drawing.Size(77, 17);
            this.isCreditCard.TabIndex = 6;
            this.isCreditCard.Text = "Credit Card";
            this.isCreditCard.UseVisualStyleBackColor = true;
            // 
            // tableNameInput
            // 
            this.tableNameInput.Location = new System.Drawing.Point(13, 13);
            this.tableNameInput.Name = "tableNameInput";
            this.tableNameInput.Size = new System.Drawing.Size(100, 20);
            this.tableNameInput.TabIndex = 7;
            // 
            // addTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 140);
            this.Controls.Add(this.tableNameInput);
            this.Controls.Add(this.isCreditCard);
            this.Controls.Add(this.isBankAccount);
            this.Controls.Add(this.initValueLabel);
            this.Controls.Add(this.initValueInput);
            this.Controls.Add(this.tableNameLabel);
            this.Controls.Add(this.addTable);
            this.Name = "addTableForm";
            this.Text = "Add Finance Source";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addTable;
        private System.Windows.Forms.Label tableNameLabel;
        private System.Windows.Forms.Label initValueLabel;
        private System.Windows.Forms.RadioButton isBankAccount;
        private System.Windows.Forms.RadioButton isCreditCard;
        private System.Windows.Forms.TextBox tableNameInput;
        public System.Windows.Forms.TextBox initValueInput;
    }
}

