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

        public async Task<ExchangeRateData> GetExchangeRateData(string baseCurrencyCode)
        {
            return await _exchangeRateApi.GetExchagneRates(baseCurrencyCode);
        }

        public async Task<double> CalculateRate(double value, string fromCurrency, string toCurrency)
        {
            // Get all rate values from API
            var exchangeRates = await GetExchangeRateData(toCurrency);

            // Get "FromCurrency" rate
            var rate = exchangeRates.Rates[fromCurrency];

            // Calculate and return
            return value * rate;
        }
    }
}
