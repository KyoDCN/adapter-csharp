namespace OandaV20.Models.PricingModel
{
    public class PriceBucket
    {
        public PriceValue Price;
        public int Liquidity;

        public PriceBucket()
        {
            this.Price = new PriceValue();
        }
        public PriceBucket(PriceValue price, int liquidity)
        {
            this.Price = price;
            this.Liquidity = liquidity;
        }
    }
}
