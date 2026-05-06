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
            System.Windows.Forms.DataGridViewCellStyle dealHeaderStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle intHeaderStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle cellStyle = new System.Windows.Forms.DataGridViewCellStyle();

            this.panelTopBar = new System.Windows.Forms.Panel();
            this.panelClientInfo = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblSubInfo = new System.Windows.Forms.Label();
            this.lblTempBadge = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblSource = new System.Windows.Forms.Label();
            this.divider1 = new System.Windows.Forms.Label();
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

            ((System.ComponentModel.ISupportInitialize)(this.dgvDeals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInteractions)).BeginInit();
            this.panelClientInfo.SuspendLayout();
            this.SuspendLayout();

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            this.ClientSize = new System.Drawing.Size(1300, 820);
            this.MaximizeBox = false;
            this.Name = "ClientDetailForm";
            this.Text = "Client Details";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.panelTopBar.BackColor = System.Drawing.Color.FromArgb(59, 103, 242);
            this.panelTopBar.Location = new System.Drawing.Point(0, 0);
            this.panelTopBar.Size = new System.Drawing.Size(1300, 5);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.TabIndex = 50;

            this.panelClientInfo.BackColor = System.Drawing.Color.White;
            this.panelClientInfo.Location = new System.Drawing.Point(16, 16);
            this.panelClientInfo.Size = new System.Drawing.Size(1268, 120);
            this.panelClientInfo.Name = "panelClientInfo";
            this.panelClientInfo.TabIndex = 51;
            this.panelClientInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelClientInfo_Paint);

            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(30, 32, 36);
            this.lblHeader.Location = new System.Drawing.Point(20, 14);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Client Name";
            this.lblHeader.Click += new System.EventHandler(this.lblHeader_Click);

            this.lblTempBadge.AutoSize = false;
            this.lblTempBadge.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTempBadge.ForeColor = System.Drawing.Color.White;
            this.lblTempBadge.BackColor = System.Drawing.Color.FromArgb(96, 165, 250);
            this.lblTempBadge.Location = new System.Drawing.Point(20, 52);
            this.lblTempBadge.Size = new System.Drawing.Size(60, 24);
            this.lblTempBadge.Name = "lblTempBadge";
            this.lblTempBadge.TabIndex = 1;
            this.lblTempBadge.Text = "Cold";
            this.lblTempBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblSubInfo.AutoSize = true;
            this.lblSubInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubInfo.ForeColor = System.Drawing.Color.FromArgb(140, 145, 155);
            this.lblSubInfo.Location = new System.Drawing.Point(90, 58);
            this.lblSubInfo.Name = "lblSubInfo";
            this.lblSubInfo.TabIndex = 2;
            this.lblSubInfo.Text = "Score: 0.0";

            this.divider1.BackColor = System.Drawing.Color.FromArgb(220, 223, 228);
            this.divider1.Location = new System.Drawing.Point(20, 86);
            this.divider1.Size = new System.Drawing.Size(1228, 1);
            this.divider1.Name = "divider1";
            this.divider1.TabIndex = 98;
            this.divider1.Text = "";

            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(75, 85, 99);
            this.lblEmail.Location = new System.Drawing.Point(20, 94);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "📧 email@example.com";

            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(75, 85, 99);
            this.lblPhone.Location = new System.Drawing.Point(260, 94);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "📞 phone";

            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCompany.ForeColor = System.Drawing.Color.FromArgb(75, 85, 99);
            this.lblCompany.Location = new System.Drawing.Point(500, 94);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.TabIndex = 5;
            this.lblCompany.Text = "🏢 company";

            this.lblSource.AutoSize = true;
            this.lblSource.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSource.ForeColor = System.Drawing.Color.FromArgb(75, 85, 99);
            this.lblSource.Location = new System.Drawing.Point(740, 94);
            this.lblSource.Name = "lblSource";
            this.lblSource.TabIndex = 6;
            this.lblSource.Text = "🔗 source";

            this.panelClientInfo.Controls.Add(this.lblHeader);
            this.panelClientInfo.Controls.Add(this.lblTempBadge);
            this.panelClientInfo.Controls.Add(this.lblSubInfo);
            this.panelClientInfo.Controls.Add(this.divider1);
            this.panelClientInfo.Controls.Add(this.lblEmail);
            this.panelClientInfo.Controls.Add(this.lblPhone);
            this.panelClientInfo.Controls.Add(this.lblCompany);
            this.panelClientInfo.Controls.Add(this.lblSource);

            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(30, 32, 36);
            this.label2.Location = new System.Drawing.Point(16, 152);
            this.label2.Name = "label2";
            this.label2.TabIndex = 1;
            this.label2.Text = "DEALS";

            dealHeaderStyle.BackColor = System.Drawing.Color.FromArgb(210, 213, 242);
            dealHeaderStyle.ForeColor = System.Drawing.Color.FromArgb(30, 32, 36);
            dealHeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dealHeaderStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dealHeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(180, 183, 220);
            dealHeaderStyle.SelectionForeColor = System.Drawing.Color.FromArgb(30, 32, 36);

            cellStyle.BackColor = System.Drawing.Color.White;
            cellStyle.ForeColor = System.Drawing.Color.FromArgb(30, 32, 36);
            cellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            cellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(210, 213, 242);
            cellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(30, 32, 36);

            this.dgvDeals.AllowUserToAddRows = false;
            this.dgvDeals.AllowUserToDeleteRows = false;
            this.dgvDeals.AllowUserToResizeRows = false;
            this.dgvDeals.BackgroundColor = System.Drawing.Color.White;
            this.dgvDeals.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDeals.ColumnHeadersDefaultCellStyle = dealHeaderStyle;
            this.dgvDeals.DefaultCellStyle = cellStyle;
            this.dgvDeals.EnableHeadersVisualStyles = false;
            this.dgvDeals.ColumnHeadersHeight = 36;
            this.dgvDeals.GridColor = System.Drawing.Color.FromArgb(220, 223, 228);
            this.dgvDeals.RowHeadersVisible = false;
            this.dgvDeals.MultiSelect = false;
            this.dgvDeals.ReadOnly = true;
            this.dgvDeals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeals.Location = new System.Drawing.Point(16, 175);
            this.dgvDeals.Size = new System.Drawing.Size(1268, 220);
            this.dgvDeals.Name = "dgvDeals";
            this.dgvDeals.TabIndex = 2;
            this.dgvDeals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colDealTitle, this.colDealValue, this.colDealStage, this.colDealProbability });

            this.colDealTitle.DataPropertyName = "Title";
            this.colDealTitle.HeaderText = "Title";
            this.colDealTitle.Width = 300;
            this.colDealTitle.MinimumWidth = 100;
            this.colDealTitle.Name = "colDealTitle";
            this.colDealTitle.ReadOnly = true;

            this.colDealValue.DataPropertyName = "Value";
            this.colDealValue.HeaderText = "Value (₱)";
            this.colDealValue.Width = 150;
            this.colDealValue.MinimumWidth = 100;
            this.colDealValue.Name = "colDealValue";
            this.colDealValue.ReadOnly = true;

            this.colDealStage.DataPropertyName = "Stage";
            this.colDealStage.HeaderText = "Stage";
            this.colDealStage.Width = 150;
            this.colDealStage.MinimumWidth = 100;
            this.colDealStage.Name = "colDealStage";
            this.colDealStage.ReadOnly = true;

            this.colDealProbability.DataPropertyName = "WinProbability";
            this.colDealProbability.HeaderText = "Win Probability";
            this.colDealProbability.Width = 150;
            this.colDealProbability.MinimumWidth = 100;
            this.colDealProbability.Name = "colDealProbability";
            this.colDealProbability.ReadOnly = true;

            this.btnAddDeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDeal.FlatAppearance.BorderSize = 0;
            this.btnAddDeal.BackColor = System.Drawing.Color.FromArgb(59, 103, 242);
            this.btnAddDeal.ForeColor = System.Drawing.Color.White;
            this.btnAddDeal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddDeal.Location = new System.Drawing.Point(878, 406);
            this.btnAddDeal.Size = new System.Drawing.Size(130, 34);
            this.btnAddDeal.Name = "btnAddDeal";
            this.btnAddDeal.TabIndex = 5;
            this.btnAddDeal.Text = "+ Add Deal";
            this.btnAddDeal.UseVisualStyleBackColor = false;
            this.btnAddDeal.Click += new System.EventHandler(this.btnAddDeal_Click);

            this.btnEditDeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditDeal.FlatAppearance.BorderSize = 0;
            this.btnEditDeal.BackColor = System.Drawing.Color.FromArgb(210, 213, 218);
            this.btnEditDeal.ForeColor = System.Drawing.Color.FromArgb(30, 32, 36);
            this.btnEditDeal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEditDeal.Location = new System.Drawing.Point(1018, 406);
            this.btnEditDeal.Size = new System.Drawing.Size(130, 34);
            this.btnEditDeal.Name = "btnEditDeal";
            this.btnEditDeal.TabIndex = 9;
            this.btnEditDeal.Text = "Edit Deal";
            this.btnEditDeal.UseVisualStyleBackColor = false;
            this.btnEditDeal.Click += new System.EventHandler(this.btnEditDeal_Click);

            this.btnDeleteDeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDeal.FlatAppearance.BorderSize = 0;
            this.btnDeleteDeal.BackColor = System.Drawing.Color.FromArgb(127, 29, 29);
            this.btnDeleteDeal.ForeColor = System.Drawing.Color.White;
            this.btnDeleteDeal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeleteDeal.Location = new System.Drawing.Point(1158, 406);
            this.btnDeleteDeal.Size = new System.Drawing.Size(130, 34);
            this.btnDeleteDeal.Name = "btnDeleteDeal";
            this.btnDeleteDeal.TabIndex = 10;
            this.btnDeleteDeal.Text = "Delete Deal";
            this.btnDeleteDeal.UseVisualStyleBackColor = false;
            this.btnDeleteDeal.Click += new System.EventHandler(this.btnDeleteDeal_Click);

            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(30, 32, 36);
            this.label3.Location = new System.Drawing.Point(16, 456);
            this.label3.Name = "label3";
            this.label3.TabIndex = 3;
            this.label3.Text = "INTERACTIONS";
            this.label3.Click += new System.EventHandler(this.label3_Click);

            intHeaderStyle.BackColor = System.Drawing.Color.FromArgb(210, 213, 242);
            intHeaderStyle.ForeColor = System.Drawing.Color.FromArgb(30, 32, 36);
            intHeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            intHeaderStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            intHeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(180, 183, 220);
            intHeaderStyle.SelectionForeColor = System.Drawing.Color.FromArgb(30, 32, 36);

            this.dgvInteractions.AllowUserToAddRows = false;
            this.dgvInteractions.AllowUserToDeleteRows = false;
            this.dgvInteractions.AllowUserToResizeRows = false;
            this.dgvInteractions.BackgroundColor = System.Drawing.Color.White;
            this.dgvInteractions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInteractions.ColumnHeadersDefaultCellStyle = intHeaderStyle;
            this.dgvInteractions.DefaultCellStyle = cellStyle;
            this.dgvInteractions.EnableHeadersVisualStyles = false;
            this.dgvInteractions.ColumnHeadersHeight = 36;
            this.dgvInteractions.GridColor = System.Drawing.Color.FromArgb(220, 223, 228);
            this.dgvInteractions.RowHeadersVisible = false;
            this.dgvInteractions.MultiSelect = false;
            this.dgvInteractions.ReadOnly = true;
            this.dgvInteractions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInteractions.Location = new System.Drawing.Point(16, 480);
            this.dgvInteractions.Size = new System.Drawing.Size(1268, 220);
            this.dgvInteractions.Name = "dgvInteractions";
            this.dgvInteractions.TabIndex = 4;
            this.dgvInteractions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colIntType, this.colIntDate, this.colSummary });
            this.dgvInteractions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInteractions_CellContentClick);

            this.colIntType.DataPropertyName = "Type";
            this.colIntType.HeaderText = "Type";
            this.colIntType.Width = 150;
            this.colIntType.MinimumWidth = 100;
            this.colIntType.Name = "colIntType";
            this.colIntType.ReadOnly = true;

            this.colIntDate.DataPropertyName = "Timestamp";
            this.colIntDate.HeaderText = "Date";
            this.colIntDate.Width = 180;
            this.colIntDate.MinimumWidth = 100;
            this.colIntDate.Name = "colIntDate";
            this.colIntDate.ReadOnly = true;

            this.colSummary.DataPropertyName = "Summary";
            this.colSummary.HeaderText = "Details";
            this.colSummary.Width = 500;
            this.colSummary.MinimumWidth = 100;
            this.colSummary.Name = "colSummary";
            this.colSummary.ReadOnly = true;

            this.btnAddInteraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddInteraction.FlatAppearance.BorderSize = 0;
            this.btnAddInteraction.BackColor = System.Drawing.Color.FromArgb(59, 103, 242);
            this.btnAddInteraction.ForeColor = System.Drawing.Color.White;
            this.btnAddInteraction.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddInteraction.Location = new System.Drawing.Point(878, 710);
            this.btnAddInteraction.Size = new System.Drawing.Size(130, 34);
            this.btnAddInteraction.Name = "btnAddInteraction";
            this.btnAddInteraction.TabIndex = 6;
            this.btnAddInteraction.Text = "+ Add";
            this.btnAddInteraction.UseVisualStyleBackColor = false;
            this.btnAddInteraction.Click += new System.EventHandler(this.btnAddInteraction_Click);

            this.btnEditInteraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditInteraction.FlatAppearance.BorderSize = 0;
            this.btnEditInteraction.BackColor = System.Drawing.Color.FromArgb(210, 213, 218);
            this.btnEditInteraction.ForeColor = System.Drawing.Color.FromArgb(30, 32, 36);
            this.btnEditInteraction.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEditInteraction.Location = new System.Drawing.Point(1018, 710);
            this.btnEditInteraction.Size = new System.Drawing.Size(130, 34);
            this.btnEditInteraction.Name = "btnEditInteraction";
            this.btnEditInteraction.TabIndex = 11;
            this.btnEditInteraction.Text = "Edit";
            this.btnEditInteraction.UseVisualStyleBackColor = false;
            this.btnEditInteraction.Click += new System.EventHandler(this.btnEditInteraction_Click);

            this.btnDeleteInteraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteInteraction.FlatAppearance.BorderSize = 0;
            this.btnDeleteInteraction.BackColor = System.Drawing.Color.FromArgb(127, 29, 29);
            this.btnDeleteInteraction.ForeColor = System.Drawing.Color.White;
            this.btnDeleteInteraction.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeleteInteraction.Location = new System.Drawing.Point(1158, 710);
            this.btnDeleteInteraction.Size = new System.Drawing.Size(130, 34);
            this.btnDeleteInteraction.Name = "btnDeleteInteraction";
            this.btnDeleteInteraction.TabIndex = 12;
            this.btnDeleteInteraction.Text = "Delete";
            this.btnDeleteInteraction.UseVisualStyleBackColor = false;
            this.btnDeleteInteraction.Click += new System.EventHandler(this.btnDeleteInteraction_Click);

            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(210, 213, 218);
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(30, 32, 36);
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEdit.Location = new System.Drawing.Point(1018, 762);
            this.btnEdit.Size = new System.Drawing.Size(130, 34);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit Client";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(59, 103, 242);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBack.Location = new System.Drawing.Point(1158, 762);
            this.btnBack.Size = new System.Drawing.Size(130, 34);
            this.btnBack.Name = "btnBack";
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "← Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

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

            ((System.ComponentModel.ISupportInitialize)(this.dgvDeals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInteractions)).EndInit();
            this.panelClientInfo.ResumeLayout(false);
            this.panelClientInfo.PerformLayout();
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