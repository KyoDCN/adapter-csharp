using Newtonsoft.Json;
using OandaV20.Models.OrderModel.Definitions;
using OandaV20.Models.TradeModel;
using OandaV20.Models.TransactionModel.Definitions;
using System;

namespace OandaV20.Models.OrderModel.Requests
{
    public class TrailingStopLossOrderRequest : OrderRequest
    {
        [JsonConverter(typeof(ParseAsStringConverter))]
        public TradeID TradeID;
        [JsonConverter(typeof(ParseAsStringConverter))]
        public ClientID ClientTradeID;
        public double Distance;
        [JsonConverter(typeof(ParseAsStringConverter))]
        public TimeInForce TimeInForce;
        public DateTime GtdTime;
        [JsonConverter(typeof(ParseAsStringConverter))]
        public OrderTriggerCondition TriggerCondition;
        public ClientExtensions ClientExtensions;

        /// <summary>
        /// A TrailingStopLossOrderRequest specifies the parameters that may be set when creating a Trailing Stop Loss Order.
        /// </summary>
        /// <param name="tradeID">The ID of the Trade to close when the price threshold is breached.</param>
        /// <param name="distance">The price distance (in price units) specified for the TrailingStopLoss Order.</param>
        public TrailingStopLossOrderRequest(TradeID tradeID, double distance)
        {
            this.Type = EOrderType.TRAILING_STOP_LOSS;
            this.TradeID = tradeID;
            this.Distance = distance;
            this.TimeInForce = ETimeInForce.GTC;
            this.GtdTime = DateTime.UtcNow;
            this.TriggerCondition = EOrderTriggerCondition.DEFAULT;
        }
    }
}
