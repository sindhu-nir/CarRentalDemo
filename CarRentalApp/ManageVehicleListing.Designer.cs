namespace CarRentalApp
{
    partial class ManageVehicleListing
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
            this.gvVehicleList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btAddNewCar = new System.Windows.Forms.Button();
            this.btEditCar = new System.Windows.Forms.Button();
            this.btDeleteCar = new System.Windows.Forms.Button();
            this.btRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvVehicleList)).BeginInit();
            this.SuspendLayout();
            // 
            // gvVehicleList
            // 
            this.gvVehicleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvVehicleList.Location = new System.Drawing.Point(13, 70);
            this.gvVehicleList.Name = "gvVehicleList";
            this.gvVehicleList.RowHeadersWidth = 51;
            this.gvVehicleList.RowTemplate.Height = 24;
            this.gvVehicleList.Size = new System.Drawing.Size(775, 304);
            this.gvVehicleList.TabIndex = 0;
            this.gvVehicleList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvVehicleList_CellContentClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 100, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Vehicle Listing";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btAddNewCar
            // 
            this.btAddNewCar.Location = new System.Drawing.Point(13, 391);
            this.btAddNewCar.Name = "btAddNewCar";
            this.btAddNewCar.Size = new System.Drawing.Size(133, 37);
            this.btAddNewCar.TabIndex = 2;
            this.btAddNewCar.Text = "Add New Car";
            this.btAddNewCar.UseVisualStyleBackColor = true;
            this.btAddNewCar.Click += new System.EventHandler(this.btAddNewCar_Click);
            // 
            // btEditCar
            // 
            this.btEditCar.Location = new System.Drawing.Point(329, 391);
            this.btEditCar.Name = "btEditCar";
            this.btEditCar.Size = new System.Drawing.Size(133, 37);
            this.btEditCar.TabIndex = 3;
            this.btEditCar.Text = "Edit Car";
            this.btEditCar.UseVisualStyleBackColor = true;
            this.btEditCar.Click += new System.EventHandler(this.btEditCar_Click);
            // 
            // btDeleteCar
            // 
            this.btDeleteCar.Location = new System.Drawing.Point(655, 391);
            this.btDeleteCar.Name = "btDeleteCar";
            this.btDeleteCar.Size = new System.Drawing.Size(133, 37);
            this.btDeleteCar.TabIndex = 4;
            this.btDeleteCar.Text = "Delete Car";
            this.btDeleteCar.UseVisualStyleBackColor = true;
            this.btDeleteCar.Click += new System.EventHandler(this.btDeleteCar_Click);
            // 
            // btRefresh
            // 
            this.btRefresh.Location = new System.Drawing.Point(13, 27);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(133, 37);
            this.btRefresh.TabIndex = 5;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // ManageVehicleListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.btDeleteCar);
            this.Controls.Add(this.btEditCar);
            this.Controls.Add(this.btAddNewCar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvVehicleList);
            this.Name = "ManageVehicleListing";
            this.Text = "Manage Vehicle Listing";
            this.Load += new System.EventHandler(this.ManageVehicleListing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvVehicleList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvVehicleList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAddNewCar;
        private System.Windows.Forms.Button btEditCar;
        private System.Windows.Forms.Button btDeleteCar;
        private System.Windows.Forms.Button btRefresh;
    }
}