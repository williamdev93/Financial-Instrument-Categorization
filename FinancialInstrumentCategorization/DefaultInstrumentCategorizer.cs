using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialInstruments
{
    public class DefaultInstrumentCategorizer : IInstrumentCategorizer
    {
        public ValueCategory Categorize(IFinancialInstrument instrument)
        {
            if (instrument.MarketValue < 1000000)
                return ValueCategory.Low;
            else if (instrument.MarketValue >= 1000000 && instrument.MarketValue <= 5000000)
                return ValueCategory.Medium;
            else
                return ValueCategory.High;
        }
    }
}
