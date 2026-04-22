using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClientFlowCRM
{
    public partial class Form1 : Form
    {
        private List<string> _clients = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a name.", "Error");
                return;
            }

            string clientInfo = $"{name} | {email} | {phone}";
            _clients.Add(clientInfo);

            lstClients.Items.Clear();
            foreach (string client in _clients)
            {
                lstClients.Items.Add(client);
            }

            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtName.Focus();

            MessageBox.Show($"Client '{name}' added!", "Success");
        }
    }
}