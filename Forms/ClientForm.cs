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

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClientForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            e.Graphics.FillEllipse(new SolidBrush(Color.FromArgb(238, 237, 254)),
                0, 0, 40, 40);
            e.Graphics.DrawEllipse(new Pen(Color.FromArgb(83, 74, 183), 2),
                13, 6, 14, 14);
            e.Graphics.DrawArc(new Pen(Color.FromArgb(83, 74, 183), 2),
                6, 22, 28, 20, 180, 180);
        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}