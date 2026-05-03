using System;
using System.Windows.Forms;
using ClientFlowCRM.Models;

namespace ClientFlowCRM
{
    public partial class DealForm : Form
    {
        public Deal DealData { get; private set; }

        public DealForm()
        {
            InitializeComponent();
            cmbStage.SelectedIndex = 0;
            this.Text = "Add New Deal";
        }

        public DealForm(Deal existingDeal)
        {
            InitializeComponent();
            this.Text = "Edit Deal";

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
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Title is required.", "Error");
                return;
            }

            DealData = new Deal
            {
                Title = txtTitle.Text.Trim(),
                Value = numValue.Value,
                Stage = cmbStage.SelectedItem.ToString()
            };
            DealData.UpdateCalculatedFields();

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