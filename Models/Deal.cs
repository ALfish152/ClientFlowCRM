using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientFlowCRM.Models
{
    public class Deal
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string Title { get; set; }
        public decimal Value { get; set; }
        public string Stage { get; set; }
        public DateTime CreatedDate { get; set; }

        public double WinProbability
        {
            get
            {
                switch (Stage)
                {
                    case "Lead": return 0.10;
                    case "Contacted": return 0.25;
                    case "Quoted": return 0.50;
                    case "Negotiation": return 0.75;
                    case "Won": return 1.00;
                    case "Lost": return 0.00;
                    default: return 0.10;
                }
            }
        }

        public bool IsActive => Stage != "Won" && Stage != "Lost";

        public Deal()
        {
            Title = "";
            Stage = "Lead";
            CreatedDate = DateTime.Now;
        }
    }
}