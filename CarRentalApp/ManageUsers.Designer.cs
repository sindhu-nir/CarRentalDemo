namespace CarRentalApp
{
    partial class ManageUsers
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
            this.btRefresh = new System.Windows.Forms.Button();
            this.btDeactivate = new System.Windows.Forms.Button();
            this.btResetUser = new System.Windows.Forms.Button();
            this.btAddUser = new System.Windows.Forms.Button();
            this.gvRecordList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvRecordList)).BeginInit();
            this.SuspendLayout();
            // 
            // btRefresh
            // 
            this.btRefresh.Location = new System.Drawing.Point(13, 41);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(133, 37);
            this.btRefresh.TabIndex = 16;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = true;
            // 
            // btDeactivate
            // 
            this.btDeactivate.Location = new System.Drawing.Point(655, 410);
            this.btDeactivate.Name = "btDeactivate";
            this.btDeactivate.Size = new System.Drawing.Size(133, 37);
            this.btDeactivate.TabIndex = 15;
            this.btDeactivate.Text = "Deactivate User";
            this.btDeactivate.UseVisualStyleBackColor = true;
            this.btDeactivate.Click += new System.EventHandler(this.btDeactivate_Click);
            // 
            // btResetUser
            // 
            this.btResetUser.Location = new System.Drawing.Point(280, 410);
            this.btResetUser.Name = "btResetUser";
            this.btResetUser.Size = new System.Drawing.Size(133, 37);
            this.btResetUser.TabIndex = 14;
            this.btResetUser.Text = "Reset Password";
            this.btResetUser.UseVisualStyleBackColor = true;
            this.btResetUser.Click += new System.EventHandler(this.btResetUser_Click);
            // 
            // btAddUser
            // 
            this.btAddUser.Location = new System.Drawing.Point(13, 410);
            this.btAddUser.Name = "btAddUser";
            this.btAddUser.Size = new System.Drawing.Size(133, 37);
            this.btAddUser.TabIndex = 13;
            this.btAddUser.Text = "Add New User";
            this.btAddUser.UseVisualStyleBackColor = true;
            this.btAddUser.Click += new System.EventHandler(this.btAddUser_Click);
            // 
            // gvRecordList
            // 
            this.gvRecordList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRecordList.Location = new System.Drawing.Point(13, 84);
            this.gvRecordList.Name = "gvRecordList";
            this.gvRecordList.RowHeadersWidth = 51;
            this.gvRecordList.RowTemplate.Height = 24;
            this.gvRecordList.Size = new System.Drawing.Size(775, 304);
            this.gvRecordList.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 100, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Manage User Records";
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 462);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.btDeactivate);
            this.Controls.Add(this.btResetUser);
            this.Controls.Add(this.btAddUser);
            this.Controls.Add(this.gvRecordList);
            this.Controls.Add(this.label1);
            this.Name = "ManageUsers";
            this.Text = "Manage Users";
            ((System.ComponentModel.ISupportInitialize)(this.gvRecordList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.Button btDeactivate;
        private System.Windows.Forms.Button btResetUser;
        private System.Windows.Forms.Button btAddUser;
        private System.Windows.Forms.DataGridView gvRecordList;
        private System.Windows.Forms.Label label1;
    }
}