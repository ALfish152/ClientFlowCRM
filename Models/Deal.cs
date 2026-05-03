using System;

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
        public double WinProbability { get; set; } 
        public bool IsActive { get; set; } 

        public Deal()
        {
            Title = "";
            Stage = "Lead";
            CreatedDate = DateTime.Now;
            UpdateCalculatedFields();
        }

        public void UpdateCalculatedFields()
        {
            switch (Stage)
            {
                case "Lead": WinProbability = 0.10; break;
                case "Contacted": WinProbability = 0.25; break;
                case "Quoted": WinProbability = 0.50; break;
                case "Negotiation": WinProbability = 0.75; break;
                case "Won": WinProbability = 1.00; break;
                case "Lost": WinProbability = 0.00; break;
                default: WinProbability = 0.10; break;
            }
            IsActive = Stage != "Won" && Stage != "Lost";
        }
    }
}