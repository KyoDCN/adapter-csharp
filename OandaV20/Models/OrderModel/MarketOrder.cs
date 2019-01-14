using OandaV20.Models.OrderModel.Definitions;
using OandaV20.Models.PricingModel;
using OandaV20.Models.Primitives;
using OandaV20.Models.TradeModel;
using OandaV20.Models.TransactionModel.Definitions;
using System;
using System.Collections.Generic;

namespace OandaV20.Models.OrderModel
{
    public class MarketOrder
    {
        public OrderID Id;
        public DateTime CreateTime;
        public OrderState State;
        public ClientExtensions ClientExtensions;
        public OrderType Type;
        public InstrumentName Instrument;
        public double Units;
        public TimeInForce TimeInForce;
        public PriceValue PriceBound;
        public OrderPositionFill PositionFill;
        public MarketOrderTradeClose TradeClose;
        public MarketOrderPositionCloseout LongPositionCloseout;
        public MarketOrderPositionCloseout ShortPositionCloseout;
        public MarketOrderMarginCloseout MarginCloseout;
        public MarketOrderDelayedTradeClose DelayedTradeClose;
        public TakeProfitDetails TakeProfitOnFill;
        public StopLossDetails StopLossOnFill;
        public TrailingStopLossDetails TrailingStopLossOnFill;
        public ClientExtensions TradeClientExtensions;
        public TransactionID FillingTransactionID;
        public DateTime FilledTime;
        public TradeID TradeOpenedID;
        public TradeID TradeReducedID;
        public List<TradeID> TradeClosedIDs;
        public TransactionID CancellingTransactionID;
        public DateTime CancelledTime;

        public MarketOrder()
        {
            this.Id = new OrderID();
            this.CreateTime = new DateTime();
            this.State = new OrderState();
            this.ClientExtensions = new ClientExtensions();
            this.Type = new OrderType(EOrderType.MARKET);
            this.Instrument = new InstrumentName();
            this.TimeInForce = new TimeInForce(ETimeInForce.FOK);
            this.PriceBound = new PriceValue();
            this.PositionFill = new OrderPositionFill(EOrderPositionFill.DEFAULT);
            this.TradeClose = new MarketOrderTradeClose();
            this.LongPositionCloseout = new MarketOrderPositionCloseout();
            this.ShortPositionCloseout = new MarketOrderPositionCloseout();
            this.MarginCloseout = new MarketOrderMarginCloseout();
            this.DelayedTradeClose = new MarketOrderDelayedTradeClose();
            this.TakeProfitOnFill = new TakeProfitDetails();
            this.StopLossOnFill = new StopLossDetails();
            this.TrailingStopLossOnFill = new TrailingStopLossDetails();
            this.TradeClientExtensions = new ClientExtensions();
            this.FillingTransactionID = new TransactionID();
            this.FilledTime = new DateTime();
            this.TradeOpenedID = new TradeID();
            this.TradeReducedID = new TradeID();
            this.TradeClosedIDs = new List<TradeID>();
            this.CancellingTransactionID = new TransactionID();
            this.CancelledTime = new DateTime();
        }
        public MarketOrder(OrderID id, DateTime createTime, OrderState state, ClientExtensions clientExtensions, OrderType type, InstrumentName instrument, double units, TimeInForce timeInForce, PriceValue priceBound, OrderPositionFill positionFill, MarketOrderTradeClose tradeClose, MarketOrderPositionCloseout longPositionCloseout, MarketOrderPositionCloseout shortPositionCloseout, MarketOrderMarginCloseout marginCloseout, MarketOrderDelayedTradeClose delayedTradeClose, TakeProfitDetails takeProfitOnFill, StopLossDetails stopLossOnFill, TrailingStopLossDetails trailingStopLossOnFill, ClientExtensions tradeClientExtensions, TransactionID fillingTransactionID, DateTime filledTime, TradeID tradeOpenedID, TradeID tradeReducedID, List<TradeID> tradeClosedIDs, TransactionID cancellingTransactionID, DateTime cancelledTime)
        {
            this.Id = id;
            this.CreateTime = createTime;
            this.State = state;
            this.ClientExtensions = clientExtensions;
            this.Type = type;
            this.Instrument = instrument;
            this.Units = units;
            this.TimeInForce = timeInForce;
            this.PriceBound = priceBound;
            this.PositionFill = positionFill;
            this.TradeClose = tradeClose;
            this.LongPositionCloseout = longPositionCloseout;
            this.ShortPositionCloseout = shortPositionCloseout;
            this.MarginCloseout = marginCloseout;
            this.DelayedTradeClose = delayedTradeClose;
            this.TakeProfitOnFill = takeProfitOnFill;
            this.StopLossOnFill = stopLossOnFill;
            this.TrailingStopLossOnFill = trailingStopLossOnFill;
            this.TradeClientExtensions = tradeClientExtensions;
            this.FillingTransactionID = fillingTransactionID;
            this.FilledTime = filledTime;
            this.TradeOpenedID = tradeOpenedID;
            this.TradeReducedID = tradeReducedID;
            this.TradeClosedIDs = tradeClosedIDs;
            this.CancellingTransactionID = cancellingTransactionID;
            this.CancelledTime = cancelledTime;
        }
    }
}
