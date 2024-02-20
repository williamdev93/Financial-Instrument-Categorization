using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialInstruments
{
    public class InstrumentManager
    {
        private readonly IInstrumentCategorizer _categorizer;

        public InstrumentManager(IInstrumentCategorizer categorizer)
        {
            _categorizer = categorizer;
        }

        public List<ValueCategory> CategorizeInstruments(IEnumerable<IFinancialInstrument> instruments)
        {
            var categories = new List<ValueCategory>();

            foreach (var instrument in instruments)
            {
                var category = _categorizer.Categorize(instrument);
                categories.Add(category);
            }

            return categories;
        }
    }
}
