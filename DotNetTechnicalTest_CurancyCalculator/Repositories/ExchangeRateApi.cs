using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.Extensions.Configuration;
using DotNetTechnicalTest_CurancyCalculator.DataModel;
using Newtonsoft.Json;

namespace DotNetTechnicalTest_CurancyCalculator.Repositories
{
    public class ExchangeRateApi: IExchangeRateApi
    {
        private readonly string _apiUrl;

        public ExchangeRateApi(IConfiguration conf)
        {
            _apiUrl = conf["ExchangeRateApiUrl"];
        }

        public async Task<ExchangeRateData> GetExchagneRates(string baseCurrencyCode)
        {
            var client = new HttpClient();
            var request = await client.GetAsync($"{_apiUrl}{baseCurrencyCode}");

            var jsonResult = request.Content.ReadAsStringAsync().Result;
            var exchangeRateData = JsonConvert.DeserializeObject<ExchangeRateData>(jsonResult);

            return exchangeRateData;
        }
    }
}
