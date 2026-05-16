namespace ClientFlowCRM
{
    partial class ClientDetailForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.panelClientInfo = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblTempBadge = new System.Windows.Forms.Label();
            this.lblSubInfo = new System.Windows.Forms.Label();
            this.divider1 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblSource = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDeals = new System.Windows.Forms.DataGridView();
            this.colDealTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDealValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDealStage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDealProbability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddDeal = new System.Windows.Forms.Button();
            this.btnEditDeal = new System.Windows.Forms.Button();
            this.btnDeleteDeal = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvInteractions = new System.Windows.Forms.DataGridView();
            this.colIntType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIntDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSummary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddInteraction = new System.Windows.Forms.Button();
            this.btnEditInteraction = new System.Windows.Forms.Button();
            this.btnDeleteInteraction = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelClientInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInteractions)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(103)))), ((int)(((byte)(242)))));
            this.panelTopBar.Location = new System.Drawing.Point(0, 0);
            this.panelTopBar.Margin = new System.Windows.Forms.Padding(2);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(975, 4);
            this.panelTopBar.TabIndex = 50;
            // 
            // panelClientInfo
            // 
            this.panelClientInfo.BackColor = System.Drawing.Color.White;
            this.panelClientInfo.Controls.Add(this.lblHeader);
            this.panelClientInfo.Controls.Add(this.lblTempBadge);
            this.panelClientInfo.Controls.Add(this.lblSubInfo);
            this.panelClientInfo.Controls.Add(this.divider1);
            this.panelClientInfo.Controls.Add(this.lblEmail);
            this.panelClientInfo.Controls.Add(this.lblPhone);
            this.panelClientInfo.Controls.Add(this.lblCompany);
            this.panelClientInfo.Controls.Add(this.lblSource);
            this.panelClientInfo.Location = new System.Drawing.Point(12, 13);
            this.panelClientInfo.Margin = new System.Windows.Forms.Padding(2);
            this.panelClientInfo.Name = "panelClientInfo";
            this.panelClientInfo.Size = new System.Drawing.Size(951, 98);
            this.panelClientInfo.TabIndex = 51;
            this.panelClientInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelClientInfo_Paint);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.lblHeader.Location = new System.Drawing.Point(15, 11);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(140, 30);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Client Name";
            this.lblHeader.Click += new System.EventHandler(this.lblHeader_Click);
            // 
            // lblTempBadge
            // 
            this.lblTempBadge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.lblTempBadge.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTempBadge.ForeColor = System.Drawing.Color.White;
            this.lblTempBadge.Location = new System.Drawing.Point(15, 42);
            this.lblTempBadge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTempBadge.Name = "lblTempBadge";
            this.lblTempBadge.Size = new System.Drawing.Size(45, 20);
            this.lblTempBadge.TabIndex = 1;
            this.lblTempBadge.Text = "Cold";
            this.lblTempBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubInfo
            // 
            this.lblSubInfo.AutoSize = true;
            this.lblSubInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(145)))), ((int)(((byte)(155)))));
            this.lblSubInfo.Location = new System.Drawing.Point(68, 47);
            this.lblSubInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubInfo.Name = "lblSubInfo";
            this.lblSubInfo.Size = new System.Drawing.Size(57, 15);
            this.lblSubInfo.TabIndex = 2;
            this.lblSubInfo.Text = "Score: 0.0";
            // 
            // divider1
            // 
            this.divider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(228)))));
            this.divider1.Location = new System.Drawing.Point(15, 70);
            this.divider1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.divider1.Name = "divider1";
            this.divider1.Size = new System.Drawing.Size(921, 1);
            this.divider1.TabIndex = 98;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.lblEmail.Location = new System.Drawing.Point(15, 76);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(174, 20);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "📧 email@example.com";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.lblPhone.Location = new System.Drawing.Point(237, 76);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(76, 20);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "📞 phone";
            this.lblPhone.Click += new System.EventHandler(this.lblPhone_Click);
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.lblCompany.Location = new System.Drawing.Point(459, 76);
            this.lblCompany.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(95, 20);
            this.lblCompany.TabIndex = 5;
            this.lblCompany.Text = "🏢 company";
            this.lblCompany.Click += new System.EventHandler(this.lblCompany_Click);
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSource.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.lblSource.Location = new System.Drawing.Point(643, 76);
            this.lblSource.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(77, 20);
            this.lblSource.TabIndex = 6;
            this.lblSource.Text = "🔗 source";
            this.lblSource.Click += new System.EventHandler(this.lblSource_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.label2.Location = new System.Drawing.Point(11, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "DEALS";
            // 
            // dgvDeals
            // 
            this.dgvDeals.AllowUserToAddRows = false;
            this.dgvDeals.AllowUserToDeleteRows = false;
            this.dgvDeals.AllowUserToResizeRows = false;
            this.dgvDeals.BackgroundColor = System.Drawing.Color.White;
            this.dgvDeals.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(213)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(183)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.dgvDeals.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDeals.ColumnHeadersHeight = 36;
            this.dgvDeals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDeals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDealTitle,
            this.colDealValue,
            this.colDealStage,
            this.colDealProbability});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(213)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDeals.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDeals.EnableHeadersVisualStyles = false;
            this.dgvDeals.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(228)))));
            this.dgvDeals.Location = new System.Drawing.Point(11, 164);
            this.dgvDeals.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDeals.MultiSelect = false;
            this.dgvDeals.Name = "dgvDeals";
            this.dgvDeals.ReadOnly = true;
            this.dgvDeals.RowHeadersVisible = false;
            this.dgvDeals.RowHeadersWidth = 51;
            this.dgvDeals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeals.Size = new System.Drawing.Size(951, 179);
            this.dgvDeals.TabIndex = 2;
            this.dgvDeals.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDeals_CellFormatting);
            // 
            // colDealTitle
            // 
            this.colDealTitle.DataPropertyName = "Title";
            this.colDealTitle.HeaderText = "Title";
            this.colDealTitle.MinimumWidth = 100;
            this.colDealTitle.Name = "colDealTitle";
            this.colDealTitle.ReadOnly = true;
            this.colDealTitle.Width = 300;
            // 
            // colDealValue
            // 
            this.colDealValue.DataPropertyName = "Value";
            this.colDealValue.HeaderText = "Value (₱)";
            this.colDealValue.MinimumWidth = 100;
            this.colDealValue.Name = "colDealValue";
            this.colDealValue.ReadOnly = true;
            this.colDealValue.Width = 150;
            // 
            // colDealStage
            // 
            this.colDealStage.DataPropertyName = "Stage";
            this.colDealStage.HeaderText = "Stage";
            this.colDealStage.MinimumWidth = 100;
            this.colDealStage.Name = "colDealStage";
            this.colDealStage.ReadOnly = true;
            this.colDealStage.Width = 150;
            // 
            // colDealProbability
            // 
            this.colDealProbability.DataPropertyName = "WinProbability";
            this.colDealProbability.HeaderText = "Win Probability";
            this.colDealProbability.MinimumWidth = 100;
            this.colDealProbability.Name = "colDealProbability";
            this.colDealProbability.ReadOnly = true;
            this.colDealProbability.Width = 150;
            // 
            // btnAddDeal
            // 
            this.btnAddDeal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(103)))), ((int)(((byte)(242)))));
            this.btnAddDeal.FlatAppearance.BorderSize = 0;
            this.btnAddDeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDeal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddDeal.ForeColor = System.Drawing.Color.White;
            this.btnAddDeal.Location = new System.Drawing.Point(633, 352);
            this.btnAddDeal.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddDeal.Name = "btnAddDeal";
            this.btnAddDeal.Size = new System.Drawing.Size(108, 28);
            this.btnAddDeal.TabIndex = 5;
            this.btnAddDeal.Text = "+ Add Deal";
            this.btnAddDeal.UseVisualStyleBackColor = false;
            this.btnAddDeal.Click += new System.EventHandler(this.btnAddDeal_Click);
            // 
            // btnEditDeal
            // 
            this.btnEditDeal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))));
            this.btnEditDeal.FlatAppearance.BorderSize = 0;
            this.btnEditDeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditDeal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEditDeal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnEditDeal.Location = new System.Drawing.Point(745, 352);
            this.btnEditDeal.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditDeal.Name = "btnEditDeal";
            this.btnEditDeal.Size = new System.Drawing.Size(98, 28);
            this.btnEditDeal.TabIndex = 9;
            this.btnEditDeal.Text = "Edit Deal";
            this.btnEditDeal.UseVisualStyleBackColor = false;
            this.btnEditDeal.Click += new System.EventHandler(this.btnEditDeal_Click);
            // 
            // btnDeleteDeal
            // 
            this.btnDeleteDeal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btnDeleteDeal.FlatAppearance.BorderSize = 0;
            this.btnDeleteDeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDeal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeleteDeal.ForeColor = System.Drawing.Color.White;
            this.btnDeleteDeal.Location = new System.Drawing.Point(847, 352);
            this.btnDeleteDeal.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteDeal.Name = "btnDeleteDeal";
            this.btnDeleteDeal.Size = new System.Drawing.Size(118, 28);
            this.btnDeleteDeal.TabIndex = 10;
            this.btnDeleteDeal.Text = "Delete Deal";
            this.btnDeleteDeal.UseVisualStyleBackColor = false;
            this.btnDeleteDeal.Click += new System.EventHandler(this.btnDeleteDeal_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.label3.Location = new System.Drawing.Point(11, 392);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "INTERACTIONS";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dgvInteractions
            // 
            this.dgvInteractions.AllowUserToAddRows = false;
            this.dgvInteractions.AllowUserToDeleteRows = false;
            this.dgvInteractions.AllowUserToResizeRows = false;
            this.dgvInteractions.BackgroundColor = System.Drawing.Color.White;
            this.dgvInteractions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(213)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(183)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.dgvInteractions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInteractions.ColumnHeadersHeight = 36;
            this.dgvInteractions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvInteractions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIntType,
            this.colIntDate,
            this.colSummary});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(213)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInteractions.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvInteractions.EnableHeadersVisualStyles = false;
            this.dgvInteractions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(228)))));
            this.dgvInteractions.Location = new System.Drawing.Point(11, 412);
            this.dgvInteractions.Margin = new System.Windows.Forms.Padding(2);
            this.dgvInteractions.MultiSelect = false;
            this.dgvInteractions.Name = "dgvInteractions";
            this.dgvInteractions.ReadOnly = true;
            this.dgvInteractions.RowHeadersVisible = false;
            this.dgvInteractions.RowHeadersWidth = 51;
            this.dgvInteractions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInteractions.Size = new System.Drawing.Size(951, 179);
            this.dgvInteractions.TabIndex = 4;
            this.dgvInteractions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInteractions_CellContentClick);
            this.dgvInteractions.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvInteractions_CellFormatting);
            // 
            // colIntType
            // 
            this.colIntType.DataPropertyName = "Type";
            this.colIntType.HeaderText = "Type";
            this.colIntType.MinimumWidth = 100;
            this.colIntType.Name = "colIntType";
            this.colIntType.ReadOnly = true;
            this.colIntType.Width = 150;
            // 
            // colIntDate
            // 
            this.colIntDate.DataPropertyName = "Timestamp";
            this.colIntDate.HeaderText = "Date";
            this.colIntDate.MinimumWidth = 100;
            this.colIntDate.Name = "colIntDate";
            this.colIntDate.ReadOnly = true;
            this.colIntDate.Width = 180;
            // 
            // colSummary
            // 
            this.colSummary.DataPropertyName = "Summary";
            this.colSummary.HeaderText = "Details";
            this.colSummary.MinimumWidth = 100;
            this.colSummary.Name = "colSummary";
            this.colSummary.ReadOnly = true;
            this.colSummary.Width = 500;
            // 
            // btnAddInteraction
            // 
            this.btnAddInteraction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(103)))), ((int)(((byte)(242)))));
            this.btnAddInteraction.FlatAppearance.BorderSize = 0;
            this.btnAddInteraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddInteraction.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddInteraction.ForeColor = System.Drawing.Color.White;
            this.btnAddInteraction.Location = new System.Drawing.Point(633, 599);
            this.btnAddInteraction.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddInteraction.Name = "btnAddInteraction";
            this.btnAddInteraction.Size = new System.Drawing.Size(108, 28);
            this.btnAddInteraction.TabIndex = 6;
            this.btnAddInteraction.Text = "+ Add Ineraction";
            this.btnAddInteraction.UseVisualStyleBackColor = false;
            this.btnAddInteraction.Click += new System.EventHandler(this.btnAddInteraction_Click);
            // 
            // btnEditInteraction
            // 
            this.btnEditInteraction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))));
            this.btnEditInteraction.FlatAppearance.BorderSize = 0;
            this.btnEditInteraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditInteraction.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEditInteraction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnEditInteraction.Location = new System.Drawing.Point(745, 599);
            this.btnEditInteraction.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditInteraction.Name = "btnEditInteraction";
            this.btnEditInteraction.Size = new System.Drawing.Size(98, 28);
            this.btnEditInteraction.TabIndex = 11;
            this.btnEditInteraction.Text = "Edit Ineraction";
            this.btnEditInteraction.UseVisualStyleBackColor = false;
            this.btnEditInteraction.Click += new System.EventHandler(this.btnEditInteraction_Click);
            // 
            // btnDeleteInteraction
            // 
            this.btnDeleteInteraction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btnDeleteInteraction.FlatAppearance.BorderSize = 0;
            this.btnDeleteInteraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteInteraction.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeleteInteraction.ForeColor = System.Drawing.Color.White;
            this.btnDeleteInteraction.Location = new System.Drawing.Point(847, 599);
            this.btnDeleteInteraction.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteInteraction.Name = "btnDeleteInteraction";
            this.btnDeleteInteraction.Size = new System.Drawing.Size(118, 28);
            this.btnDeleteInteraction.TabIndex = 12;
            this.btnDeleteInteraction.Text = "Delete Ineraction";
            this.btnDeleteInteraction.UseVisualStyleBackColor = false;
            this.btnDeleteInteraction.Click += new System.EventHandler(this.btnDeleteInteraction_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnEdit.Location = new System.Drawing.Point(757, 115);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(98, 28);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit Client";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(103)))), ((int)(((byte)(242)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(867, 115);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(98, 28);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "← Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ClientDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(975, 635);
            this.Controls.Add(this.panelTopBar);
            this.Controls.Add(this.panelClientInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDeals);
            this.Controls.Add(this.btnAddDeal);
            this.Controls.Add(this.btnEditDeal);
            this.Controls.Add(this.btnDeleteDeal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvInteractions);
            this.Controls.Add(this.btnAddInteraction);
            this.Controls.Add(this.btnEditInteraction);
            this.Controls.Add(this.btnDeleteInteraction);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "ClientDetailForm";
            this.Text = "Client Details";
            this.panelClientInfo.ResumeLayout(false);
            this.panelClientInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInteractions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.Panel panelClientInfo;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblSubInfo;
        private System.Windows.Forms.Label lblTempBadge;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label divider1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDeals;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvInteractions;
        private System.Windows.Forms.Button btnAddDeal;
        private System.Windows.Forms.Button btnAddInteraction;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnEditDeal;
        private System.Windows.Forms.Button btnDeleteDeal;
        private System.Windows.Forms.Button btnEditInteraction;
        private System.Windows.Forms.Button btnDeleteInteraction;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDealTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDealValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDealStage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDealProbability;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIntType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIntDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSummary;
    }
}