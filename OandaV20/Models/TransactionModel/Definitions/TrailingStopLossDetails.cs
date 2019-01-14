using Newtonsoft.Json;
using OandaV20.Models.OrderModel.Definitions;
using OandaV20.Models.OrderModel.Requests;
using System;

namespace OandaV20.Models.TransactionModel.Definitions
{
    public class TrailingStopLossDetails
    {
        public double Distance;
        [JsonConverter(typeof(ParseAsStringConverter))]
        public TimeInForce TimeInForce;
        public DateTime GTDTime;
        public ClientExtensions ClientExtensions;

        public TrailingStopLossDetails()
        {
            this.TimeInForce = ETimeInForce.GTC.ToString();
            this.GTDTime = new DateTime();
            this.ClientExtensions = new ClientExtensions();
        }
        public TrailingStopLossDetails(
            double distance, 
            ETimeInForce timeInForce, 
            DateTime gtdTime,
            ClientExtensions clientExtensions
        ) {
            this.Distance = distance;
            this.TimeInForce = timeInForce.ToString();
            this.GTDTime = gtdTime;
            this.ClientExtensions = clientExtensions;
        }
    }
}
