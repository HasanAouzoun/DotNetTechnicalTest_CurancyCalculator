using DotNetTechnicalTest_CurancyCalculator.DataModel;
using System.Threading.Tasks;
using DotNetTechnicalTest_CurancyCalculator.Repositories;

namespace DotNetTechnicalTest_CurancyCalculator.Services
{
    public class CurrencyService : ICurrencyService
    {

        private readonly IExchangeRateApi _exchangeRateApi;

        public CurrencyService(IExchangeRateApi exchangeRateApi)
        {
            _exchangeRateApi = exchangeRateApi;
        }

        public async Task<double> CalculateRate(double value, string fromCurrency, string toCurrency)
        {
            // Get all rate values from API
            ExchangeRateData exchangeRates = await _exchangeRateApi.GetExchagneRates(toCurrency);

            // Get "FromCurrency" rate
            var rate = exchangeRates.Rates[fromCurrency];

            // Calculate and return
            return value * rate;
        }
    }
}
