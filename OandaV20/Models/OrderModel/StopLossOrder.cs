using OandaV20.Models.OrderModel.Definitions;
using OandaV20.Models.PricingModel;
using OandaV20.Models.TradeModel;
using OandaV20.Models.TransactionModel.Definitions;
using System;
using System.Collections.Generic;

namespace OandaV20.Models.OrderModel
{
    public class StopLossOrder
    {
        public OrderID Id;
        public DateTime CreateTime;
        public OrderState State;
        public ClientExtensions ClientExtensions;
        public OrderType Type;
        public double GuaranteedExecutionPremium;
        public TradeID TradeID;
        public ClientID ClientTradeID;
        public PriceValue Price;
        public double Distance;
        public TimeInForce TimeInForce;
        public DateTime GtdTime;
        public OrderTriggerCondition TriggerCondition;
        public bool Guaranteed;
        public TransactionID FillingTransactionID;
        public DateTime FilledTime;
        public TradeID TradeOpenedID;
        public TradeID TradeReducedID;
        public List<TradeID> TradeClosedIDs;
        public TransactionID CancellingTransactionID;
        public DateTime CancelledTime;
        public OrderID ReplacesOrderID;
        public OrderID ReplacedByOrderID;

        public StopLossOrder()
        {
            this.Id = new OrderID();
            this.CreateTime = new DateTime();
            this.State = new OrderState();
            this.ClientExtensions = new ClientExtensions();
            this.Type = new OrderType(EOrderType.STOP_LOSS);
            this.TradeID = new TradeID();
            this.ClientTradeID = new ClientID();
            this.Price = new PriceValue();
            this.TimeInForce = new TimeInForce(ETimeInForce.GTC);
            this.GtdTime = new DateTime();
            this.TriggerCondition = new OrderTriggerCondition(EOrderTriggerCondition.DEFAULT);
            this.Guaranteed = new bool();
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
        public StopLossOrder(OrderID id, DateTime createTime, OrderState state, ClientExtensions clientExtensions, OrderType type, double guaranteedExecutionPremium, TradeID tradeID, ClientID clientTradeID, PriceValue price, double distance, TimeInForce timeInForce, DateTime gtdTime, OrderTriggerCondition triggerCondition, bool guaranteed, TransactionID fillingTransactionID, DateTime filledTime, TradeID tradeOpenedID, TradeID tradeReducedID, List<TradeID> tradeClosedIDs, TransactionID cancellingTransactionID, DateTime cancelledTime, OrderID replacesOrderID, OrderID replacedByOrderID)
        {
            this.Id = id;
            this.CreateTime = createTime;
            this.State = state;
            this.ClientExtensions = clientExtensions;
            this.Type = type;
            this.GuaranteedExecutionPremium = guaranteedExecutionPremium;
            this.TradeID = tradeID;
            this.ClientTradeID = clientTradeID;
            this.Price = price;
            this.Distance = distance;
            this.TimeInForce = timeInForce;
            this.GtdTime = gtdTime;
            this.TriggerCondition = triggerCondition;
            this.Guaranteed = guaranteed;
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
