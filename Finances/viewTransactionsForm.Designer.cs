namespace Finances
{
    partial class viewTransactionsForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.transactionSource = new System.Windows.Forms.ComboBox();
            this.transactionSourceLabel = new System.Windows.Forms.Label();
            this.afterLabel = new System.Windows.Forms.Label();
            this.beforeLabel = new System.Windows.Forms.Label();
            this.afterDateSource = new System.Windows.Forms.MonthCalendar();
            this.beforeDateSource = new System.Windows.Forms.MonthCalendar();
            this.filterButton = new System.Windows.Forms.Button();
            this.ignoreInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(847, 236);
            this.dataGridView1.TabIndex = 0;
            // 
            // transactionSource
            // 
            this.transactionSource.FormattingEnabled = true;
            this.transactionSource.Location = new System.Drawing.Point(12, 294);
            this.transactionSource.Name = "transactionSource";
            this.transactionSource.Size = new System.Drawing.Size(121, 21);
            this.transactionSource.TabIndex = 1;
            // 
            // transactionSourceLabel
            // 
            this.transactionSourceLabel.AutoSize = true;
            this.transactionSourceLabel.Location = new System.Drawing.Point(12, 272);
            this.transactionSourceLabel.Name = "transactionSourceLabel";
            this.transactionSourceLabel.Size = new System.Drawing.Size(100, 13);
            this.transactionSourceLabel.TabIndex = 3;
            this.transactionSourceLabel.Text = "Transaction Source";
            // 
            // afterLabel
            // 
            this.afterLabel.AutoSize = true;
            this.afterLabel.Location = new System.Drawing.Point(340, 272);
            this.afterLabel.Name = "afterLabel";
            this.afterLabel.Size = new System.Drawing.Size(32, 13);
            this.afterLabel.TabIndex = 4;
            this.afterLabel.Text = "After:";
            // 
            // beforeLabel
            // 
            this.beforeLabel.AutoSize = true;
            this.beforeLabel.Location = new System.Drawing.Point(625, 272);
            this.beforeLabel.Name = "beforeLabel";
            this.beforeLabel.Size = new System.Drawing.Size(41, 13);
            this.beforeLabel.TabIndex = 6;
            this.beforeLabel.Text = "Before:";
            // 
            // afterDateSource
            // 
            this.afterDateSource.Location = new System.Drawing.Point(247, 294);
            this.afterDateSource.MaxSelectionCount = 1;
            this.afterDateSource.Name = "afterDateSource";
            this.afterDateSource.TabIndex = 7;
            // 
            // beforeDateSource
            // 
            this.beforeDateSource.Location = new System.Drawing.Point(538, 294);
            this.beforeDateSource.MaxSelectionCount = 1;
            this.beforeDateSource.Name = "beforeDateSource";
            this.beforeDateSource.TabIndex = 8;
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(12, 420);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(75, 23);
            this.filterButton.TabIndex = 9;
            this.filterButton.Text = "Filter";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // ignoreInfo
            // 
            this.ignoreInfo.AutoSize = true;
            this.ignoreInfo.Location = new System.Drawing.Point(433, 252);
            this.ignoreInfo.Name = "ignoreInfo";
            this.ignoreInfo.Size = new System.Drawing.Size(157, 13);
            this.ignoreInfo.TabIndex = 10;
            this.ignoreInfo.Text = "Leave date on \'Today\' to ignore";
            // 
            // viewTransactionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 455);
            this.Controls.Add(this.ignoreInfo);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.beforeDateSource);
            this.Controls.Add(this.afterDateSource);
            this.Controls.Add(this.beforeLabel);
            this.Controls.Add(this.afterLabel);
            this.Controls.Add(this.transactionSourceLabel);
            this.Controls.Add(this.transactionSource);
            this.Controls.Add(this.dataGridView1);
            this.Name = "viewTransactionsForm";
            this.Text = "viewTransactionsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox transactionSource;
        private System.Windows.Forms.Label transactionSourceLabel;
        private System.Windows.Forms.Label afterLabel;
        private System.Windows.Forms.Label beforeLabel;
        private System.Windows.Forms.MonthCalendar afterDateSource;
        private System.Windows.Forms.MonthCalendar beforeDateSource;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Label ignoreInfo;
    }
}