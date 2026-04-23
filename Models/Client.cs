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
    }
}