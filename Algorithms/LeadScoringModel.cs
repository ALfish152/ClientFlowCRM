using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClientFlowCRM.Models;

namespace ClientFlowCRM.Algorithms
{
    public class LeadScoringModel
    {
        public double CalculateScore(Client client)
        {
            double engagement = Math.Min(client.InteractionCount, 10);

            double recency = 1;
            if (client.LastContactDate.HasValue)
            {
                var days = (DateTime.Now - client.LastContactDate.Value).TotalDays;
                if (days <= 3) recency = 10;
                else if (days <= 7) recency = 7;
                else if (days <= 14) recency = 5;
                else if (days <= 30) recency = 3;
            }

            double value = 1;
            if (client.TotalDealValue >= 50000) value = 10;
            else if (client.TotalDealValue >= 25000) value = 7;
            else if (client.TotalDealValue >= 10000) value = 5;
            else if (client.TotalDealValue >= 5000) value = 3;

            double source = 5;
            if (client.Source.Contains("Referral")) source = 10;
            else if (client.Source.Contains("Social")) source = 7;
            else if (client.Source.Contains("Cold")) source = 3;

            return Math.Round(
                (engagement * 0.30) + (recency * 0.40) + (value * 0.20) + (source * 0.10), 2);
        }

        public string GetTemperature(double score)
        {
            if (score >= 7.5) return "Hot";
            if (score >= 5.0) return "Warm";
            return "Cold";
        }
    }
}
