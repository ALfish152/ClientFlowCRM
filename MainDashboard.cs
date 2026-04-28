using ClientFlowCRM.Data;
using ClientFlowCRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ClientFlowCRM
{
    public partial class MainDashboard : Form
    {
        private List<Client> _clients;
        private int _nextId;

        public MainDashboard()
        {
            InitializeComponent();
            _clients = DataManager.LoadData();
            _nextId = _clients.Any() ? _clients.Max(c => c.Id) + 1 : 1;
            RefreshAll();
        }

        private void ClearSelection()
        {
            if (dgvClients.Rows.Count > 0)
            {
                dgvClients.ClearSelection();
                dgvClients.CurrentCell = null;
            }
        }

        private void RefreshAll()
        {
            RefreshStats();
            RefreshGrid();
            ClearSelection();
        }

        private void RefreshStats()
        {
            lblTotalClients.Text = _clients.Count.ToString();
            lblTotalClientsSub.Text = "Total";

            int deals = _clients.Count; // Temporary lang, aayusin pa 
            lblActiveDeals.Text = deals.ToString();
            lblActiveDealsSub.Text = "Active";

            lblForecasted.Text = "₱0";
            lblForecastedSub.Text = "Revenue";

            lblPending.Text = "0";
            lblPendingSub.Text = "Follow-ups";
        }

        private void RefreshGrid()
        {
            dgvClients.DataSource = null;

            if (_clients != null && _clients.Count > 0)
            {
                dgvClients.DataSource = _clients;

                dgvClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                if (dgvClients.Columns.Count >= 6)
                {
                    dgvClients.Columns[0].Width = 40;
                    dgvClients.Columns[1].Width = 160;
                    dgvClients.Columns[2].Width = 190;
                    dgvClients.Columns[3].Width = 120;
                    dgvClients.Columns[4].Width = 160;
                    dgvClients.Columns[5].Width = 110;
                }
            }
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            ClientForm form = new ClientForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                form.ClientData.Id = _nextId++;
                _clients.Add(form.ClientData);
                DataManager.SaveData(_clients);
                RefreshAll();

                MessageBox.Show($"Client '{form.ClientData.Name}' added!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            if (dgvClients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a client first.", "Info");
                return;
            }

            Client selected = (Client)dgvClients.SelectedRows[0].DataBoundItem;
            ClientForm form = new ClientForm(selected);

            if (form.ShowDialog() == DialogResult.OK)
            {
                selected.Name = form.ClientData.Name;
                selected.Email = form.ClientData.Email;
                selected.Phone = form.ClientData.Phone;
                selected.Company = form.ClientData.Company;
                selected.Source = form.ClientData.Source;

                DataManager.SaveData(_clients);
                RefreshAll();

                MessageBox.Show($"Client '{selected.Name}' updated!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            if (dgvClients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a client first.", "Info");
                return;
            }

            Client selected = (Client)dgvClients.SelectedRows[0].DataBoundItem;

            if (MessageBox.Show($"Delete '{selected.Name}'?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _clients.Remove(selected);
                DataManager.SaveData(_clients);
                RefreshAll();

                MessageBox.Show("Client deleted.", "Success");
            }
        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {

        }

        private void dgvClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTotalClients_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalClientsSub_Click(object sender, EventArgs e)
        {

        }

        private void lblActiveDealsSub_Click(object sender, EventArgs e)
        {

        }

        private void lblPendingSub_Click(object sender, EventArgs e)
        {

        }

        private void lblPending_Click(object sender, EventArgs e)
        {

        }

        private void lblForecastedSub_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblActiveDeals_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void lblForecasted_Click(object sender, EventArgs e)
        {

        }
    }
}