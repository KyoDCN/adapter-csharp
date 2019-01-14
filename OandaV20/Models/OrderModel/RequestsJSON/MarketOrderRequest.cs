using Newtonsoft.Json;
using OandaV20.Models.OrderModel.Definitions;
using OandaV20.Models.Primitives;
using OandaV20.Models.TransactionModel.Definitions;

namespace OandaV20.Models.OrderModel.RequestsJSON
{
    public class MarketOrderRequest : OrderRequest
    {
        [JsonProperty(Required = Required.Always)]
        public string Instrument { get; set; } // REQUIRED
        [JsonProperty(Required = Required.Always)]
        public double Units { get; set; } // REQUIRED
        [JsonProperty(Required = Required.Always)]
        public string TimeInForce { get; set; } // REQUIRED
        public double PriceBound { get; set; }
        [JsonProperty(Required = Required.Always)]
        public string PositionFill { get; set; } // REQUIRED
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
            this.Type = EOrderType.MARKET.ToString();
            this.Instrument = instrument.ToString();
            this.Units = units;
            this.TimeInForce = ETimeInForce.FOK.ToString();
            this.PositionFill = EOrderPositionFill.DEFAULT.ToString();
        }
    }
}
