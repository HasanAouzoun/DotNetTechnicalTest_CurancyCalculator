using System.Collections.Generic;

namespace DotNetTechnicalTest_CurancyCalculator.DataModel
{
    public class ExchangeRateData
    {
        public string Base { get; set; }
        public string Date { get; set; }
        public int TimeLastUpdated { get; set; }
        public Dictionary<string, double> Rates { get; set; }
    }
}
