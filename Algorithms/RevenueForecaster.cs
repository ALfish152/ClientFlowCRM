using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClientFlowCRM.Models;

namespace ClientFlowCRM.Algorithms
{
    public class RevenueForecaster
    {
        public decimal Calculate(List<Deal> deals)
        {
            return deals
                .Where(d => d.Stage != "Lost" && d.Stage != "Won")
                .Sum(d => d.Value * (decimal)d.WinProbability);
        }
    }
}