using OandaV20.Models.PricingModel;

namespace OandaV20.Models.InstrumentsModel
{
    public class CandlestickData
    {
        public PriceValue O;
        public PriceValue H;
        public PriceValue L;
        public PriceValue C;

        public CandlestickData()
        {
            this.O = new PriceValue();
            this.H = new PriceValue();
            this.L = new PriceValue();
            this.C = new PriceValue();
        }
        public CandlestickData(PriceValue o, PriceValue h, PriceValue l, PriceValue c)
        {
            this.O = o;
            this.H = h;
            this.L = l;
            this.C = c;
        }
    }
}
