using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClientFlowCRM.Models;

namespace ClientFlowCRM.Algorithms
{
    public class FollowUpQueue
    {
        public List<Client> GetTopFive(List<Client> clients)
        {
            return clients
                .Where(c => c.Deals.Any(d => d.Stage != "Lost" && d.Stage != "Won"))
                .OrderByDescending(c => c.Temperature == "Hot" ? 3 : (c.Temperature == "Warm" ? 2 : 1))
                .ThenBy(c => c.LastContactDate ?? System.DateTime.MinValue)
                .ThenByDescending(c => c.TotalDealValue)
                .Take(5)
                .ToList();
        }
    }
}
