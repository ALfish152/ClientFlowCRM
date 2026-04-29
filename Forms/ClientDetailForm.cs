using ClientFlowCRM.Data;
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

        private void btnAddDeal_Click(object sender, EventArgs e)
        {
            var form = new DealForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                form.DealData.Id = _nextDealId++;
                form.DealData.ClientId = _client.Id;
                _client.Deals.Add(form.DealData);
                LoadData();
            }
        }

        private void btnAddInteraction_Click(object sender, EventArgs e)
        {
            var form = new InteractionForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                form.InteractionData.Id = _nextInteractionId++;
                form.InteractionData.ClientId = _client.Id;
                _client.Interactions.Add(form.InteractionData);
                LoadData();
            }
        }

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