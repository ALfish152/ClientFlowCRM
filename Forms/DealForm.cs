using System;
using System.Windows.Forms;
using ClientFlowCRM.Models;

namespace ClientFlowCRM
{
    public partial class DealForm : Form
    {
        public Deal DealData { get; private set; }

        // Constructor for adding a new deal
        public DealForm(string clientName)
        {
            InitializeComponent();
            cmbStage.SelectedIndex = 0;
            this.Text = "Add New Deal";
            lblTitle.Text = "Add New Deal";
            lblClientName.Text = "Client: " + clientName;
        }

        // Constructor for editing an existing deal
        public DealForm(Deal existingDeal, string clientName)
        {
            InitializeComponent();
            this.Text = "Edit Deal";
            lblTitle.Text = "Edit Deal";
            lblClientName.Text = "Client: " + clientName;

            txtTitle.Text = existingDeal.Title;
            numValue.Value = existingDeal.Value;

            
            for (int i = 0; i < cmbStage.Items.Count; i++)
            {
                if (cmbStage.Items[i].ToString() == existingDeal.Stage)
                {
                    cmbStage.SelectedIndex = i;
                    break;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate Title
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Title is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitle.Focus();
                return;
            }

            // Validate Stage
            if (cmbStage.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a stage.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbStage.Focus();
                return;
            }

            // Validate Close Date is not in the past
            if (dtpCloseDate.Value.Date < DateTime.Today)
            {
                var confirm = MessageBox.Show(
                    "The close date is in the past. Continue anyway?",
                    "Date Warning",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm == DialogResult.No)
                {
                    dtpCloseDate.Focus();
                    return;
                }
            }

            DealData = new Deal
            {
                Title = txtTitle.Text.Trim(),
                Value = numValue.Value,
                Stage = cmbStage.SelectedItem.ToString(),
            };

            DealData.UpdateCalculatedFields();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Discard this deal?",
                "Cancel",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }

        private void txtTitle_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
    }
}