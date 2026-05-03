using System;
using System.Collections.Generic;
using System.Linq;
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
            LoadData();
        }

        private void LoadData()
        {
            lblHeader.Text = $"{_client.Name} - {_client.Temperature} (Score: {_client.Score})";
            dgvDeals.DataSource = null;
            dgvDeals.DataSource = _client.Deals;
            dgvInteractions.DataSource = null;
            dgvInteractions.DataSource = _client.Interactions;
        }

        // DEAL BUTTONS

        private void btnAddDeal_Click(object sender, EventArgs e)
        {
            var form = new DealForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                form.DealData.Id = _nextDealId++;
                form.DealData.ClientId = _client.Id;
                form.DealData.CreatedDate = DateTime.Now;
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
            var form = new DealForm(selected);

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
        }

        // INTERACTION BUTTONS 

        private void btnAddInteraction_Click(object sender, EventArgs e)
        {
            var form = new InteractionForm();
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
            var form = new InteractionForm(selected);

            if (form.ShowDialog() == DialogResult.OK)
            {
                selected.Timestamp = DateTime.Now;
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
        }

        // NAVIGATION 

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

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}