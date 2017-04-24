namespace Finances
{
    partial class viewData
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.financeDataDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.financeDataDataSet = new Finances.FinanceDataDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1356, 494);
            this.dataGridView1.TabIndex = 0;
            // 
            // financeDataDataSetBindingSource
            // 
            this.financeDataDataSetBindingSource.DataSource = this.financeDataDataSet;
            this.financeDataDataSetBindingSource.Position = 0;
            // 
            // financeDataDataSet
            // 
            this.financeDataDataSet.DataSetName = "FinanceDataDataSet";
            this.financeDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 518);
            this.Controls.Add(this.dataGridView1);
            this.Name = "viewData";
            this.Text = "viewData";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource financeDataDataSetBindingSource;
        private FinanceDataDataSet financeDataDataSet;
    }
}