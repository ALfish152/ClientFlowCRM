namespace ClientFlowCRM
{
    partial class MainDashboard
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTotalClientsSub = new System.Windows.Forms.Label();
            this.lblTotalClients = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblActiveDealsSub = new System.Windows.Forms.Label();
            this.lblActiveDeals = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblForecastedSub = new System.Windows.Forms.Label();
            this.lblForecasted = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblPendingSub = new System.Windows.Forms.Label();
            this.lblPending = new System.Windows.Forms.Label();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnEditClient = new System.Windows.Forms.Button();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTotalClientsSub);
            this.groupBox1.Controls.Add(this.lblTotalClients);
            this.groupBox1.Location = new System.Drawing.Point(94, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(106, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TOTAL CLIENTS";
            // 
            // lblTotalClientsSub
            // 
            this.lblTotalClientsSub.AutoSize = true;
            this.lblTotalClientsSub.Location = new System.Drawing.Point(32, 56);
            this.lblTotalClientsSub.Name = "lblTotalClientsSub";
            this.lblTotalClientsSub.Size = new System.Drawing.Size(31, 13);
            this.lblTotalClientsSub.TabIndex = 2;
            this.lblTotalClientsSub.Text = "Total";
            this.lblTotalClientsSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalClients
            // 
            this.lblTotalClients.AutoSize = true;
            this.lblTotalClients.Location = new System.Drawing.Point(44, 28);
            this.lblTotalClients.Name = "lblTotalClients";
            this.lblTotalClients.Size = new System.Drawing.Size(13, 13);
            this.lblTotalClients.TabIndex = 1;
            this.lblTotalClients.Text = "0";
            this.lblTotalClients.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblActiveDealsSub);
            this.groupBox2.Controls.Add(this.lblActiveDeals);
            this.groupBox2.Location = new System.Drawing.Point(206, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(106, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ACTIVE DEALS";
            // 
            // lblActiveDealsSub
            // 
            this.lblActiveDealsSub.AutoSize = true;
            this.lblActiveDealsSub.Location = new System.Drawing.Point(32, 56);
            this.lblActiveDealsSub.Name = "lblActiveDealsSub";
            this.lblActiveDealsSub.Size = new System.Drawing.Size(37, 13);
            this.lblActiveDealsSub.TabIndex = 2;
            this.lblActiveDealsSub.Text = "Active";
            this.lblActiveDealsSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblActiveDeals
            // 
            this.lblActiveDeals.AutoSize = true;
            this.lblActiveDeals.Location = new System.Drawing.Point(42, 28);
            this.lblActiveDeals.Name = "lblActiveDeals";
            this.lblActiveDeals.Size = new System.Drawing.Size(13, 13);
            this.lblActiveDeals.TabIndex = 1;
            this.lblActiveDeals.Text = "0";
            this.lblActiveDeals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblForecastedSub);
            this.groupBox3.Controls.Add(this.lblForecasted);
            this.groupBox3.Location = new System.Drawing.Point(318, 83);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(106, 100);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "FORECASTED";
            // 
            // lblForecastedSub
            // 
            this.lblForecastedSub.AutoSize = true;
            this.lblForecastedSub.Location = new System.Drawing.Point(32, 56);
            this.lblForecastedSub.Name = "lblForecastedSub";
            this.lblForecastedSub.Size = new System.Drawing.Size(51, 13);
            this.lblForecastedSub.TabIndex = 2;
            this.lblForecastedSub.Text = "Revenue";
            this.lblForecastedSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblForecasted
            // 
            this.lblForecasted.AutoSize = true;
            this.lblForecasted.Location = new System.Drawing.Point(32, 28);
            this.lblForecasted.Name = "lblForecasted";
            this.lblForecasted.Size = new System.Drawing.Size(20, 13);
            this.lblForecasted.TabIndex = 1;
            this.lblForecasted.Text = "₱0";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblPendingSub);
            this.groupBox4.Controls.Add(this.lblPending);
            this.groupBox4.Location = new System.Drawing.Point(430, 83);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(106, 100);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "PENDING";
            // 
            // lblPendingSub
            // 
            this.lblPendingSub.AutoSize = true;
            this.lblPendingSub.Location = new System.Drawing.Point(32, 56);
            this.lblPendingSub.Name = "lblPendingSub";
            this.lblPendingSub.Size = new System.Drawing.Size(57, 13);
            this.lblPendingSub.TabIndex = 2;
            this.lblPendingSub.Text = "Follow-ups";
            this.lblPendingSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPending
            // 
            this.lblPending.AutoSize = true;
            this.lblPending.Location = new System.Drawing.Point(32, 28);
            this.lblPending.Name = "lblPending";
            this.lblPending.Size = new System.Drawing.Size(13, 13);
            this.lblPending.TabIndex = 1;
            this.lblPending.Text = "0";
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToResizeColumns = false;
            this.dgvClients.AllowUserToResizeRows = false;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colEmail,
            this.colPhone,
            this.colCompany,
            this.colSource});
            this.dgvClients.Location = new System.Drawing.Point(94, 189);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            this.dgvClients.RowHeadersVisible = false;
            this.dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClients.Size = new System.Drawing.Size(784, 150);
            this.dgvClients.TabIndex = 6;
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(94, 481);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(75, 23);
            this.btnAddClient.TabIndex = 7;
            this.btnAddClient.Text = "Add Client";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnEditClient
            // 
            this.btnEditClient.Location = new System.Drawing.Point(690, 481);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(84, 23);
            this.btnEditClient.TabIndex = 8;
            this.btnEditClient.Text = "Edit Selected";
            this.btnEditClient.UseVisualStyleBackColor = true;
            this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click);
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.Location = new System.Drawing.Point(780, 481);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(98, 23);
            this.btnDeleteClient.TabIndex = 9;
            this.btnDeleteClient.Text = "Delete Selected";
            this.btnDeleteClient.UseVisualStyleBackColor = true;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.Frozen = true;
            this.colId.HeaderText = "ID";
            this.colId.MinimumWidth = 40;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 40;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.Frozen = true;
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 160;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 160;
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "Email";
            this.colEmail.MinimumWidth = 190;
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            this.colEmail.Width = 190;
            // 
            // colPhone
            // 
            this.colPhone.DataPropertyName = "Phone";
            this.colPhone.HeaderText = "Phone";
            this.colPhone.MinimumWidth = 120;
            this.colPhone.Name = "colPhone";
            this.colPhone.ReadOnly = true;
            this.colPhone.Width = 120;
            // 
            // colCompany
            // 
            this.colCompany.DataPropertyName = "Company";
            this.colCompany.HeaderText = "Company";
            this.colCompany.MinimumWidth = 160;
            this.colCompany.Name = "colCompany";
            this.colCompany.ReadOnly = true;
            this.colCompany.Width = 160;
            // 
            // colSource
            // 
            this.colSource.DataPropertyName = "Source";
            this.colSource.HeaderText = "Source";
            this.colSource.MinimumWidth = 110;
            this.colSource.Name = "colSource";
            this.colSource.ReadOnly = true;
            this.colSource.Width = 110;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.btnDeleteClient);
            this.Controls.Add(this.btnEditClient);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.dgvClients);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainDashboard";
            this.Text = "ClientFlow CRM";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotalClientsSub;
        private System.Windows.Forms.Label lblTotalClients;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblActiveDealsSub;
        private System.Windows.Forms.Label lblActiveDeals;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblForecastedSub;
        private System.Windows.Forms.Label lblForecasted;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblPendingSub;
        private System.Windows.Forms.Label lblPending;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnEditClient;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSource;
    }
}

