namespace ClientFlowCRM
{
    partial class InteractionForm
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
            this.rbCall = new System.Windows.Forms.RadioButton();
            this.rbEmail = new System.Windows.Forms.RadioButton();
            this.rbMeeting = new System.Windows.Forms.RadioButton();
            this.lblField1 = new System.Windows.Forms.Label();
            this.txtField1 = new System.Windows.Forms.TextBox();
            this.lblField2 = new System.Windows.Forms.Label();
            this.txtField2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbCall
            // 
            this.rbCall.AutoSize = true;
            this.rbCall.Checked = true;
            this.rbCall.Location = new System.Drawing.Point(55, 40);
            this.rbCall.Name = "rbCall";
            this.rbCall.Size = new System.Drawing.Size(42, 17);
            this.rbCall.TabIndex = 0;
            this.rbCall.TabStop = true;
            this.rbCall.Text = "Call";
            this.rbCall.UseVisualStyleBackColor = true;
            // 
            // rbEmail
            // 
            this.rbEmail.AutoSize = true;
            this.rbEmail.Location = new System.Drawing.Point(55, 72);
            this.rbEmail.Name = "rbEmail";
            this.rbEmail.Size = new System.Drawing.Size(50, 17);
            this.rbEmail.TabIndex = 1;
            this.rbEmail.Text = "Email";
            this.rbEmail.UseVisualStyleBackColor = true;
            // 
            // rbMeeting
            // 
            this.rbMeeting.AutoSize = true;
            this.rbMeeting.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbMeeting.Location = new System.Drawing.Point(55, 107);
            this.rbMeeting.Name = "rbMeeting";
            this.rbMeeting.Size = new System.Drawing.Size(63, 17);
            this.rbMeeting.TabIndex = 2;
            this.rbMeeting.Text = "Meeting";
            this.rbMeeting.UseVisualStyleBackColor = true;
            // 
            // lblField1
            // 
            this.lblField1.AutoSize = true;
            this.lblField1.Location = new System.Drawing.Point(55, 146);
            this.lblField1.Name = "lblField1";
            this.lblField1.Size = new System.Drawing.Size(75, 13);
            this.lblField1.TabIndex = 3;
            this.lblField1.Text = "Duration (min):";
            // 
            // txtField1
            // 
            this.txtField1.Location = new System.Drawing.Point(151, 143);
            this.txtField1.Name = "txtField1";
            this.txtField1.Size = new System.Drawing.Size(100, 20);
            this.txtField1.TabIndex = 4;
            // 
            // lblField2
            // 
            this.lblField2.AutoSize = true;
            this.lblField2.Location = new System.Drawing.Point(55, 181);
            this.lblField2.Name = "lblField2";
            this.lblField2.Size = new System.Drawing.Size(53, 13);
            this.lblField2.TabIndex = 5;
            this.lblField2.Text = "Outcome:";
            // 
            // txtField2
            // 
            this.txtField2.Location = new System.Drawing.Point(151, 174);
            this.txtField2.Name = "txtField2";
            this.txtField2.Size = new System.Drawing.Size(100, 20);
            this.txtField2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Notes:";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(151, 219);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(100, 20);
            this.txtNotes.TabIndex = 8;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(14, 298);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(135, 298);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // InteractionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtField2);
            this.Controls.Add(this.lblField2);
            this.Controls.Add(this.txtField1);
            this.Controls.Add(this.lblField1);
            this.Controls.Add(this.rbMeeting);
            this.Controls.Add(this.rbEmail);
            this.Controls.Add(this.rbCall);
            this.Name = "InteractionForm";
            this.Text = "InteractionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbCall;
        private System.Windows.Forms.RadioButton rbEmail;
        private System.Windows.Forms.RadioButton rbMeeting;
        private System.Windows.Forms.Label lblField1;
        private System.Windows.Forms.TextBox txtField1;
        private System.Windows.Forms.Label lblField2;
        private System.Windows.Forms.TextBox txtField2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}