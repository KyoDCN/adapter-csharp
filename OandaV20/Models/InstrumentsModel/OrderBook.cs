using OandaV20.Models.PricingModel;
using OandaV20.Models.Primitives;
using System;
using System.Collections.Generic;

namespace OandaV20.Models.InstrumentsModel
{
    public class OrderBook
    {
        public InstrumentName Instrument;
        public DateTime Time;
        public PriceValue Price;
        public PriceValue BucketWidth;
        public List<OrderBookBucket> Buckets;

        public OrderBook()
        {
            this.Instrument = new InstrumentName();
            this.Time = new DateTime();
            this.Price = new PriceValue();
            this.BucketWidth = new PriceValue();
            this.Buckets = new List<OrderBookBucket>();
        }
        public OrderBook(InstrumentName instrument, DateTime time, PriceValue price, PriceValue bucketWidth, List<OrderBookBucket> buckets)
        {
            this.Instrument = instrument;
            this.Time = time;
            this.Price = price;
            this.BucketWidth = bucketWidth;
            this.Buckets = buckets;
        }
    }
}
