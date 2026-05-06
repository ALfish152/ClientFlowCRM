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
        }

        // Edit existing interaction
        public InteractionForm(Interaction existingInteraction, string clientName)
        {
            InitializeComponent();
            lblClientName.Text = "Client: " + clientName;

            txtNotes.Text = existingInteraction.Notes;


            if (existingInteraction is Call call)
            {
                rbCall.Checked = true;
                numDuration.Value = call.Duration;
                txtField2.Text = call.Outcome;
            }
            else if (existingInteraction is Email)
            {
                rbEmail.Checked = true;
            }
            else if (existingInteraction is Meeting)
            {
                rbMeeting.Checked = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtField2.Text) && rbCall.Checked)
            {
                MessageBox.Show("Outcome is required for a Call.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtField2.Focus();
                return;
            }

            if (numDuration.Value == 0 && rbCall.Checked)
            {
                MessageBox.Show("Please enter a duration.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numDuration.Focus();
                return;
            }

            if (rbCall.Checked)
            {
                InteractionData = new Call
                {
                    Duration = (int)numDuration.Value,
                    Outcome = txtField2.Text.Trim(),
                    Notes = txtNotes.Text.Trim(),
                };
            }
            else if (rbEmail.Checked)
            {
                InteractionData = new Email
                {
                    Subject = txtField2.Text.Trim(),
                    Notes = txtNotes.Text.Trim(),
                };
            }
            else if (rbMeeting.Checked)
            {
                InteractionData = new Meeting
                {
                    Notes = txtNotes.Text.Trim(),
                };
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Discard this interaction?", "Cancel",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }
    }
}