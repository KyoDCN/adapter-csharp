using Newtonsoft.Json;
using OandaV20.Models.OrderModel.Definitions;
using OandaV20.Models.PricingModel;
using OandaV20.Models.TradeModel;
using OandaV20.Models.TransactionModel.Definitions;
using System;

namespace OandaV20.Models.OrderModel.Requests
{
    public class StopLossOrderRequest : OrderRequest
    {
        [JsonConverter(typeof(ParseAsStringConverter))]
        public TradeID TradeID; // REQUIRED
        [JsonConverter(typeof(ParseAsStringConverter))]
        public ClientID ClientTradeID;
        [JsonConverter(typeof(ParseAsStringConverter))]
        public PriceValue Price; // REQUIRED
        public double Distance;
        [JsonConverter(typeof(ParseAsStringConverter))]
        public TimeInForce TimeInForce; // REQUIRED
        public DateTime GtdTime;
        [JsonConverter(typeof(ParseAsStringConverter))]
        public OrderTriggerCondition TriggerCondition; // REQUIRED
        public bool Guaranteed;
        public ClientExtensions ClientExtensions;

        /// <summary>
        /// A StopLossOrderRequest specifies the parameters that may be set when creating a Stop Loss Order. Only one of the price and distance fields may be specified.
        /// </summary>
        /// <param name="tradeID">The ID of the Trade to close when the price threshold is breached.</param>
        /// <param name="price">The price threshold specified for the Stop Loss Order. If the guaranteed flag is false, the associated Trade will be closed by a market price that is equal to or worse than this threshold. If the flag is true the associated Trade will be closed at this price.</param>
        public StopLossOrderRequest(TradeID tradeID, PriceValue price)
        {
            this.Type = EOrderType.STOP_LOSS;
            this.TradeID = tradeID;
            this.Price = price;
            this.TimeInForce = ETimeInForce.GTC;
            this.GtdTime = DateTime.UtcNow;
            this.TriggerCondition = EOrderTriggerCondition.DEFAULT;
        }
    }
}
