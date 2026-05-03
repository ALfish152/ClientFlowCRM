namespace ClientFlowCRM
{
    partial class ClientDetailForm
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDeals = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvInteractions = new System.Windows.Forms.DataGridView();
            this.btnAddDeal = new System.Windows.Forms.Button();
            this.btnAddInteraction = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnEditDeal = new System.Windows.Forms.Button();
            this.btnDeleteDeal = new System.Windows.Forms.Button();
            this.btnEditInteraction = new System.Windows.Forms.Button();
            this.btnDeleteInteraction = new System.Windows.Forms.Button();
            this.colDealTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDealValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDealStage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDealProbability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIntType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIntDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSummary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInteractions)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(8, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(245, 37);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "malaking font to";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DEALS:";
            // 
            // dgvDeals
            // 
            this.dgvDeals.AllowUserToAddRows = false;
            this.dgvDeals.AllowUserToDeleteRows = false;
            this.dgvDeals.AllowUserToResizeRows = false;
            this.dgvDeals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDealTitle,
            this.colDealValue,
            this.colDealStage,
            this.colDealProbability});
            this.dgvDeals.Location = new System.Drawing.Point(12, 79);
            this.dgvDeals.MultiSelect = false;
            this.dgvDeals.Name = "dgvDeals";
            this.dgvDeals.ReadOnly = true;
            this.dgvDeals.RowHeadersVisible = false;
            this.dgvDeals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeals.Size = new System.Drawing.Size(934, 200);
            this.dgvDeals.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "INTERACTIONS:";
            // 
            // dgvInteractions
            // 
            this.dgvInteractions.AllowUserToAddRows = false;
            this.dgvInteractions.AllowUserToDeleteRows = false;
            this.dgvInteractions.AllowUserToResizeRows = false;
            this.dgvInteractions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInteractions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIntType,
            this.colIntDate,
            this.colSummary});
            this.dgvInteractions.Location = new System.Drawing.Point(12, 319);
            this.dgvInteractions.MultiSelect = false;
            this.dgvInteractions.Name = "dgvInteractions";
            this.dgvInteractions.ReadOnly = true;
            this.dgvInteractions.RowHeadersVisible = false;
            this.dgvInteractions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInteractions.Size = new System.Drawing.Size(934, 188);
            this.dgvInteractions.TabIndex = 4;
            // 
            // btnAddDeal
            // 
            this.btnAddDeal.Location = new System.Drawing.Point(709, 285);
            this.btnAddDeal.Name = "btnAddDeal";
            this.btnAddDeal.Size = new System.Drawing.Size(75, 23);
            this.btnAddDeal.TabIndex = 5;
            this.btnAddDeal.Text = "Add Deal";
            this.btnAddDeal.UseVisualStyleBackColor = true;
            this.btnAddDeal.Click += new System.EventHandler(this.btnAddDeal_Click);
            // 
            // btnAddInteraction
            // 
            this.btnAddInteraction.Location = new System.Drawing.Point(585, 513);
            this.btnAddInteraction.Name = "btnAddInteraction";
            this.btnAddInteraction.Size = new System.Drawing.Size(118, 23);
            this.btnAddInteraction.TabIndex = 6;
            this.btnAddInteraction.Text = "Add Interaction";
            this.btnAddInteraction.UseVisualStyleBackColor = true;
            this.btnAddInteraction.Click += new System.EventHandler(this.btnAddInteraction_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(887, 541);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit Client";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(968, 541);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnEditDeal
            // 
            this.btnEditDeal.Location = new System.Drawing.Point(790, 285);
            this.btnEditDeal.Name = "btnEditDeal";
            this.btnEditDeal.Size = new System.Drawing.Size(75, 23);
            this.btnEditDeal.TabIndex = 9;
            this.btnEditDeal.Text = "Edit Deal";
            this.btnEditDeal.UseVisualStyleBackColor = true;
            this.btnEditDeal.Click += new System.EventHandler(this.btnEditDeal_Click);
            // 
            // btnDeleteDeal
            // 
            this.btnDeleteDeal.Location = new System.Drawing.Point(871, 285);
            this.btnDeleteDeal.Name = "btnDeleteDeal";
            this.btnDeleteDeal.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteDeal.TabIndex = 10;
            this.btnDeleteDeal.Text = "Delete Deal";
            this.btnDeleteDeal.UseVisualStyleBackColor = true;
            this.btnDeleteDeal.Click += new System.EventHandler(this.btnDeleteDeal_Click);
            // 
            // btnEditInteraction
            // 
            this.btnEditInteraction.Location = new System.Drawing.Point(709, 513);
            this.btnEditInteraction.Name = "btnEditInteraction";
            this.btnEditInteraction.Size = new System.Drawing.Size(118, 23);
            this.btnEditInteraction.TabIndex = 11;
            this.btnEditInteraction.Text = "Edit Interaction";
            this.btnEditInteraction.UseVisualStyleBackColor = true;
            this.btnEditInteraction.Click += new System.EventHandler(this.btnEditInteraction_Click);
            // 
            // btnDeleteInteraction
            // 
            this.btnDeleteInteraction.Location = new System.Drawing.Point(833, 513);
            this.btnDeleteInteraction.Name = "btnDeleteInteraction";
            this.btnDeleteInteraction.Size = new System.Drawing.Size(118, 23);
            this.btnDeleteInteraction.TabIndex = 12;
            this.btnDeleteInteraction.Text = "Delete Interaction";
            this.btnDeleteInteraction.UseVisualStyleBackColor = true;
            this.btnDeleteInteraction.Click += new System.EventHandler(this.btnDeleteInteraction_Click);
            // 
            // colDealTitle
            // 
            this.colDealTitle.DataPropertyName = "Title";
            this.colDealTitle.HeaderText = "Title";
            this.colDealTitle.MinimumWidth = 100;
            this.colDealTitle.Name = "colDealTitle";
            this.colDealTitle.ReadOnly = true;
            // 
            // colDealValue
            // 
            this.colDealValue.DataPropertyName = "Value";
            this.colDealValue.HeaderText = "Value";
            this.colDealValue.MinimumWidth = 100;
            this.colDealValue.Name = "colDealValue";
            this.colDealValue.ReadOnly = true;
            // 
            // colDealStage
            // 
            this.colDealStage.DataPropertyName = "Stage";
            this.colDealStage.HeaderText = "Stage";
            this.colDealStage.MinimumWidth = 100;
            this.colDealStage.Name = "colDealStage";
            this.colDealStage.ReadOnly = true;
            // 
            // colDealProbability
            // 
            this.colDealProbability.DataPropertyName = "WinProbability";
            this.colDealProbability.HeaderText = "Probability";
            this.colDealProbability.MinimumWidth = 100;
            this.colDealProbability.Name = "colDealProbability";
            this.colDealProbability.ReadOnly = true;
            // 
            // colIntType
            // 
            this.colIntType.DataPropertyName = "Type";
            this.colIntType.HeaderText = "Type";
            this.colIntType.MinimumWidth = 100;
            this.colIntType.Name = "colIntType";
            this.colIntType.ReadOnly = true;
            // 
            // colIntDate
            // 
            this.colIntDate.DataPropertyName = "Timestamp";
            this.colIntDate.HeaderText = "Date";
            this.colIntDate.MinimumWidth = 100;
            this.colIntDate.Name = "colIntDate";
            this.colIntDate.ReadOnly = true;
            // 
            // colSummary
            // 
            this.colSummary.DataPropertyName = "Summary";
            this.colSummary.HeaderText = "Details";
            this.colSummary.MinimumWidth = 100;
            this.colSummary.Name = "colSummary";
            this.colSummary.ReadOnly = true;
            // 
            // ClientDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 576);
            this.Controls.Add(this.btnDeleteInteraction);
            this.Controls.Add(this.btnEditInteraction);
            this.Controls.Add(this.btnDeleteDeal);
            this.Controls.Add(this.btnEditDeal);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAddInteraction);
            this.Controls.Add(this.btnAddDeal);
            this.Controls.Add(this.dgvInteractions);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvDeals);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHeader);
            this.Name = "ClientDetailForm";
            this.Text = "ClientDetailForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInteractions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
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