using System;
using System.Collections.Generic;

namespace OandaV20.Models.PricingModel
{
    public class ClientPrice
    {
        public List<PriceBucket> Bids;
        public List<PriceBucket> Asks;
        public PriceValue CloseoutBid;
        public PriceValue CloseoutAsk;
        public DateTime Timestamp;

        public ClientPrice()
        {
            this.Bids = new List<PriceBucket>();
            this.Asks = new List<PriceBucket>();
            this.CloseoutBid = new PriceValue();
            this.CloseoutAsk = new PriceValue();
            this.Timestamp = new DateTime();
        }
        public ClientPrice(
            List<PriceBucket> bids, 
            List<PriceBucket> asks, 
            PriceValue closeoutBid, 
            PriceValue closeoutAsk, 
            DateTime timestamp)
        {
            this.Bids = bids;
            this.Asks = asks;
            this.CloseoutBid = closeoutBid;
            this.CloseoutAsk = closeoutAsk;
            this.Timestamp = timestamp;
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

        // Getters
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