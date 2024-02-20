using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialInstruments
{
    public interface IInstrumentCategorizer
    {
        ValueCategory Categorize(IFinancialInstrument instrument);
    }
}
