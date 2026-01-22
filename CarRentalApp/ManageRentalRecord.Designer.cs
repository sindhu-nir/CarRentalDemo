namespace CarRentalApp
{
    partial class ManageRentalRecord
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
            this.label1 = new System.Windows.Forms.Label();
            this.btRefresh = new System.Windows.Forms.Button();
            this.btDeleteRecord = new System.Windows.Forms.Button();
            this.btEditRecord = new System.Windows.Forms.Button();
            this.btAddRecord = new System.Windows.Forms.Button();
            this.gvRecordList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvRecordList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 100, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manage Rental Records";
            // 
            // btRefresh
            // 
            this.btRefresh.Location = new System.Drawing.Point(12, 49);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(133, 37);
            this.btRefresh.TabIndex = 10;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = true;
            // 
            // btDeleteRecord
            // 
            this.btDeleteRecord.Location = new System.Drawing.Point(654, 418);
            this.btDeleteRecord.Name = "btDeleteRecord";
            this.btDeleteRecord.Size = new System.Drawing.Size(133, 37);
            this.btDeleteRecord.TabIndex = 9;
            this.btDeleteRecord.Text = "Delete Record";
            this.btDeleteRecord.UseVisualStyleBackColor = true;
            this.btDeleteRecord.Click += new System.EventHandler(this.btDeleteRecord_Click);
            // 
            // btEditRecord
            // 
            this.btEditRecord.Location = new System.Drawing.Point(279, 418);
            this.btEditRecord.Name = "btEditRecord";
            this.btEditRecord.Size = new System.Drawing.Size(133, 37);
            this.btEditRecord.TabIndex = 8;
            this.btEditRecord.Text = "Edit Record";
            this.btEditRecord.UseVisualStyleBackColor = true;
            this.btEditRecord.Click += new System.EventHandler(this.btEditRecord_Click);
            // 
            // btAddRecord
            // 
            this.btAddRecord.Location = new System.Drawing.Point(12, 418);
            this.btAddRecord.Name = "btAddRecord";
            this.btAddRecord.Size = new System.Drawing.Size(133, 37);
            this.btAddRecord.TabIndex = 7;
            this.btAddRecord.Text = "Add New Record";
            this.btAddRecord.UseVisualStyleBackColor = true;
            this.btAddRecord.Click += new System.EventHandler(this.btAddRecord_Click);
            // 
            // gvRecordList
            // 
            this.gvRecordList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRecordList.Location = new System.Drawing.Point(12, 92);
            this.gvRecordList.Name = "gvRecordList";
            this.gvRecordList.RowHeadersWidth = 51;
            this.gvRecordList.RowTemplate.Height = 24;
            this.gvRecordList.Size = new System.Drawing.Size(775, 304);
            this.gvRecordList.TabIndex = 6;
            // 
            // ManageRentalRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 467);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.btDeleteRecord);
            this.Controls.Add(this.btEditRecord);
            this.Controls.Add(this.btAddRecord);
            this.Controls.Add(this.gvRecordList);
            this.Controls.Add(this.label1);
            this.Name = "ManageRentalRecord";
            this.Text = "Manage Rental Record";
            this.Load += new System.EventHandler(this.ManageRentalRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvRecordList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.Button btDeleteRecord;
        private System.Windows.Forms.Button btEditRecord;
        private System.Windows.Forms.Button btAddRecord;
        private System.Windows.Forms.DataGridView gvRecordList;
    }
}