using Newtonsoft.Json;
using OandaV20.Models.OrderModel.Definitions;
using OandaV20.Models.OrderModel.Requests;
using OandaV20.Models.PricingModel;
using OandaV20.Models.Primitives;
using System;

namespace OandaV20.Models.TransactionModel.Definitions
{
    public class StopLossDetails
    {
        [JsonConverter(typeof(ParseAsStringConverter))]
        public PriceValue Price;
        public double Distance;
        [JsonConverter(typeof(ParseAsStringConverter))]
        public TimeInForce TimeInForce;
        public DateTime GTDTime;
        public ClientExtensions ClientExtensions;
        public bool Guaranteed;

        public StopLossDetails()
        {
            this.TimeInForce = ETimeInForce.GTC.ToString();
            this.GTDTime = new DateTime();
            this.ClientExtensions = new ClientExtensions();
        }
        public StopLossDetails(
            PriceValue price, 
            double distance, 
            ETimeInForce timeInForce, 
            DateTime gtdTime, 
            ClientExtensions clientExtensions, 
            bool guaranteed)
        {
            this.Price = price;
            this.Distance = distance;
            this.TimeInForce = timeInForce.ToString();
            this.GTDTime = gtdTime;
            this.ClientExtensions = clientExtensions;
            this.Guaranteed = guaranteed;
        }
    }
}