using System;
using System.Collections.Generic;

namespace ClientFlowCRM.Models
{
    public class Client
    {
        private string _name;
        private string _email;
        private string _phone;
        private string _company;
        private string _source;

        public int Id { get; set; }

        public string Name
        {
            get => _name;
            set => _name = string.IsNullOrWhiteSpace(value) ? "Unknown" : value.Trim();
        }

        public string Email
        {
            get => _email;
            set => _email = value ?? "";
        }

        public string Phone
        {
            get => _phone;
            set => _phone = value ?? "";
        }

        public string Company
        {
            get => _company;
            set => _company = value ?? "";
        }

        public string Source
        {
            get => _source;
            set => _source = value ?? "Website";
        }

        public List<Deal> Deals { get; set; } = new List<Deal>();
        public List<Interaction> Interactions { get; set; } = new List<Interaction>();
        public double Score { get; set; }
        public string Temperature { get; set; } = "Cold";

        public decimal TotalDealValue { get; set; }
        public int InteractionCount { get; set; }
        public DateTime? LastContactDate { get; set; }
        public bool IsAtRisk { get; set; }

        public Client()
        {
            _name = "";
            _email = "";
            _phone = "";
            _company = "";
            _source = "Website";
            TotalDealValue = 0;
            InteractionCount = 0;
            LastContactDate = null;
            IsAtRisk = true;
        }

        public void UpdateCalculatedFields()
        {
            decimal total = 0;
            foreach (var deal in Deals)
            {
                if (deal.Stage != "Lost")
                    total += deal.Value;
            }
            TotalDealValue = total;

            InteractionCount = Interactions.Count;

            if (Interactions.Count == 0)
            {
                LastContactDate = null;
            }
            else
            {
                DateTime latest = Interactions[0].Timestamp;
                foreach (var i in Interactions)
                    if (i.Timestamp > latest) latest = i.Timestamp;
                LastContactDate = latest;
            }

            if (!LastContactDate.HasValue)
                IsAtRisk = true;
            else
                IsAtRisk = (DateTime.Now - LastContactDate.Value).TotalDays > 14;
        }
    }
}