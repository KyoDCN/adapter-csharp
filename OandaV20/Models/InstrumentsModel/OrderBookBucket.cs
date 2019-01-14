using OandaV20.Models.PricingModel;

namespace OandaV20.Models.InstrumentsModel
{
    public class OrderBookBucket
    {
        public PriceValue Price;
        public double LongCountPercent;
        public double ShortCountPercent;

        public OrderBookBucket()
        {
            this.Price = new PriceValue();
        }
        public OrderBookBucket(PriceValue price, double longCountPercent, double shortCountPercent)
        {
            this.Price = price;
            this.LongCountPercent = longCountPercent;
            this.ShortCountPercent = shortCountPercent;
        }
    }
}
