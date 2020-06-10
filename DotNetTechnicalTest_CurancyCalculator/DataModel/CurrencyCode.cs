using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace DotNetTechnicalTest_CurancyCalculator.DataModel
{
    public class CurrencyCode
    {
        public static List<SelectListItem> GetCurrencyCodeList { get; } = new List<SelectListItem>
        {
            new SelectListItem("GBP", "GBP", true),
            new SelectListItem("AED", "AED"),
            new SelectListItem("ARS", "ARS"),
            new SelectListItem("AUD", "AUD"),
            new SelectListItem("BGN", "BGN"),
            new SelectListItem("BRL", "BRL"),
            new SelectListItem("BSD", "BSD"),
            new SelectListItem("CAD", "CAD"),
            new SelectListItem("CHF", "CHF"),
            new SelectListItem("CLP", "CLP"),
            new SelectListItem("CNY", "CNY"),
            new SelectListItem("COP", "COP"),
            new SelectListItem("CZK", "CZK"),
            new SelectListItem("DKK", "DKK"),
            new SelectListItem("DOP", "DOP"),
            new SelectListItem("EGP", "EGP"),
            new SelectListItem("EUR", "EUR"),
            new SelectListItem("FJD", "FJD"),
            new SelectListItem("GTQ", "GTQ"),
            new SelectListItem("HKD", "HKD"),
            new SelectListItem("HRK", "HRK"),
            new SelectListItem("HUF", "HUF"),
            new SelectListItem("IDR", "IDR"),
            new SelectListItem("ILS", "ILS"),
            new SelectListItem("INR", "INR"),
            new SelectListItem("ISK", "ISK"),
            new SelectListItem("JPY", "JPY"),
            new SelectListItem("KRW", "KRW"),
            new SelectListItem("KZT", "KZT"),
            new SelectListItem("MXN", "MXN"),
            new SelectListItem("MYR", "MYR"),
            new SelectListItem("NOK", "NOK"),
            new SelectListItem("NZD", "NZD"),
            new SelectListItem("PAB", "PAB"),
            new SelectListItem("PEN", "PEN"),
            new SelectListItem("PHP", "PHP"),
            new SelectListItem("PKR", "PKR"),
            new SelectListItem("PLN", "PLN"),
            new SelectListItem("PYG", "PYG"),
            new SelectListItem("RON", "RON"),
            new SelectListItem("RUB", "RUB"),
            new SelectListItem("SAR", "SAR"),
            new SelectListItem("SEK", "SEK"),
            new SelectListItem("SGD", "SGD"),
            new SelectListItem("THB", "THB"),
            new SelectListItem("TRY", "TRY"),
            new SelectListItem("TWD", "TWD"),
            new SelectListItem("UAH", "UAH"),
            new SelectListItem("USD", "USD"),
            new SelectListItem("UYU", "UYU"),
            new SelectListItem("ZAR", "ZAR"),
        };
    }
}
