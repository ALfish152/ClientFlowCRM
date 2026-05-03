using ClientFlowCRM.Data;
using ClientFlowCRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ClientFlowCRM.Algorithms;
using System.Drawing;
using System.IO;

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
            if (_clients == null)
                _clients = new List<Client>();

            foreach (var client in _clients)
            {
                client.UpdateCalculatedFields();
            }

            _nextId = _clients.Any() ? _clients.Max(c => c.Id) + 1 : 1;
            RefreshAll();
        }

        private void ClearSelection()
        {
            try
            {
                if (dgvClients.Rows.Count > 0 && dgvClients.SelectedRows.Count > 0)
                {
                    dgvClients.ClearSelection();
                }
            }
            catch { }
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
                client.UpdateCalculatedFields();
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
            try
            {
                dgvClients.CellClick -= dgvClients_CellClick;

                dgvClients.DataSource = null;

                if (_clients != null && _clients.Count > 0)
                {
                    dgvClients.DataSource = _clients;

                    // Hide columns we don't want to show
                    if (dgvClients.Columns["Deals"] != null)
                        dgvClients.Columns["Deals"].Visible = false;
                    if (dgvClients.Columns["Interactions"] != null)
                        dgvClients.Columns["Interactions"].Visible = false;
                    if (dgvClients.Columns["LastContactDate"] != null)
                        dgvClients.Columns["LastContactDate"].Visible = false;
                    if (dgvClients.Columns["InteractionCount"] != null)
                        dgvClients.Columns["InteractionCount"].Visible = false;
                    if (dgvClients.Columns["IsAtRisk"] != null)
                        dgvClients.Columns["IsAtRisk"].Visible = false;
                    if (dgvClients.Columns["CreatedDate"] != null)
                        dgvClients.Columns["CreatedDate"].Visible = false;

                    // Reorder visible columns
                    string[] columnOrder = { "Id", "Name", "Email", "Phone", "Company", "Source", "Score", "Temperature", "TotalDealValue" };
                    foreach (string colName in columnOrder)
                    {
                        if (dgvClients.Columns[colName] != null)
                        {
                            dgvClients.Columns[colName].DisplayIndex = Array.IndexOf(columnOrder, colName);
                        }
                    }

                    // Set column widths
                    dgvClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                    if (dgvClients.Columns["Id"] != null) dgvClients.Columns["Id"].Width = 40;
                    if (dgvClients.Columns["Name"] != null) dgvClients.Columns["Name"].Width = 150;
                    if (dgvClients.Columns["Email"] != null) dgvClients.Columns["Email"].Width = 180;
                    if (dgvClients.Columns["Phone"] != null) dgvClients.Columns["Phone"].Width = 110;
                    if (dgvClients.Columns["Company"] != null) dgvClients.Columns["Company"].Width = 150;
                    if (dgvClients.Columns["Source"] != null) dgvClients.Columns["Source"].Width = 100;
                    if (dgvClients.Columns["Score"] != null) dgvClients.Columns["Score"].Width = 80;
                    if (dgvClients.Columns["Temperature"] != null) dgvClients.Columns["Temperature"].Width = 100;
                    if (dgvClients.Columns["TotalDealValue"] != null) dgvClients.Columns["TotalDealValue"].Width = 120;

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

                dgvClients.CellClick += dgvClients_CellClick;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"RefreshGrid error: {ex.Message}");
            }
        }

        private void dgvClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //  does nothing, just prevents errors
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            ClientForm form = new ClientForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                form.ClientData.Id = _nextId++;
                form.ClientData.UpdateCalculatedFields();
                _clients.Add(form.ClientData);
                DataManager.SaveData(_clients);
                RefreshAll();
                MessageBox.Show($"Client '{form.ClientData.Name}' added!", "Success");
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
            RefreshAll();
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

            if (_clients.SelectMany(c => c.Deals).Any())
                _nextDealId = _clients.SelectMany(c => c.Deals).Max(d => d.Id) + 1;
            if (_clients.SelectMany(c => c.Interactions).Any())
                _nextInteractionId = _clients.SelectMany(c => c.Interactions).Max(i => i.Id) + 1;

            DataManager.SaveData(_clients);
            RefreshAll();
        }

        private void lstPriority_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void lblAtRiskCount_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshAll();
        }

        private void btnTestSave_Click(object sender, EventArgs e)
        {
            DataManager.SaveData(_clients);
            string path = System.IO.Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "ClientFlowCRM",
                "clients.json");

            bool exists = File.Exists(path);
            string fileContent = exists ? File.ReadAllText(path) : "FILE NOT FOUND";

            MessageBox.Show(
                $"Path: {path}\nExists: {exists}\nClients in memory: {_clients.Count}\n\nFirst 500 chars:\n{fileContent.Substring(0, Math.Min(500, fileContent.Length))}",
                "Save Debug");
        }
    }
}