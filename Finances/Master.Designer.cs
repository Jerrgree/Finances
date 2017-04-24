namespace Finances
{
    partial class masterForm
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
            this.addTableFormCall = new System.Windows.Forms.Button();
            this.viewData = new System.Windows.Forms.Button();
            this.addTransactionCaller = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addTableFormCall
            // 
            this.addTableFormCall.Location = new System.Drawing.Point(25, 24);
            this.addTableFormCall.Name = "addTableFormCall";
            this.addTableFormCall.Size = new System.Drawing.Size(139, 23);
            this.addTableFormCall.TabIndex = 0;
            this.addTableFormCall.Text = "Add a new table";
            this.addTableFormCall.UseVisualStyleBackColor = true;
            this.addTableFormCall.Click += new System.EventHandler(this.button1_Click);
            // 
            // viewData
            // 
            this.viewData.Location = new System.Drawing.Point(25, 53);
            this.viewData.Name = "viewData";
            this.viewData.Size = new System.Drawing.Size(139, 23);
            this.viewData.TabIndex = 1;
            this.viewData.Text = "View Data";
            this.viewData.UseVisualStyleBackColor = true;
            this.viewData.Click += new System.EventHandler(this.viewData_Click);
            // 
            // addTransactionCaller
            // 
            this.addTransactionCaller.Location = new System.Drawing.Point(25, 82);
            this.addTransactionCaller.Name = "addTransactionCaller";
            this.addTransactionCaller.Size = new System.Drawing.Size(139, 23);
            this.addTransactionCaller.TabIndex = 2;
            this.addTransactionCaller.Text = "Add Transaction";
            this.addTransactionCaller.UseVisualStyleBackColor = true;
            this.addTransactionCaller.Click += new System.EventHandler(this.addTransactionCaller_Click);
            // 
            // masterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 261);
            this.Controls.Add(this.addTransactionCaller);
            this.Controls.Add(this.viewData);
            this.Controls.Add(this.addTableFormCall);
            this.Name = "masterForm";
            this.Text = "Finance Application";
            this.Load += new System.EventHandler(this.Master_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addTableFormCall;
        private System.Windows.Forms.Button viewData;
        private System.Windows.Forms.Button addTransactionCaller;
    }
}