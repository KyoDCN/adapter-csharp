using OandaV20.Models.Primitives;
using System;
using System.Collections.Generic;

namespace OandaV20.Models.PricingModel
{
    public class Price
    {
        public string Type;
        public InstrumentName Instrument;
        public DateTime Time;
        // public PriceStatus Status; {Deprecated}
        public bool Tradeable;
        public List<PriceBucket> Bids;
        public List<PriceBucket> Asks;
        public PriceValue CloseoutBid;
        public PriceValue CloseoutAsk;
        // private QuoteHomeConversionFactors QuoteHomeConversionFactors; {Deprecated}
        // private UnitsAvailable UnitsAvailable; {Deprecated}

        public Price()
        {
            this.Type = "PRICE";
            this.Instrument = new InstrumentName();
            this.Time = new DateTime();
            this.Bids = new List<PriceBucket>();
            this.Asks = new List<PriceBucket>();
            this.CloseoutBid = new PriceValue();
            this.CloseoutAsk = new PriceValue();
        }

        public Price(
            string type,
            InstrumentName instrument,
            DateTime time,
            bool tradeable,
            List<PriceBucket> bids,
            List<PriceBucket> asks,
            PriceValue closeoutBid,
            PriceValue closeoutAsk)
        {
            if (type == null)
            {
                this.Type = "PRICE";
            } else
            {
                this.Type = type;
            }            
            
            this.Instrument = instrument;
            this.Time = time;
            this.Tradeable = tradeable;
            this.Bids = bids;
            this.Asks = asks;
            this.CloseoutBid = closeoutBid;
            this.CloseoutAsk = closeoutAsk;
        }

        public void RemoveBid(PriceValue value)
        {
            PriceBucket x = FindBid(value);
            this.Bids.Remove(x);
        }
        public void RemoveAsk(PriceValue value)
        {
            PriceBucket x = FindAsk(value);
            this.Asks.Remove(x);
        }
        public PriceBucket FindBid(PriceValue value)
        {
            return this.Bids.Find(x => x.Price == value);
        }
        public PriceBucket FindAsk(PriceValue value)
        {
            return this.Asks.Find(x => x.Price == value);
        }
    }
}