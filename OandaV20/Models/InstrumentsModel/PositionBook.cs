using OandaV20.Models.PricingModel;
using OandaV20.Models.Primitives;
using System;
using System.Collections.Generic;

namespace OandaV20.Models.InstrumentsModel
{
    public class PositionBook
    {
        public InstrumentName Instrument;
        public DateTime Time;
        public PriceValue Price;
        public PriceValue BucketWidth;
        public List<PositionBookBucket> Buckets;

        public PositionBook()
        {
            this.Instrument = new InstrumentName();
            this.Time = new DateTime();
            this.Price = new PriceValue();
            this.BucketWidth = new PriceValue();
            this.Buckets = new List<PositionBookBucket>();
        }
        public PositionBook(InstrumentName instrument, DateTime time, PriceValue price, PriceValue bucketWidth, List<PositionBookBucket> buckets)
        {
            this.Instrument = instrument;
            this.Time = time;
            this.Price = price;
            this.BucketWidth = bucketWidth;
            this.Buckets = buckets;
        }
    }
}
