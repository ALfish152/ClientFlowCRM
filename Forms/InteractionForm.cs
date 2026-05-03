using System;
using System.Windows.Forms;
using ClientFlowCRM.Models;

namespace ClientFlowCRM
{
    public partial class InteractionForm : Form
    {
        public Interaction InteractionData { get; private set; }

        public InteractionForm()
        {
            InitializeComponent();
            this.Text = "Add New Interaction";
        }

        public InteractionForm(Interaction existingInteraction)
        {
            InitializeComponent();
            this.Text = "Edit Interaction";
            txtNotes.Text = existingInteraction.Notes;

            if (existingInteraction is Call call)
            {
                rbCall.Checked = true;
                txtField1.Text = call.Duration.ToString();
                txtField2.Text = call.Outcome;
            }
            else if (existingInteraction is Email email)
            {
                rbEmail.Checked = true;
                txtField1.Text = email.Subject;
            }
            else if (existingInteraction is Meeting meeting)
            {
                rbMeeting.Checked = true;
                txtField1.Text = meeting.Location;
                txtField2.Text = meeting.Attendees;
            }

            UpdateFields();
        }

        private void UpdateFields()
        {
            if (rbCall.Checked)
            {
                lblField1.Text = "Duration (min):";
                lblField2.Text = "Outcome:";
            }
            else if (rbEmail.Checked)
            {
                lblField1.Text = "Subject:";
                lblField2.Text = "Attachment? (y/n):";
            }
            else
            {
                lblField1.Text = "Location:";
                lblField2.Text = "Attendees:";
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
                int.TryParse(txtField1.Text, out int duration);
                interaction = new Call
                {
                    Duration = duration,
                    Outcome = txtField2.Text,
                    Notes = txtNotes.Text
                };
            }
            else if (rbEmail.Checked)
            {
                interaction = new Email
                {
                    Subject = txtField1.Text,
                    Notes = txtNotes.Text
                };
            }
            else
            {
                interaction = new Meeting
                {
                    Location = txtField1.Text,
                    Attendees = txtField2.Text,
                    Notes = txtNotes.Text
                };
            }

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