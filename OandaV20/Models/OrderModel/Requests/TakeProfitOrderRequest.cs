using Newtonsoft.Json;
using OandaV20.Models.OrderModel.Definitions;
using OandaV20.Models.PricingModel;
using OandaV20.Models.TradeModel;
using OandaV20.Models.TransactionModel.Definitions;
using System;

namespace OandaV20.Models.OrderModel.Requests
{
    public class TakeProfitOrderRequest : OrderRequest
    {
        [JsonConverter(typeof(ParseAsStringConverter))]
        public TradeID TradeID;
        [JsonConverter(typeof(ParseAsStringConverter))]
        public ClientID ClientTradeID;
        [JsonConverter(typeof(ParseAsStringConverter))]
        public PriceValue Price;
        [JsonConverter(typeof(ParseAsStringConverter))]
        public TimeInForce TimeInForce;
        public DateTime GtdTime;
        [JsonConverter(typeof(ParseAsStringConverter))]
        public OrderTriggerCondition TriggerCondition;
        public ClientExtensions ClientExtensions;

        /// <summary>
        /// A TakeProfitOrderRequest specifies the parameters that may be set when creating a Take Profit Order. Only one of the price and distance fields may be specified.
        /// </summary>
        /// <param name="tradeID">The ID of the Trade to close when the price threshold is breached.</param>
        /// <param name="price">The price threshold specified for the TakeProfit Order. The associated Trade will be closed by a market price that is equal to or better than this threshold.</param>
        public TakeProfitOrderRequest(TradeID tradeID, PriceValue price)
        {
            this.Type = EOrderType.TAKE_PROFIT;
            this.TradeID = tradeID;
            this.Price = price;
            this.TimeInForce = ETimeInForce.GTC;
            this.GtdTime = DateTime.UtcNow;
            this.TriggerCondition = EOrderTriggerCondition.DEFAULT;
        }
    }
}
