using ClientFlowCRM.Data;
using ClientFlowCRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ClientFlowCRM.Algorithms;
using System.Drawing;

namespace ClientFlowCRM
{
    public partial class MainDashboard : Form
    {
        private List<Client> _clients;
        private int _nextId;
        private int _nextDealId = 1;
        private int _nextInteractionId = 1;

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

        private LeadScoringModel _scorer = new LeadScoringModel();
        private RevenueForecaster _forecaster = new RevenueForecaster();
        private FollowUpQueue _queue = new FollowUpQueue();

        private void RefreshAll()
        {
            UpdateScores();
            RefreshStats();
            RefreshGrid();
            UpdatePriorityList();
            ClearSelection();
        }

        private void UpdateScores()
        {
            foreach (var client in _clients)
            {
                client.Score = _scorer.CalculateScore(client);
                client.Temperature = _scorer.GetTemperature(client.Score);
            }
        }

        private void UpdatePriorityList()
        {
            lstPriority.Items.Clear();
            var top5 = _queue.GetTopFive(_clients);
            foreach (var c in top5)
            {
                string days = c.LastContactDate.HasValue
                    ? $"{(DateTime.Now - c.LastContactDate.Value).Days}d ago"
                    : "Never";
                lstPriority.Items.Add($"{c.Name} ({c.Temperature}) - {days}");
            }
        }

        private void RefreshStats()
        {
            var allDeals = _clients.SelectMany(c => c.Deals).Where(d => d.IsActive).ToList();
            int atRisk = _clients.Count(c => c.IsAtRisk);

            lblTotalClients.Text = _clients.Count.ToString();
            lblActiveDeals.Text = allDeals.Count.ToString();
            lblForecasted.Text = $"₱{_forecaster.Calculate(allDeals):N0}";
            lblPending.Text = _queue.GetTopFive(_clients).Count.ToString();
            lblAtRiskCount.Text = $"{atRisk} at risk";
        }

        private void RefreshGrid()
        {
            dgvClients.DataSource = null;
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

            foreach (DataGridViewRow row in dgvClients.Rows)
            {
                if (row.DataBoundItem is Client client)
                {
                    if (client.Temperature == "Hot")
                        row.DefaultCellStyle.BackColor = Color.LightPink;
                    else if (client.Temperature == "Warm")
                        row.DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
                    else
                        row.DefaultCellStyle.BackColor = Color.LightBlue;
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



        private void dgvClients_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvClients.Rows[e.RowIndex].DataBoundItem is Client client)
            {
                var form = new ClientDetailForm(client, _clients, _nextDealId, _nextInteractionId);
                form.ShowDialog();

                // Update IDs in case new deals/interactions were added
                if (_clients.SelectMany(c => c.Deals).Any())
                    _nextDealId = _clients.SelectMany(c => c.Deals).Max(d => d.Id) + 1;
                if (_clients.SelectMany(c => c.Interactions).Any())
                    _nextInteractionId = _clients.SelectMany(c => c.Interactions).Max(i => i.Id) + 1;

                DataManager.SaveData(_clients);
                RefreshAll();
            }
        }

        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog
            {
                Filter = "CSV Files|*.csv",
                FileName = "clients_export.csv"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                DataManager.ExportToCSV(_clients, dialog.FileName);
                MessageBox.Show("Exported successfully!", "Success");
            }
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (dgvClients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a client first.", "Info");
                return;
            }

            Client client = (Client)dgvClients.SelectedRows[0].DataBoundItem;
            var form = new ClientDetailForm(client, _clients, _nextDealId, _nextInteractionId);
            form.ShowDialog();

            // Update IDs after returning
            if (_clients.SelectMany(c => c.Deals).Any())
                _nextDealId = _clients.SelectMany(c => c.Deals).Max(d => d.Id) + 1;
            if (_clients.SelectMany(c => c.Interactions).Any())
                _nextInteractionId = _clients.SelectMany(c => c.Interactions).Max(i => i.Id) + 1;

            DataManager.SaveData(_clients);
            RefreshAll();
        }
    }
}