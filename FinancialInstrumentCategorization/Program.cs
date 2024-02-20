namespace FinancialInstruments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var instruments = new List<IFinancialInstrument>
            {
                new FinancialInstrument(800000, "Stock"),
                new FinancialInstrument(1500000, "Bond"),
                new FinancialInstrument(6000000, "Derivative"),
                new FinancialInstrument(300000, "Stock")
            };

            var manager = new InstrumentManager(new DefaultInstrumentCategorizer());
            var categories = manager.CategorizeInstruments(instruments);

            Console.WriteLine("Instrument Categories:");
            for (int i = 0; i < instruments.Count; i++)
            {
                Console.WriteLine($"{instruments[i].Type}: {categories[i]} Value");
            }
        }
    }
}