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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            this.groupBox1.Controls.Add(this.lblTotalClientsSub);
            this.groupBox1.Controls.Add(this.lblTotalClients);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.groupBox1.Location = new System.Drawing.Point(13, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(304, 109);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TOTAL CLIENTS";
            // 
            // lblTotalClientsSub
            // 
            this.lblTotalClientsSub.AutoSize = true;
            this.lblTotalClientsSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.lblTotalClientsSub.Location = new System.Drawing.Point(8, 83);
            this.lblTotalClientsSub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalClientsSub.Name = "lblTotalClientsSub";
            this.lblTotalClientsSub.Size = new System.Drawing.Size(49, 23);
            this.lblTotalClientsSub.TabIndex = 2;
            this.lblTotalClientsSub.Text = "Total";
            this.lblTotalClientsSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTotalClientsSub.Click += new System.EventHandler(this.lblTotalClientsSub_Click);
            // 
            // lblTotalClients
            // 
            this.lblTotalClients.AutoSize = true;
            this.lblTotalClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalClients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.lblTotalClients.Location = new System.Drawing.Point(8, 34);
            this.lblTotalClients.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalClients.MaximumSize = new System.Drawing.Size(50, 52);
            this.lblTotalClients.Name = "lblTotalClients";
            this.lblTotalClients.Size = new System.Drawing.Size(40, 42);
            this.lblTotalClients.TabIndex = 1;
            this.lblTotalClients.Text = "0";
            this.lblTotalClients.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTotalClients.UseWaitCursor = true;
            this.lblTotalClients.Click += new System.EventHandler(this.lblTotalClients_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            this.groupBox2.Controls.Add(this.lblActiveDealsSub);
            this.groupBox2.Controls.Add(this.lblActiveDeals);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.groupBox2.Location = new System.Drawing.Point(336, 25);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(304, 109);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ACTIVE DEALS";
            // 
            // lblActiveDealsSub
            // 
            this.lblActiveDealsSub.AutoSize = true;
            this.lblActiveDealsSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.lblActiveDealsSub.Location = new System.Drawing.Point(8, 83);
            this.lblActiveDealsSub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActiveDealsSub.Name = "lblActiveDealsSub";
            this.lblActiveDealsSub.Size = new System.Drawing.Size(61, 20);
            this.lblActiveDealsSub.TabIndex = 2;
            this.lblActiveDealsSub.Text = "Active";
            this.lblActiveDealsSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblActiveDealsSub.Click += new System.EventHandler(this.lblActiveDealsSub_Click);
            // 
            // lblActiveDeals
            // 
            this.lblActiveDeals.AutoSize = true;
            this.lblActiveDeals.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveDeals.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(211)))), ((int)(((byte)(153)))));
            this.lblActiveDeals.Location = new System.Drawing.Point(8, 34);
            this.lblActiveDeals.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActiveDeals.Name = "lblActiveDeals";
            this.lblActiveDeals.Size = new System.Drawing.Size(40, 42);
            this.lblActiveDeals.TabIndex = 1;
            this.lblActiveDeals.Text = "0";
            this.lblActiveDeals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblActiveDeals.Click += new System.EventHandler(this.lblActiveDeals_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            this.groupBox3.Controls.Add(this.lblForecastedSub);
            this.groupBox3.Controls.Add(this.lblForecasted);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.groupBox3.Location = new System.Drawing.Point(983, 25);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(304, 109);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "FORECASTED";
            // 
            // lblForecastedSub
            // 
            this.lblForecastedSub.AutoSize = true;
            this.lblForecastedSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.lblForecastedSub.Location = new System.Drawing.Point(8, 85);
            this.lblForecastedSub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblForecastedSub.Name = "lblForecastedSub";
            this.lblForecastedSub.Size = new System.Drawing.Size(81, 20);
            this.lblForecastedSub.TabIndex = 2;
            this.lblForecastedSub.Text = "Revenue";
            this.lblForecastedSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblForecastedSub.Click += new System.EventHandler(this.lblForecastedSub_Click);
            // 
            // lblForecasted
            // 
            this.lblForecasted.AutoSize = true;
            this.lblForecasted.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForecasted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(139)))), ((int)(((byte)(250)))));
            this.lblForecasted.Location = new System.Drawing.Point(8, 34);
            this.lblForecasted.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblForecasted.Name = "lblForecasted";
            this.lblForecasted.Size = new System.Drawing.Size(66, 42);
            this.lblForecasted.TabIndex = 1;
            this.lblForecasted.Text = "₱0";
            this.lblForecasted.Click += new System.EventHandler(this.lblForecasted_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            this.groupBox4.Controls.Add(this.lblPendingSub);
            this.groupBox4.Controls.Add(this.lblPending);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.groupBox4.Location = new System.Drawing.Point(662, 25);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(304, 109);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "PENDING";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // lblPendingSub
            // 
            this.lblPendingSub.AutoSize = true;
            this.lblPendingSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            this.lblPendingSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.lblPendingSub.Location = new System.Drawing.Point(8, 83);
            this.lblPendingSub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPendingSub.Name = "lblPendingSub";
            this.lblPendingSub.Size = new System.Drawing.Size(100, 20);
            this.lblPendingSub.TabIndex = 2;
            this.lblPendingSub.Text = "Follow-ups";
            this.lblPendingSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPendingSub.Click += new System.EventHandler(this.lblPendingSub_Click);
            // 
            // lblPending
            // 
            this.lblPending.AutoSize = true;
            this.lblPending.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPending.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(191)))), ((int)(((byte)(36)))));
            this.lblPending.Location = new System.Drawing.Point(8, 34);
            this.lblPending.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPending.Name = "lblPending";
            this.lblPending.Size = new System.Drawing.Size(40, 42);
            this.lblPending.TabIndex = 1;
            this.lblPending.Text = "0";
            this.lblPending.Click += new System.EventHandler(this.lblPending_Click);
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToResizeColumns = false;
            this.dgvClients.AllowUserToResizeRows = false;
            this.dgvClients.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            this.dgvClients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClients.ColumnHeadersHeight = 38;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colEmail,
            this.colPhone,
            this.colCompany,
            this.colSource});
            this.dgvClients.EnableHeadersVisualStyles = false;
            this.dgvClients.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(54)))));
            this.dgvClients.Location = new System.Drawing.Point(25, 175);
            this.dgvClients.Margin = new System.Windows.Forms.Padding(4);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            this.dgvClients.RowHeadersVisible = false;
            this.dgvClients.RowHeadersWidth = 51;
            this.dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClients.Size = new System.Drawing.Size(1262, 443);
            this.dgvClients.TabIndex = 6;
            this.dgvClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClients_CellContentClick);
            // 
            // btnAddClient
            // 
            this.btnAddClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnAddClient.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnAddClient.FlatAppearance.BorderSize = 0;
            this.btnAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClient.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClient.ForeColor = System.Drawing.Color.White;
            this.btnAddClient.Location = new System.Drawing.Point(755, 626);
            this.btnAddClient.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(167, 41);
            this.btnAddClient.TabIndex = 7;
            this.btnAddClient.Text = "+ Add Client";
            this.btnAddClient.UseCompatibleTextRendering = true;
            this.btnAddClient.UseVisualStyleBackColor = false;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnEditClient
            // 
            this.btnEditClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.btnEditClient.FlatAppearance.BorderSize = 0;
            this.btnEditClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditClient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.btnEditClient.Location = new System.Drawing.Point(940, 626);
            this.btnEditClient.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(155, 41);
            this.btnEditClient.TabIndex = 8;
            this.btnEditClient.Text = "Edit Selected";
            this.btnEditClient.UseVisualStyleBackColor = false;
            this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click);
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btnDeleteClient.FlatAppearance.BorderSize = 0;
            this.btnDeleteClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteClient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.btnDeleteClient.Location = new System.Drawing.Point(1119, 626);
            this.btnDeleteClient.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(168, 41);
            this.btnDeleteClient.TabIndex = 9;
            this.btnDeleteClient.Text = "Delete Selected";
            this.btnDeleteClient.UseVisualStyleBackColor = false;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // colId
            // 
            this.colId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colId.DataPropertyName = "Id";
            this.colId.FillWeight = 40F;
            this.colId.HeaderText = "ID";
            this.colId.MinimumWidth = 40;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.DataPropertyName = "Name";
            this.colName.FillWeight = 160F;
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 160;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colEmail
            // 
            this.colEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.FillWeight = 180F;
            this.colEmail.HeaderText = "Email";
            this.colEmail.MinimumWidth = 190;
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            // 
            // colPhone
            // 
            this.colPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPhone.DataPropertyName = "Phone";
            this.colPhone.FillWeight = 110F;
            this.colPhone.HeaderText = "Phone";
            this.colPhone.MinimumWidth = 120;
            this.colPhone.Name = "colPhone";
            this.colPhone.ReadOnly = true;
            // 
            // colCompany
            // 
            this.colCompany.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCompany.DataPropertyName = "Company";
            this.colCompany.FillWeight = 150F;
            this.colCompany.HeaderText = "Company";
            this.colCompany.MinimumWidth = 160;
            this.colCompany.Name = "colCompany";
            this.colCompany.ReadOnly = true;
            // 
            // colSource
            // 
            this.colSource.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSource.DataPropertyName = "Source";
            this.colSource.FillWeight = 80F;
            this.colSource.HeaderText = "Source";
            this.colSource.MinimumWidth = 110;
            this.colSource.Name = "colSource";
            this.colSource.ReadOnly = true;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1312, 690);
            this.Controls.Add(this.btnDeleteClient);
            this.Controls.Add(this.btnEditClient);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.dgvClients);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainDashboard";
            this.Text = "ClientFlow CRM";
            this.Load += new System.EventHandler(this.MainDashboard_Load);
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

