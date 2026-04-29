using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
