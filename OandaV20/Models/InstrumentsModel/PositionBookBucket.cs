using OandaV20.Models.PricingModel;

namespace OandaV20.Models.InstrumentsModel
{
    public class PositionBookBucket
    {
        public PriceValue Price;
        public double LongCountPercent;
        public double ShortCountPercent;

        public PositionBookBucket()
        {
            this.Price = new PriceValue();
        }
        public PositionBookBucket(PriceValue price, double longCountPercent, double shortCountPercent)
        {
            this.Price = price;
            this.LongCountPercent = longCountPercent;
            this.ShortCountPercent = shortCountPercent;
        }
    }
}
