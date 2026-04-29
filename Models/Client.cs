using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientFlowCRM.Models
{
    public class Client
    {
        private string _name;
        private string _email;
        private string _phone;
        private string _company;
        private string _source;

        public List<Deal> Deals { get; set; } = new List<Deal>();
        public List<Interaction> Interactions { get; set; } = new List<Interaction>();
        public double Score { get; set; }
        public string Temperature { get; set; } = "Cold";

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

        public Client()
        {
            _name = "";
            _email = "";
            _phone = "";
            _company = "";
            _source = "Website";
        }

        public decimal TotalDealValue
        {
            get
            {
                decimal total = 0;
                foreach (var deal in Deals)
                {
                    if (deal.Stage != "Lost")
                        total += deal.Value;
                }
                return total;
            }
        }

        public int InteractionCount => Interactions.Count;

        public DateTime? LastContactDate
        {
            get
            {
                if (Interactions.Count == 0) return null;
                DateTime latest = Interactions[0].Timestamp;
                foreach (var i in Interactions)
                    if (i.Timestamp > latest) latest = i.Timestamp;
                return latest;
            }
        }

        public bool IsAtRisk
        {
            get
            {
                if (!LastContactDate.HasValue) return true;
                return (DateTime.Now - LastContactDate.Value).TotalDays > 14;
            }
        }
    }
}