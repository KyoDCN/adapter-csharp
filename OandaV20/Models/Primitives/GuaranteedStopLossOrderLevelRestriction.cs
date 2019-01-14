namespace OandaV20.Models.Primitives
{
    public class GuaranteedStopLossOrderLevelRestriction
    {
        double Volume;
        public double PriceRange;

        // CONSTRUCTORS
        public GuaranteedStopLossOrderLevelRestriction()
        {
        }
        public GuaranteedStopLossOrderLevelRestriction(double volume, double priceRange)
        {
            this.Volume = volume;
            this.PriceRange = priceRange;
        }
    }
}
