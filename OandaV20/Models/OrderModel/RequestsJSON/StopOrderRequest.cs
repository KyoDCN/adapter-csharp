using Newtonsoft.Json;
using OandaV20.Models.OrderModel.Definitions;
using OandaV20.Models.PricingModel;
using OandaV20.Models.Primitives;
using OandaV20.Models.TransactionModel.Definitions;
using System;

namespace OandaV20.Models.OrderModel.RequestsJSON
{
    public class StopOrderRequest : OrderRequest
    {
        [JsonProperty(Required = Required.Always)]
        public string Instrument; // REQUIRED
        [JsonProperty(Required = Required.Always)]
        public double Units; // REQUIRED
        [JsonProperty(Required = Required.Always)]
        public double Price; // REQUIRED
        public double PriceBound;
        [JsonProperty(Required = Required.Always)]
        public string TimeInForce; // REQUIRED
        public DateTime GtdTime;
        [JsonProperty(Required = Required.Always)]
        public string PositionFill; // REQUIRED
        [JsonProperty(Required = Required.Always)]
        public string TriggerCondition; // REQUIRED
        public ClientExtensions ClientExtensions;
        public TakeProfitDetails TakeProfitOnFill;
        public StopLossDetails StopLossOnFill;
        public TrailingStopLossDetails TrailingStopLossOnFill;
        public ClientExtensions TradeClientExtensions;

        /// <summary>
        /// A StopOrderRequest specifies the parameters that may be set when creating a Stop Order.
        /// </summary>
        /// <param name="instrument">The Stop Order’s Instrument.</param>
        /// <param name="units">The quantity requested to be filled by the Stop Order. A posititive number of units results in a long Order, and a negative number of units results in a short Order.</param>
        /// <param name="price">The price threshold specified for the Stop Order. The Stop Order will only be filled by a market price that is equal to or worse than this price.</param>
        public StopOrderRequest(InstrumentName instrument, double units, PriceValue price)
        {
            this.Type = EOrderType.STOP.ToString();
            this.Instrument = instrument.ToString();
            this.Units = units;
            this.Price = price;
            this.TimeInForce = ETimeInForce.GTC.ToString();
            this.PositionFill = EOrderPositionFill.DEFAULT.ToString();
            this.TriggerCondition = EOrderTriggerCondition.DEFAULT.ToString();
        }
    }
}
