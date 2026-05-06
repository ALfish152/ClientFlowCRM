using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ClientFlowCRM.Models;

namespace ClientFlowCRM
{
    public partial class ClientDetailForm : Form
    {
        private Client _client;
        private List<Client> _allClients;
        private int _nextDealId;
        private int _nextInteractionId;

        public ClientDetailForm(Client client, List<Client> allClients,
            int nextDealId, int nextInteractionId)
        {
            InitializeComponent();
            _client = client;
            _allClients = allClients;
            _nextDealId = nextDealId;
            _nextInteractionId = nextInteractionId;

            this.Shown += ClientDetailForm_Shown;
            LoadData();
        }

        private void ClientDetailForm_Shown(object sender, EventArgs e)
        {
            ClearAllSelections();
        }

        private void ClearAllSelections()
        {
            dgvDeals.ClearSelection();
            dgvDeals.CurrentCell = null;
            dgvInteractions.ClearSelection();
            dgvInteractions.CurrentCell = null;
        }

        private void LoadData()
        {
            lblHeader.Text = _client.Name;
            lblSubInfo.Text = $"Score: {_client.Score:F1}   |   Source: {_client.Source}";

            lblTempBadge.Text = _client.Temperature;
            switch (_client.Temperature)
            {
                case "Hot":
                    lblTempBadge.BackColor = Color.FromArgb(220, 38, 38);
                    break;
                case "Warm":
                    lblTempBadge.BackColor = Color.FromArgb(217, 119, 6);
                    break;
                default:
                    lblTempBadge.BackColor = Color.FromArgb(96, 165, 250);
                    break;
            }

            lblEmail.Text = $"📧  {(_client.Email ?? "—")}";
            lblPhone.Text = $"📞  {(_client.Phone ?? "—")}";
            lblCompany.Text = $"🏢  {(_client.Company ?? "—")}";
            lblSource.Text = $"🔗  {(_client.Source ?? "—")}";

            this.Text = $"Client Details — {_client.Name}";

            dgvDeals.DataSource = null;
            dgvDeals.DataSource = _client.Deals;

            dgvInteractions.DataSource = null;
            dgvInteractions.DataSource = _client.Interactions;

            ClearAllSelections();
        }

        private void panelClientInfo_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            var rect = new Rectangle(1, 1, panelClientInfo.Width - 2, panelClientInfo.Height - 2);
            using (var path = RoundedPath(rect, 12))
            using (var brush = new SolidBrush(Color.White))
                g.FillPath(brush, path);
            using (var path = RoundedPath(rect, 12))
            using (var pen = new Pen(Color.FromArgb(220, 223, 228), 1f))
                g.DrawPath(pen, path);
        }

        private GraphicsPath RoundedPath(Rectangle rect, int radius)
        {
            int d = radius * 2;
            var path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseAllFigures();
            return path;
        }

        // ── DEALS ────────────────────────────────────────────

        private void btnAddDeal_Click(object sender, EventArgs e)
        {
            var form = new DealForm(_client.Name);
            if (form.ShowDialog() == DialogResult.OK)
            {
                form.DealData.Id = _nextDealId++;
                form.DealData.ClientId = _client.Id;
                form.DealData.CreatedDate = DateTime.Now;
                form.DealData.UpdateCalculatedFields();
                _client.Deals.Add(form.DealData);
                _client.UpdateCalculatedFields();
                LoadData();
            }
        }

        private void btnEditDeal_Click(object sender, EventArgs e)
        {
            if (dgvDeals.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a deal to edit.", "Info");
                return;
            }

            Deal selected = (Deal)dgvDeals.SelectedRows[0].DataBoundItem;
            var form = new DealForm(selected, _client.Name);

            if (form.ShowDialog() == DialogResult.OK)
            {
                selected.Title = form.DealData.Title;
                selected.Value = form.DealData.Value;
                selected.Stage = form.DealData.Stage;
                selected.UpdateCalculatedFields();
                _client.UpdateCalculatedFields();
                LoadData();
            }
        }

        private void btnDeleteDeal_Click(object sender, EventArgs e)
        {
            if (dgvDeals.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a deal to delete.", "Info");
                return;
            }

            Deal selected = (Deal)dgvDeals.SelectedRows[0].DataBoundItem;

            if (MessageBox.Show($"Delete deal '{selected.Title}'?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _client.Deals.Remove(selected);
                _client.UpdateCalculatedFields();
                LoadData();
            }
            else
            {
                ClearAllSelections();
            }
        }

        // ── INTERACTIONS ─────────────────────────────────────

        private void btnAddInteraction_Click(object sender, EventArgs e)
        {
            var form = new InteractionForm(_client.Name);
            if (form.ShowDialog() == DialogResult.OK)
            {
                form.InteractionData.Id = _nextInteractionId++;
                form.InteractionData.ClientId = _client.Id;
                _client.Interactions.Add(form.InteractionData);
                _client.UpdateCalculatedFields();
                LoadData();
            }
        }

        private void btnEditInteraction_Click(object sender, EventArgs e)
        {
            if (dgvInteractions.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select an interaction to edit.", "Info");
                return;
            }

            Interaction selected = (Interaction)dgvInteractions.SelectedRows[0].DataBoundItem;
            var form = new InteractionForm(selected, _client.Name);

            if (form.ShowDialog() == DialogResult.OK)
            {
                selected.Notes = form.InteractionData.Notes;

                if (selected is Call call && form.InteractionData is Call newCall)
                {
                    call.Duration = newCall.Duration;
                    call.Outcome = newCall.Outcome;
                }
                else if (selected is Email email && form.InteractionData is Email newEmail)
                {
                    email.Subject = newEmail.Subject;
                }
                else if (selected is Meeting meeting && form.InteractionData is Meeting newMeeting)
                {
                    meeting.Location = newMeeting.Location;
                    meeting.Attendees = newMeeting.Attendees;
                }

                _client.UpdateCalculatedFields();
                LoadData();
            }
            else
            {
                ClearAllSelections();
            }
        }

        private void btnDeleteInteraction_Click(object sender, EventArgs e)
        {
            if (dgvInteractions.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select an interaction to delete.", "Info");
                return;
            }

            Interaction selected = (Interaction)dgvInteractions.SelectedRows[0].DataBoundItem;

            if (MessageBox.Show("Delete this interaction?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _client.Interactions.Remove(selected);
                _client.UpdateCalculatedFields();
                LoadData();
            }
            else
            {
                ClearAllSelections();
            }
        }

        // ── CLIENT ───────────────────────────────────────────

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var form = new ClientForm(_client);
            if (form.ShowDialog() == DialogResult.OK)
            {
                _client.Name = form.ClientData.Name;
                _client.Email = form.ClientData.Email;
                _client.Phone = form.ClientData.Phone;
                _client.Company = form.ClientData.Company;
                _client.Source = form.ClientData.Source;
                LoadData();
            }
        }

        private void btnBack_Click(object sender, EventArgs e) => Close();

        // ── EMPTY HANDLERS ───────────────────────────────────

        private void lblHeader_Click(object sender, EventArgs e) { }
        private void dgvDeals_CellClick(object sender, DataGridViewCellEventArgs e) { dgvDeals.CurrentCell = null; }
        private void dgvInteractions_CellClick(object sender, DataGridViewCellEventArgs e) { dgvInteractions.CurrentCell = null; }
        private void dgvInteractions_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
    }
}