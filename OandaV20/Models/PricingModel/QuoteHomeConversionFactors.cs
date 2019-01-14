using OandaV20.Models.Primitives;

namespace OandaV20.Models.PricingModel
{
    public class QuoteHomeConversionFactors
    {
        public double PositiveUnits;
        public double NegativeUnits;

        public QuoteHomeConversionFactors()
        {
        }
        public QuoteHomeConversionFactors(double positive, double negative)
        {
            this.PositiveUnits = positive;
            this.NegativeUnits = negative;
        }
    }
}
