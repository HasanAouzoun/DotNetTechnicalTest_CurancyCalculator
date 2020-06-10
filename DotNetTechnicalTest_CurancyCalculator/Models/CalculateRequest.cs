namespace DotNetTechnicalTest_CurancyCalculator.Models
{
    public class CalculateRequest
    {
        public double FromValue { get; set; }
        public string FromCurrencyCode { get; set; }
        public string ToCurrnecyCode { get; set; }
    }
}
