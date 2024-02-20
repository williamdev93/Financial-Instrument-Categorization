using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialInstruments
{
    public class FinancialInstrument : IFinancialInstrument
    {
        public double MarketValue { get; }
        public string Type { get; }

        public FinancialInstrument(double marketValue, string type)
        {
            MarketValue = marketValue;
            Type = type;
        }
    }
}
