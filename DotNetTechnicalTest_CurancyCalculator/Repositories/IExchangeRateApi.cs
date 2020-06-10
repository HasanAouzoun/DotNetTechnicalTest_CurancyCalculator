using System.Threading.Tasks;
using DotNetTechnicalTest_CurancyCalculator.DataModel;

namespace DotNetTechnicalTest_CurancyCalculator.Repositories
{
    public interface IExchangeRateApi
    {
        Task<ExchangeRateData> GetExchagneRates(string baseCurrencyCode);
    }
}
