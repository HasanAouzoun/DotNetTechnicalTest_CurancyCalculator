using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DotNetTechnicalTest_CurancyCalculator.Models;
using DotNetTechnicalTest_CurancyCalculator.DataModel;
using DotNetTechnicalTest_CurancyCalculator.Services;

namespace DotNetTechnicalTest_CurancyCalculator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICurrencyService _currencyService;

        public HomeController(ICurrencyService currencyService)
        {
            _currencyService = currencyService;
        }

        public double _result { get; set; }

        public IActionResult Index()
        {
            // Set dropdown lists
            ViewBag.currencyCodeList = CurrencyCode.GetCurrencyCodeList;
            ViewBag.baseCurrencyCodeList = BaseCurrencyCode.GetCurrencyCodeList;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(CalculateRequest req)
        {
            // Convert
            var result = await _currencyService.CalculateRate(req.FromValue, req.FromCurrencyCode, req.ToCurrnecyCode);

            // Format the Result
            ViewData["result"] = $"{req.FromValue} {req.FromCurrencyCode} = {result} {req.ToCurrnecyCode}";

            return Index();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
