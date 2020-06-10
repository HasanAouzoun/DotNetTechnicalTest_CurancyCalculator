using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace DotNetTechnicalTest_CurancyCalculator.DataModel
{
    public class BaseCurrencyCode
    {
        public static List<SelectListItem> GetCurrencyCodeList { get; } = new List<SelectListItem>
        {
            new SelectListItem("EUR", "EUR", true),
            new SelectListItem("USD", "USD"),
            new SelectListItem("GBP", "GBP"),
        };
    }
}
