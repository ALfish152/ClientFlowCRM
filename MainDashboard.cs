using ClientFlowCRM.Data;
using ClientFlowCRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ClientFlowCRM.Algorithms;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            this.MaximizeBox = false;
            this.WindowState = FormWindowState.Normal;  
            this.StartPosition = FormStartPosition.CenterScreen;  
            _clients = DataManager.LoadData();
            if (_clients == null)
                _clients = new List<Client>();

            foreach (var client in _clients)
                client.UpdateCalculatedFields();

            _nextId = _clients.Any() ? _clients.Max(c => c.Id) + 1 : 1;
            RefreshAll();
        }

        private GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            var path = new GraphicsPath();
            int d = radius * 2;
            path.AddArc(bounds.X, bounds.Y, d, d, 180, 90);
            path.AddArc(bounds.Right - d, bounds.Y, d, d, 270, 90);
            path.AddArc(bounds.Right - d, bounds.Bottom - d, d, d, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - d, d, d, 90, 90);
            path.CloseAllFigures();
            return path;
        }

        private void ApplyRoundedRegion(Control ctrl, int radius = 18)
        {
            var path = RoundedRect(new Rectangle(0, 0, ctrl.Width, ctrl.Height), radius);
            ctrl.Region = new Region(path);
        }

        private void ApplyRoundedButton(Button btn, int radius = 10)
        {
            var path = RoundedRect(new Rectangle(0, 0, btn.Width, btn.Height), radius);
            btn.Region = new Region(path);
        }

        private void PaintCard(object sender, PaintEventArgs e)
        {
            var ctrl = (Control)sender;
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (var path = RoundedRect(new Rectangle(0, 0, ctrl.Width, ctrl.Height), 18))
            using (var brush = new SolidBrush(Color.White))
                g.FillPath(brush, path);

            using (var path = RoundedRect(new Rectangle(1, 1, ctrl.Width - 2, ctrl.Height - 2), 18))
            using (var pen = new Pen(Color.FromArgb(220, 223, 228), 1f))
                g.DrawPath(pen, path);
        }

        private void SetupUI()
        {
            ApplyRoundedRegion(panel1);
            ApplyRoundedRegion(panel2);
            ApplyRoundedRegion(panel3);
            ApplyRoundedRegion(panel4);
            ApplyRoundedRegion(rrik);

            panel1.Paint += PaintCard;
            panel2.Paint += PaintCard;
            panel3.Paint += PaintCard;
            panel4.Paint += PaintCard;
            rrik.Paint += PaintCard;

            groupBox1.BackColor = Color.Transparent;
            groupBox2.BackColor = Color.Transparent;
            groupBox3.BackColor = Color.Transparent;
            groupBox4.BackColor = Color.Transparent;
            groupBox5.BackColor = Color.Transparent;

            ApplyRoundedButton(btnAddClient);
            ApplyRoundedButton(btnExportCSV);
            ApplyRoundedButton(btnRefresh);
            ApplyRoundedButton(btnEditClient);
            ApplyRoundedButton(btnDeleteClient);
            ApplyRoundedButton(button1);

            ApplyRoundedRegion(lstPriority, 12);
            ApplyRoundedRegion(dgvClients, 12);

            RoundGroupBox(groupBox1);
            RoundGroupBox(groupBox2);
            RoundGroupBox(groupBox3);
            RoundGroupBox(groupBox4);
            RoundGroupBox(groupBox5);

            lstPriority.DrawMode = DrawMode.OwnerDrawFixed;
            var lblPriorityTitle = new Label();
            lblPriorityTitle.Text = "⭐ Follow-up Priority";
            lblPriorityTitle.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
            lblPriorityTitle.ForeColor = Color.FromArgb(30, 32, 60);
            lblPriorityTitle.AutoSize = true;
            lblPriorityTitle.Left = lstPriority.Left;
            lblPriorityTitle.Top = lstPriority.Top - 22;
            lstPriority.Parent.Controls.Add(lblPriorityTitle);
        }

        private void RoundGroupBox(GroupBox gb, int radius = 14)
        {
            gb.Paint += (sender, e) =>
            {
                var box = (GroupBox)sender;
                var g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                using (var path = RoundedRect(new Rectangle(0, 0, box.Width, box.Height), radius))
                using (var brush = new SolidBrush(Color.Transparent))
                {
                    g.Clear(box.BackColor == Color.Transparent
                        ? Color.White
                        : box.BackColor);
                    g.FillPath(brush, path);
                }

                using (var path = RoundedRect(new Rectangle(1, 1, box.Width - 2, box.Height - 2), radius))
                using (var pen = new Pen(Color.FromArgb(210, 213, 220), 1.5f))
                    g.DrawPath(pen, path);

                using (var brush = new SolidBrush(box.ForeColor))
                using (var font = new Font(box.Font.FontFamily, box.Font.Size - 1f, FontStyle.Bold))
                    g.DrawString(box.Text, font, brush, new PointF(10, 4));
            };

            ApplyRoundedRegion(gb, radius);
        }

        private void ClearSelection()
        {
            try
            {
                if (dgvClients.Rows.Count > 0 && dgvClients.SelectedRows.Count > 0)
                    dgvClients.ClearSelection();
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

        
                string emoji = c.Temperature == "Hot" ? "🔥" :
                               c.Temperature == "Warm" ? "🌡" :
                               c.Temperature == "Cold" ? "❄" : "";

                lstPriority.Items.Add($"{c.Name} ({emoji}{c.Temperature}) - {days}");
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
            label3.Text = $"{atRisk} at risk";
        }

        private void ConfigureClientsGrid()
        {
            dgvClients.AutoGenerateColumns = false;
            dgvClients.Columns.Clear();

            var columns = new (string Name, string Header, string DataProperty, int WidthPercent)[]
            {
        ("colName",          "Name",             "Name",            18),
        ("colEmail",         "Email",            "Email",           20),
        ("colPhone",         "Phone",            "Phone",           13),
        ("colCompany",       "Company",          "Company",         16),
        ("colSource",        "Source",           "Source",          10),
        ("colScore",         "Score",            "Score",            7),
        ("colTemperature",   "Temperature",      "Temperature",     10),
        ("colTotalDealValue","Total Deal Value", "TotalDealValue",   6)
            };

            foreach (var col in columns)
            {
                var dgvCol = new DataGridViewTextBoxColumn
                {
                    Name = col.Name,
                    HeaderText = col.Header,
                    DataPropertyName = col.DataProperty
                };
                dgvClients.Columns.Add(dgvCol);
            }

            dgvClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClients.ReadOnly = true;
            dgvClients.AllowUserToAddRows = false;
            dgvClients.AllowUserToDeleteRows = false;
            dgvClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvClients.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(210, 213, 242);
            dgvClients.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(30, 32, 36);
            dgvClients.EnableHeadersVisualStyles = false;

            if (dgvClients.Columns["colTotalDealValue"] != null)
                dgvClients.Columns["colTotalDealValue"].DefaultCellStyle.Format = "₱#,##0";
        }

        private void RefreshGrid()
        {
            try
            {
                dgvClients.CellClick -= dgvClients_CellClick;
                dgvClients.DataSource = null;

                if (_clients != null && _clients.Count > 0)
                {
                    if (dgvClients.Columns.Count == 0)
                        ConfigureClientsGrid();

                    dgvClients.DataSource = _clients;

                    foreach (DataGridViewRow row in dgvClients.Rows)
                    {
                        if (row.DataBoundItem is Client client)
                        {
                            if (client.Temperature == "Hot")
                                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 204, 204);
                            else if (client.Temperature == "Warm")
                                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 243, 205);
                            else
                                row.DefaultCellStyle.BackColor = Color.FromArgb(204, 229, 255);

                            string emoji = client.Temperature == "Hot" ? "🔥 " :
                                           client.Temperature == "Warm" ? "🌡 " : "❄ ";

                            if (dgvClients.Columns["colTemperature"] != null)
                            {
                                row.Cells["colTemperature"].Style.Font = new Font("Segoe UI Emoji", 9f);
                                row.Cells["colTemperature"].Value = emoji + client.Temperature;
                            }

                            if (dgvClients.Columns["colScore"] != null)
                            {
                                row.Cells["colScore"].Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                                row.Cells["colScore"].Style.ForeColor = client.Score >= 7 ? Color.Green :
                                                                         client.Score >= 4 ? Color.Orange :
                                                                         Color.Red;
                            }
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

        private void dgvClients_CellClick(object sender, DataGridViewCellEventArgs e) { }

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
                MessageBox.Show($"Client '{selected.Name}' updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            SetupUI();
            RefreshAll();
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

        private void btnRefresh_Click(object sender, EventArgs e) => RefreshAll();

        private void btnTestSave_Click(object sender, EventArgs e)
        {
            DataManager.SaveData(_clients);
            string path = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "ClientFlowCRM", "clients.json");

            bool exists = File.Exists(path);
            string fileContent = exists ? File.ReadAllText(path) : "FILE NOT FOUND";

            MessageBox.Show(
                $"Path: {path}\nExists: {exists}\nClients in memory: {_clients.Count}\n\nFirst 500 chars:\n{fileContent.Substring(0, Math.Min(500, fileContent.Length))}",
                "Save Debug");
        }

        private void lstPriority_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            string item = lstPriority.Items[e.Index].ToString();

            Color backColor = Color.White;
            if (item.Contains("Warm"))
                backColor = Color.FromArgb(255, 243, 205);
            else if (item.Contains("Hot"))
                backColor = Color.FromArgb(255, 204, 204);
            else if (item.Contains("Cold"))
                backColor = Color.FromArgb(204, 229, 255);

            e.Graphics.FillRectangle(new SolidBrush(backColor), e.Bounds);

            RectangleF paddedBounds = new RectangleF(
                e.Bounds.X + 6, e.Bounds.Y + 2,
                e.Bounds.Width - 6, e.Bounds.Height);

            using (Font emojiFont = new Font("Segoe UI Emoji", e.Font.Size))
            {
                e.Graphics.DrawString(item, emojiFont, Brushes.Black, paddedBounds);
            }

            e.DrawFocusRectangle();
        }

        private void lblTotalClients_Click(object sender, EventArgs e) { }
        private void lblTotalClientsSub_Click(object sender, EventArgs e) { }
        private void lblActiveDealsSub_Click(object sender, EventArgs e) { }
        private void lblPendingSub_Click(object sender, EventArgs e) { }
        private void lblPending_Click(object sender, EventArgs e) { }
        private void lblForecastedSub_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void lblActiveDeals_Click(object sender, EventArgs e) { }
        private void groupBox4_Enter(object sender, EventArgs e) { }
        private void lblForecasted_Click(object sender, EventArgs e) { }
        private void lstPriority_SelectedIndexChanged(object sender, EventArgs e) { }
        private void groupBox2_Enter(object sender, EventArgs e) { }
        private void lblAtRiskCount_Click(object sender, EventArgs e) { }
        private void groupBox5_Enter(object sender, EventArgs e) { }
        private void dgvClients_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void groupBox3_Enter(object sender, EventArgs e) { }
        private void panel3_Paint(object sender, PaintEventArgs e) { }

    }  
}      
