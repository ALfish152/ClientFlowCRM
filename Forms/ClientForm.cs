using ClientFlowCRM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ClientFlowCRM
{
    public partial class ClientForm : Form
    {
        public Client ClientData { get; private set; }

        public ClientForm()
        {
            InitializeComponent();
            ClientData = null;
            this.Text = "Add New Client";
            cmbSource.SelectedIndex = 0;
        }

        public ClientForm(Client existingClient)
        {
            InitializeComponent();
            ClientData = null;
            this.Text = "Edit Client";

            txtName.Text = existingClient.Name;
            txtEmail.Text = existingClient.Email;
            txtPhone.Text = existingClient.Phone;
            txtCompany.Text = existingClient.Company;

            for (int i = 0; i < cmbSource.Items.Count; i++)
            {
                if (cmbSource.Items[i].ToString() == existingClient.Source)
                {
                    cmbSource.SelectedIndex = i;
                    break;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name is required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            ClientData = new Client
            {
                Name = txtName.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Company = txtCompany.Text.Trim(),
                Source = cmbSource.SelectedItem?.ToString() ?? "Website"
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}