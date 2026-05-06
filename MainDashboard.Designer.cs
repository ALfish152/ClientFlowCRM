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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle67 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle70 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle71 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle72 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle68 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle69 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnEditClient = new System.Windows.Forms.Button();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.lstPriority = new System.Windows.Forms.ListBox();
            this.lblAtRiskCount = new System.Windows.Forms.Label();
            this.btnExportCSV = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnTestSave = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rrik = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lblTotalClientsSub);
            this.groupBox1.Controls.Add(this.lblTotalClients);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.groupBox1.Location = new System.Drawing.Point(27, 101);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(340, 105);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TOTAL CLIENTS";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblTotalClientsSub
            // 
            this.lblTotalClientsSub.AutoSize = true;
            this.lblTotalClientsSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(145)))), ((int)(((byte)(155)))));
            this.lblTotalClientsSub.Location = new System.Drawing.Point(8, 82);
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
            this.lblTotalClients.MaximumSize = new System.Drawing.Size(51, 52);
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
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.lblActiveDealsSub);
            this.groupBox2.Controls.Add(this.lblActiveDeals);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.groupBox2.Location = new System.Drawing.Point(416, 102);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(342, 105);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ACTIVE DEALS";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblActiveDealsSub
            // 
            this.lblActiveDealsSub.AutoSize = true;
            this.lblActiveDealsSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(145)))), ((int)(((byte)(155)))));
            this.lblActiveDealsSub.Location = new System.Drawing.Point(8, 82);
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
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.lblForecastedSub);
            this.groupBox3.Controls.Add(this.lblForecasted);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.groupBox3.Location = new System.Drawing.Point(1201, 101);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(342, 105);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "FORECASTED";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // lblForecastedSub
            // 
            this.lblForecastedSub.AutoSize = true;
            this.lblForecastedSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(145)))), ((int)(((byte)(155)))));
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
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.lblPendingSub);
            this.groupBox4.Controls.Add(this.lblPending);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.groupBox4.Location = new System.Drawing.Point(809, 102);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(342, 105);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "PENDING";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // lblPendingSub
            // 
            this.lblPendingSub.AutoSize = true;
            this.lblPendingSub.BackColor = System.Drawing.Color.Transparent;
            this.lblPendingSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(145)))), ((int)(((byte)(155)))));
            this.lblPendingSub.Location = new System.Drawing.Point(8, 82);
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
            // btnAddClient
            // 
            this.btnAddClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(103)))), ((int)(((byte)(242)))));
            this.btnAddClient.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAddClient.FlatAppearance.BorderSize = 0;
            this.btnAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClient.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClient.ForeColor = System.Drawing.Color.White;
            this.btnAddClient.Location = new System.Drawing.Point(1722, 13);
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
            this.btnEditClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(103)))), ((int)(((byte)(242)))));
            this.btnEditClient.FlatAppearance.BorderSize = 0;
            this.btnEditClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditClient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditClient.ForeColor = System.Drawing.Color.White;
            this.btnEditClient.Location = new System.Drawing.Point(1714, 921);
            this.btnEditClient.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(165, 41);
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
            this.btnDeleteClient.ForeColor = System.Drawing.Color.White;
            this.btnDeleteClient.Location = new System.Drawing.Point(1358, 921);
            this.btnDeleteClient.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(185, 41);
            this.btnDeleteClient.TabIndex = 9;
            this.btnDeleteClient.Text = "Delete Selected";
            this.btnDeleteClient.UseVisualStyleBackColor = false;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // lstPriority
            // 
            this.lstPriority.BackColor = System.Drawing.Color.White;
            this.lstPriority.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstPriority.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPriority.ForeColor = System.Drawing.Color.Black;
            this.lstPriority.FormattingEnabled = true;
            this.lstPriority.ItemHeight = 20;
            this.lstPriority.Location = new System.Drawing.Point(23, 233);
            this.lstPriority.Margin = new System.Windows.Forms.Padding(4);
            this.lstPriority.Name = "lstPriority";
            this.lstPriority.Size = new System.Drawing.Size(348, 680);
            this.lstPriority.TabIndex = 10;
            this.lstPriority.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstPriority_DrawItem);
            this.lstPriority.SelectedIndexChanged += new System.EventHandler(this.lstPriority_SelectedIndexChanged);
            // 
            // lblAtRiskCount
            // 
            this.lblAtRiskCount.AutoSize = true;
            this.lblAtRiskCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtRiskCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.lblAtRiskCount.Location = new System.Drawing.Point(50, 46);
            this.lblAtRiskCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAtRiskCount.Name = "lblAtRiskCount";
            this.lblAtRiskCount.Size = new System.Drawing.Size(0, 25);
            this.lblAtRiskCount.TabIndex = 11;
            this.lblAtRiskCount.Click += new System.EventHandler(this.lblAtRiskCount_Click);
            // 
            // btnExportCSV
            // 
            this.btnExportCSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))));
            this.btnExportCSV.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnExportCSV.FlatAppearance.BorderSize = 0;
            this.btnExportCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportCSV.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportCSV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnExportCSV.Location = new System.Drawing.Point(1324, 13);
            this.btnExportCSV.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportCSV.Name = "btnExportCSV";
            this.btnExportCSV.Size = new System.Drawing.Size(167, 41);
            this.btnExportCSV.TabIndex = 12;
            this.btnExportCSV.Text = "Export CSV";
            this.btnExportCSV.UseCompatibleTextRendering = true;
            this.btnExportCSV.UseVisualStyleBackColor = false;
            this.btnExportCSV.Click += new System.EventHandler(this.btnExportCSV_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(103)))), ((int)(((byte)(242)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1551, 921);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 41);
            this.button1.TabIndex = 13;
            this.button1.Text = "View Details";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnRefresh.Location = new System.Drawing.Point(1520, 13);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(167, 41);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseCompatibleTextRendering = true;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnTestSave
            // 
            this.btnTestSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btnTestSave.FlatAppearance.BorderSize = 0;
            this.btnTestSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestSave.ForeColor = System.Drawing.Color.White;
            this.btnTestSave.Location = new System.Drawing.Point(1182, 921);
            this.btnTestSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnTestSave.Name = "btnTestSave";
            this.btnTestSave.Size = new System.Drawing.Size(168, 41);
            this.btnTestSave.TabIndex = 15;
            this.btnTestSave.Text = "Test Save";
            this.btnTestSave.UseVisualStyleBackColor = false;
            this.btnTestSave.Click += new System.EventHandler(this.btnTestSave_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.White;
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.lblAtRiskCount);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.groupBox5.Location = new System.Drawing.Point(1587, 101);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(284, 102);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "AT RISK";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(6, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 42);
            this.label3.TabIndex = 3;
            this.label3.Text = "0 at risk";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.label1.Location = new System.Drawing.Point(8, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 2;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(139)))), ((int)(((byte)(250)))));
            this.label2.Location = new System.Drawing.Point(4, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 42);
            this.label2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))));
            this.panel1.Location = new System.Drawing.Point(23, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 121);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))));
            this.panel2.Location = new System.Drawing.Point(407, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 121);
            this.panel2.TabIndex = 17;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))));
            this.panel3.Location = new System.Drawing.Point(800, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(360, 121);
            this.panel3.TabIndex = 18;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))));
            this.panel4.Location = new System.Drawing.Point(1191, 92);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(360, 121);
            this.panel4.TabIndex = 19;
            // 
            // rrik
            // 
            this.rrik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))));
            this.rrik.Location = new System.Drawing.Point(1575, 92);
            this.rrik.Name = "rrik";
            this.rrik.Size = new System.Drawing.Size(304, 119);
            this.rrik.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(323, 46);
            this.label4.TabIndex = 21;
            this.label4.Text = "ClientFlow CRM";
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToDeleteRows = false;
            this.dgvClients.AllowUserToResizeRows = false;
            this.dgvClients.BackgroundColor = System.Drawing.Color.White;
            this.dgvClients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle67.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle67.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(213)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle67.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle67.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle67.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            dataGridViewCellStyle67.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(183)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle67.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle67.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle67;
            this.dgvClients.ColumnHeadersHeight = 38;
            this.dgvClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            dataGridViewCellStyle70.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle70.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle70.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle70.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle70.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle70.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle70.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClients.DefaultCellStyle = dataGridViewCellStyle70;
            this.dgvClients.EnableHeadersVisualStyles = false;
            this.dgvClients.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(228)))));
            this.dgvClients.Location = new System.Drawing.Point(412, 235);
            this.dgvClients.Margin = new System.Windows.Forms.Padding(0);
            this.dgvClients.MultiSelect = false;
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            dataGridViewCellStyle71.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle71.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle71.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle71.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle71.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle71.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle71.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClients.RowHeadersDefaultCellStyle = dataGridViewCellStyle71;
            this.dgvClients.RowHeadersVisible = false;
            this.dgvClients.RowHeadersWidth = 51;
            dataGridViewCellStyle72.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle72.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.dgvClients.RowsDefaultCellStyle = dataGridViewCellStyle72;
            this.dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClients.Size = new System.Drawing.Size(1467, 671);
            this.dgvClients.TabIndex = 6;
            this.dgvClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClients_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewCellStyle68.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle68.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle68.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle68.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(228)))));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle68;
            this.dataGridViewTextBoxColumn1.FillWeight = 40F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 40;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            dataGridViewCellStyle69.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle69.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle69.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle69.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))));
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle69;
            this.dataGridViewTextBoxColumn2.FillWeight = 160F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 160;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn3.FillWeight = 180F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Email";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 190;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn4.FillWeight = 110F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 120;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Company";
            this.dataGridViewTextBoxColumn5.FillWeight = 150F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Company";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 155;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Source";
            this.dataGridViewTextBoxColumn6.FillWeight = 80F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Source";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 110;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnTestSave);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstPriority);
            this.Controls.Add(this.btnDeleteClient);
            this.Controls.Add(this.btnEditClient);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.rrik);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnExportCSV);
            this.Controls.Add(this.dgvClients);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainDashboard";
            this.Text = "ClientFlow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainDashboard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnEditClient;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.ListBox lstPriority;
        private System.Windows.Forms.Label lblAtRiskCount;
        private System.Windows.Forms.Button btnExportCSV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnTestSave;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel rrik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}

