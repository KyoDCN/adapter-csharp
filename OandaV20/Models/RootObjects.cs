using OandaV20.Models.InstrumentsModel;
using OandaV20.Models.PricingModel;
using OandaV20.Models.Primitives;
using OandaV20.Models.TransactionModel;
using OandaV20.Models.TransactionModel.Definitions;
using System;
using System.Collections.Generic;

namespace OandaV20.Models
{
    public class CandlestickResponse
    {
        public InstrumentName Instrument { get; set; }
        public CandlestickGranularity Granularity { get; set; }
        public List<Candlestick> Candles { get; set; }
    }

    public class PositionCloseoutResponse
    {
        public MarketOrderTransaction LongOrderCreateTransaction;
        public OrderFillTransaction LongOrderFillTransaction;
        public OrderCancelTransaction LongOrderCancelTransaction;
        public MarketOrderTransaction ShortOrderCreateTransaction;
        public OrderFillTransaction ShortOrderFillTransaction;
        public OrderCancelTransaction ShortOrderCancelTransaction;
        public List<TransactionID> RelatedTransactionIDs;
        public TransactionID LastTransactionID;
    }

    public class PricingResponse
    {
        public List<Price> Prices; // REQUIRED
        public List<HomeConversions> HomeConversions;
        public DateTime Time;
    }
}
