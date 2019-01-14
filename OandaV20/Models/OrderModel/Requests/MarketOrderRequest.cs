using Newtonsoft.Json;
using OandaV20.Models.OrderModel.Definitions;
using OandaV20.Models.PricingModel;
using OandaV20.Models.Primitives;
using OandaV20.Models.TransactionModel.Definitions;
using System;

namespace OandaV20.Models.OrderModel.Requests
{
    public class MarketOrderRequest : OrderRequest
    {
        [JsonConverter(typeof(ParseAsStringConverter))]
        public InstrumentName Instrument { get; set; }  // REQUIRED
        public double Units { get; set; }  // REQUIRED
        [JsonConverter(typeof(ParseAsStringConverter))]
        public TimeInForce TimeInForce { get; set; }  // REQUIRED
        [JsonConverter(typeof(ParseAsStringConverter))]
        public PriceValue PriceBound { get; set; }
        [JsonConverter(typeof(ParseAsStringConverter))]
        public OrderPositionFill PositionFill { get; set; } // REQUIRED
        public ClientExtensions ClientExtensions { get; set; }
        public TakeProfitDetails TakeProfitOnFill { get; set; }
        public StopLossDetails StopLossOnFill { get; set; }
        public TrailingStopLossDetails TrailingStopLossOnFill { get; set; }
        public ClientExtensions TradeClientExtensions { get; set; }

        /// <summary>
        /// A MarketOrderRequest specifies the parameters that may be set when creating a Market Order.
        /// </summary>
        /// <param name="instrument">The Market Order’s Instrument.</param>
        /// <param name="units">The quantity requested to be filled by the Market Order. A posititive number of units results in a long Order, and a negative number of units results in a short Order.</param>
        public MarketOrderRequest(InstrumentName instrument, double units)
        {
            this.Type = EOrderType.MARKET;
            this.Instrument = instrument;
            this.Units = units;
            this.TimeInForce = ETimeInForce.FOK;
            this.PositionFill = EOrderPositionFill.DEFAULT;
        }
    }
}
