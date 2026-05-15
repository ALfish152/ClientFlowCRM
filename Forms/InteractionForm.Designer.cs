namespace ClientFlowCRM
{
    partial class InteractionForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.rbCall = new System.Windows.Forms.RadioButton();
            this.rbEmail = new System.Windows.Forms.RadioButton();
            this.rbMeeting = new System.Windows.Forms.RadioButton();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.dtpInteraction = new System.Windows.Forms.DateTimePicker();
            this.lblDuration = new System.Windows.Forms.Label();
            this.numDuration = new System.Windows.Forms.NumericUpDown();
            this.lblField2 = new System.Windows.Forms.Label();
            this.txtOutcome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.lblTitle.Location = new System.Drawing.Point(46, 16);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(149, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Log Interaction";
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblClientName.ForeColor = System.Drawing.Color.Gray;
            this.lblClientName.Location = new System.Drawing.Point(46, 41);
            this.lblClientName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(44, 15);
            this.lblClientName.TabIndex = 1;
            this.lblClientName.Text = "Client: ";
            // 
            // rbCall
            // 
            this.rbCall.AutoSize = true;
            this.rbCall.Checked = true;
            this.rbCall.Location = new System.Drawing.Point(49, 73);
            this.rbCall.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbCall.Name = "rbCall";
            this.rbCall.Size = new System.Drawing.Size(42, 17);
            this.rbCall.TabIndex = 0;
            this.rbCall.TabStop = true;
            this.rbCall.Text = "Call";
            this.rbCall.UseVisualStyleBackColor = true;
            this.rbCall.CheckedChanged += new System.EventHandler(this.rbCall_CheckedChanged);
            // 
            // rbEmail
            // 
            this.rbEmail.AutoSize = true;
            this.rbEmail.Location = new System.Drawing.Point(116, 73);
            this.rbEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbEmail.Name = "rbEmail";
            this.rbEmail.Size = new System.Drawing.Size(50, 17);
            this.rbEmail.TabIndex = 1;
            this.rbEmail.Text = "Email";
            this.rbEmail.UseVisualStyleBackColor = true;
            this.rbEmail.CheckedChanged += new System.EventHandler(this.rbEmail_CheckedChanged);
            // 
            // rbMeeting
            // 
            this.rbMeeting.AutoSize = true;
            this.rbMeeting.Location = new System.Drawing.Point(194, 73);
            this.rbMeeting.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbMeeting.Name = "rbMeeting";
            this.rbMeeting.Size = new System.Drawing.Size(63, 17);
            this.rbMeeting.TabIndex = 2;
            this.rbMeeting.Text = "Meeting";
            this.rbMeeting.UseVisualStyleBackColor = true;
            this.rbMeeting.CheckedChanged += new System.EventHandler(this.rbMeeting_CheckedChanged);
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(46, 102);
            this.lblDateTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(62, 13);
            this.lblDateTime.TabIndex = 3;
            this.lblDateTime.Text = "Date & Time:";
            // 
            // dtpInteraction
            // 
            this.dtpInteraction.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.dtpInteraction.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInteraction.Location = new System.Drawing.Point(49, 118);
            this.dtpInteraction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpInteraction.Name = "dtpInteraction";
            this.dtpInteraction.Size = new System.Drawing.Size(166, 20);
            this.dtpInteraction.TabIndex = 3;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(46, 146);
            this.lblDuration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(75, 13);
            this.lblDuration.TabIndex = 4;
            this.lblDuration.Text = "Duration (min):";
            // 
            // numDuration
            // 
            this.numDuration.Location = new System.Drawing.Point(49, 162);
            this.numDuration.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numDuration.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numDuration.Name = "numDuration";
            this.numDuration.Size = new System.Drawing.Size(99, 20);
            this.numDuration.TabIndex = 4;
            // 
            // lblField2
            // 
            this.lblField2.AutoSize = true;
            this.lblField2.Location = new System.Drawing.Point(46, 191);
            this.lblField2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblField2.Name = "lblField2";
            this.lblField2.Size = new System.Drawing.Size(53, 13);
            this.lblField2.TabIndex = 5;
            this.lblField2.Text = "Outcome:";
            // 
            // txtOutcome
            // 
            this.txtOutcome.Location = new System.Drawing.Point(49, 207);
            this.txtOutcome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOutcome.Name = "txtOutcome";
            this.txtOutcome.Size = new System.Drawing.Size(372, 20);
            this.txtOutcome.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 236);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Notes:";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(49, 252);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(372, 73);
            this.txtNotes.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(137, 341);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(247, 341);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // InteractionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 382);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.rbCall);
            this.Controls.Add(this.rbEmail);
            this.Controls.Add(this.rbMeeting);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.dtpInteraction);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.numDuration);
            this.Controls.Add(this.lblField2);
            this.Controls.Add(this.txtOutcome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "InteractionForm";
            this.Text = "Log Interaction";
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.RadioButton rbCall;
        private System.Windows.Forms.RadioButton rbEmail;
        private System.Windows.Forms.RadioButton rbMeeting;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.DateTimePicker dtpInteraction;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.NumericUpDown numDuration;
        private System.Windows.Forms.Label lblField2;
        private System.Windows.Forms.TextBox txtOutcome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}