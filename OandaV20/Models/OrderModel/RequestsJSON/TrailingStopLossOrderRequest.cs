using Newtonsoft.Json;
using OandaV20.Models.OrderModel.Definitions;
using OandaV20.Models.TradeModel;
using OandaV20.Models.TransactionModel.Definitions;
using System;

namespace OandaV20.Models.OrderModel.RequestsJSON
{
    public class TrailingStopLossOrderRequest : OrderRequest
    {
        [JsonProperty(Required = Required.Always)]
        public string TradeID; // REQUIRED
        public string ClientTradeID;
        [JsonProperty(Required = Required.Always)]
        public double Distance; // REQUIRED
        [JsonProperty(Required = Required.Always)]
        public string TimeInForce; // REQUIRED
        public DateTime GtdTime;
        [JsonProperty(Required = Required.Always)]
        public string TriggerCondition; // REQUIRED
        public ClientExtensions ClientExtensions;

        /// <summary>
        /// A TrailingStopLossOrderRequest specifies the parameters that may be set when creating a Trailing Stop Loss Order.
        /// </summary>
        /// <param name="tradeID">The ID of the Trade to close when the price threshold is breached.</param>
        /// <param name="distance">The price distance (in price units) specified for the TrailingStopLoss Order.</param>
        public TrailingStopLossOrderRequest(TradeID tradeID, double distance)
        {
            this.Type = EOrderType.TRAILING_STOP_LOSS.ToString();
            this.TradeID = tradeID;
            this.Distance = distance;
            this.TimeInForce = ETimeInForce.GTC.ToString();
            this.TriggerCondition = EOrderTriggerCondition.DEFAULT.ToString();
        }
    }
}
