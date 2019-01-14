using OandaV20.Models.OrderModel.Definitions;
using OandaV20.Models.PricingModel;
using OandaV20.Models.Primitives;
using OandaV20.Models.TradeModel;
using OandaV20.Models.TransactionModel.Definitions;
using System;
using System.Collections.Generic;

namespace OandaV20.Models.OrderModel
{
    public class MarketIfTouchedOrder
    {
        public OrderID Id;
        public DateTime CreateTime;
        public OrderState State;
        public ClientExtensions ClientExtensions;
        public OrderType Type;
        public InstrumentName Instrument;
        public double Units;
        public PriceValue Price;
        public PriceValue PriceBound;
        public TimeInForce TimeInForce;
        public DateTime GtdTime;
        public OrderPositionFill PositionFill;
        public OrderTriggerCondition TriggerCondition;
        public PriceValue InitialMarketPrice;
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
        public OrderID ReplacesOrderID;
        public OrderID ReplacedByOrderID;

        public MarketIfTouchedOrder()
        {
            this.Id = new OrderID();
            this.CreateTime = new DateTime();
            this.State = new OrderState();
            this.ClientExtensions = new ClientExtensions();
            this.Type = new OrderType(EOrderType.MARKET_IF_TOUCHED);
            this.Instrument = new InstrumentName();
            this.Price = new PriceValue();
            this.PriceBound = new PriceValue();
            this.TimeInForce = new TimeInForce(ETimeInForce.GTC);
            this.GtdTime = new DateTime();
            this.PositionFill = new OrderPositionFill(EOrderPositionFill.DEFAULT);
            this.TriggerCondition = new OrderTriggerCondition(EOrderTriggerCondition.DEFAULT);
            this.InitialMarketPrice = new PriceValue();
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
            this.ReplacesOrderID = new OrderID();
            this.ReplacedByOrderID = new OrderID();
        }
        public MarketIfTouchedOrder(OrderID id, DateTime createTime, OrderState state, ClientExtensions clientExtensions, OrderType type, InstrumentName instrument, double units, PriceValue price, PriceValue priceBound, TimeInForce timeInForce, DateTime gtdTime, OrderPositionFill positionFill, OrderTriggerCondition triggerCondition, PriceValue initialMarketPrice, TakeProfitDetails takeProfitOnFill, StopLossDetails stopLossOnFill, TrailingStopLossDetails trailingStopLossOnFill, ClientExtensions tradeClientExtensions, TransactionID fillingTransactionID, DateTime filledTime, TradeID tradeOpenedID, TradeID tradeReducedID, List<TradeID> tradeClosedIDs, TransactionID cancellingTransactionID, DateTime cancelledTime, OrderID replacesOrderID, OrderID replacedByOrderID)
        {
            this.Id = id;
            this.CreateTime = createTime;
            this.State = state;
            this.ClientExtensions = clientExtensions;
            this.Type = type;
            this.Instrument = instrument;
            this.Units = units;
            this.Price = price;
            this.PriceBound = priceBound;
            this.TimeInForce = timeInForce;
            this.GtdTime = gtdTime;
            this.PositionFill = positionFill;
            this.TriggerCondition = triggerCondition;
            this.InitialMarketPrice = initialMarketPrice;
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
            this.ReplacesOrderID = replacesOrderID;
            this.ReplacedByOrderID = replacedByOrderID;
        }
    }
}
