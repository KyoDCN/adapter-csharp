using Newtonsoft.Json;
using OandaV20.Models.OrderModel.Definitions;
using OandaV20.Models.PricingModel;
using OandaV20.Models.Primitives;
using OandaV20.Models.TransactionModel.Definitions;
using System;

namespace OandaV20.Models.OrderModel.RequestsJSON
{
    public class LimitOrderRequest : OrderRequest
    {
        [JsonProperty(Required = Required.Always)]
        public string Instrument { get; set; } // REQUIRED
        [JsonProperty(Required = Required.Always)]
        public double Units { get; set; } // REQUIRED
        [JsonProperty(Required = Required.Always)]
        public double Price { get; set; } // REQUIRED
        [JsonProperty(Required = Required.Always)]
        public string TimeInForce { get; set; } // REQUIRED
        public DateTime? GtdTime { get; set; }
        [JsonProperty(Required = Required.Always)]
        public string PositionFill { get; set; } // REQUIRED
        [JsonProperty(Required = Required.Always)]
        public string TriggerCondition { get; set; } // REQUIRED
        public ClientExtensions ClientExtensions { get; set; }
        public TakeProfitDetails TakeProfitOnFill { get; set; }
        public StopLossDetails StopLossOnFill { get; set; }
        public TrailingStopLossDetails TrailingStopLossOnFill { get; set; }
        public ClientExtensions TradeClientExtensions { get; set; }

        /// <summary>
        /// A LimitOrderRequest specifies the parameters that may be set when creating a Limit Order.
        /// </summary>
        /// <param name="instrument">The Limit Order’s Instrument.</param>
        /// <param name="units">The quantity requested to be filled by the Limit Order. A positive number of units results in a long Order, and a negative number of units results in a short Order.</param>
        /// <param name="price">The price threshold specified for the Limit Order. The Limit Order will only be filled by a market price that is equal to or better than this price.</param>
        public LimitOrderRequest(
            EInstrumentName instrument,
            double units,
            PriceValue price
        ) {
            this.Type = EOrderType.LIMIT.ToString();
            this.Instrument = instrument.ToString();
            this.Units = units;
            this.Price = price;
            this.TimeInForce = ETimeInForce.GTC.ToString();
            this.PositionFill = EOrderPositionFill.DEFAULT.ToString();
            this.TriggerCondition = EOrderTriggerCondition.DEFAULT.ToString();
        }
    }
}
