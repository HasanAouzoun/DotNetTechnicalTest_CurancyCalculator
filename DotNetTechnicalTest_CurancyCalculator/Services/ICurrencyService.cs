using DotNetTechnicalTest_CurancyCalculator.DataModel;
using System.Threading.Tasks;

namespace DotNetTechnicalTest_CurancyCalculator.Services
{
    public interface ICurrencyService
    {
        Task<double> CalculateRate(double value, string fromCurrency, string toCurrency);
    }
}
