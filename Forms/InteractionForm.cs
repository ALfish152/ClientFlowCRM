using ClientFlowCRM.Models;
using System;
using System.Windows.Forms;

namespace ClientFlowCRM
{
    public partial class InteractionForm : Form
    {
        public Interaction InteractionData { get; private set; }

        // Add new interaction
        public InteractionForm(string clientName)
        {
            InitializeComponent();
            lblClientName.Text = "Client: " + clientName;
            rbCall.Checked = true;
            dtpInteraction.Value = DateTime.Now;  // Default to now for new
            UpdateFields();
        }

        // Edit existing interaction
        public InteractionForm(Interaction existingInteraction, string clientName)
        {
            InitializeComponent();
            lblClientName.Text = "Client: " + clientName;

            dtpInteraction.Value = existingInteraction.Timestamp;  // Load original date
            txtNotes.Text = existingInteraction.Notes ?? "";
            numDuration.Value = existingInteraction.Duration;

            if (existingInteraction is Call call)
            {
                rbCall.Checked = true;
                txtOutcome.Text = call.Outcome ?? "";
            }
            else if (existingInteraction is Email email)
            {
                rbEmail.Checked = true;
                txtOutcome.Text = email.Subject ?? "";
            }
            else if (existingInteraction is Meeting meeting)
            {
                rbMeeting.Checked = true;
                txtOutcome.Text = meeting.Location ?? "";
            }

            UpdateFields();
        }

        private void UpdateFields()
        {
            if (rbCall.Checked)
            {
                lblField2.Text = "Outcome:";
                lblDuration.Visible = true;
                numDuration.Visible = true;
            }
            else if (rbEmail.Checked)
            {
                lblField2.Text = "Subject:";
                lblDuration.Visible = false;
                numDuration.Visible = false;
            }
            else
            {
                lblField2.Text = "Location:";
                lblDuration.Visible = true;
                numDuration.Visible = true;
            }
        }

        private void rbCall_CheckedChanged(object sender, EventArgs e) => UpdateFields();
        private void rbEmail_CheckedChanged(object sender, EventArgs e) => UpdateFields();
        private void rbMeeting_CheckedChanged(object sender, EventArgs e) => UpdateFields();

        private void btnSave_Click(object sender, EventArgs e)
        {
            Interaction interaction;

            if (rbCall.Checked)
            {
                interaction = new Call
                {
                    Duration = (int)numDuration.Value,
                    Outcome = txtOutcome.Text.Trim(),
                    Notes = txtNotes.Text.Trim(),
                };
            }
            else if (rbEmail.Checked)
            {
                interaction = new Email
                {
                    Subject = txtOutcome.Text.Trim(),
                    Notes = txtNotes.Text.Trim(),
                };
            }
            else
            {
                interaction = new Meeting
                {
                    Duration = (int)numDuration.Value,
                    Location = txtOutcome.Text.Trim(),
                    Notes = txtNotes.Text.Trim(),
                };
            }

            interaction.Timestamp = dtpInteraction.Value;

            interaction.UpdateSummary();
            InteractionData = interaction;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}