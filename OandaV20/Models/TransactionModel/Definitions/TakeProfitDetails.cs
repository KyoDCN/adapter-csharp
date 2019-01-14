using Newtonsoft.Json;
using OandaV20.Models.OrderModel.Definitions;
using OandaV20.Models.OrderModel.Requests;
using OandaV20.Models.PricingModel;
using System;

namespace OandaV20.Models.TransactionModel.Definitions
{
    public class TakeProfitDetails
    {
        [JsonConverter(typeof(ParseAsStringConverter))]
        public PriceValue Price;
        [JsonConverter(typeof(ParseAsStringConverter))]
        public TimeInForce TimeInForce;
        public DateTime GTDTime;
        public ClientExtensions ClientExtensions;

        public TakeProfitDetails()
        {
            this.TimeInForce = ETimeInForce.GTC.ToString();
            this.GTDTime = new DateTime();
            this.ClientExtensions = new ClientExtensions();
        }
        public TakeProfitDetails(PriceValue priceValue, ETimeInForce timeInForce, DateTime dateTime, ClientExtensions clientExtensions)
        {
            this.Price = priceValue;
            this.TimeInForce = timeInForce.ToString();
            this.GTDTime = dateTime;
            this.ClientExtensions = clientExtensions;
        }
    }
}