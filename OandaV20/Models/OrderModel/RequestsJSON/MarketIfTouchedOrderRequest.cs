using Newtonsoft.Json;
using OandaV20.Models.OrderModel.Definitions;
using OandaV20.Models.PricingModel;
using OandaV20.Models.Primitives;
using OandaV20.Models.TransactionModel.Definitions;
using System;

namespace OandaV20.Models.OrderModel.RequestsJSON
{
    public class MarketIfTouchedOrderRequest : OrderRequest
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
        /// A MarketIfTouchedOrderRequest specifies the parameters that may be set when creating a Market-if-Touched Order.
        /// </summary>
        /// <param name="instrument">The MarketIfTouched Order’s Instrument.</param>
        /// <param name="units">The quantity requested to be filled by the MarketIfTouched Order. A posititive number of units results in a long Order, and a negative number of units results in a short Order.</param>
        /// <param name="price">The price threshold specified for the MarketIfTouched Order. The MarketIfTouched Order will only be filled by a market price that crosses this price from the direction of the market price at the time when the Order was created (the initialMarketPrice). Depending on the value of the Order’s price and initialMarketPrice, the MarketIfTouchedOrder will behave like a Limit or a Stop Order.</param>
        public MarketIfTouchedOrderRequest(InstrumentName instrument, double units, PriceValue price)
        {
            this.Type = EOrderType.MARKET_IF_TOUCHED.ToString();
            this.Instrument = instrument.ToString();
            this.Units = units;
            this.Price = price;
            this.TimeInForce = ETimeInForce.GTC.ToString();
            this.PositionFill = EOrderPositionFill.DEFAULT.ToString();
            this.TriggerCondition = EOrderTriggerCondition.DEFAULT.ToString();
        }
    }
}
