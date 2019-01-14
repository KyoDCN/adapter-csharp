using OandaV20.Models.AccountModel;
using OandaV20.Models.OrderModel.Definitions;
using OandaV20.Models.PricingModel;
using OandaV20.Models.Primitives;
using OandaV20.Models.TradeModel;
using OandaV20.Models.TransactionModel.Definitions;
using System;

namespace OandaV20.Models.TransactionModel
{
    public class StopLossOrderTransaction
    {
        public TransactionID Id;
        public DateTime Time;
        public int UserID;
        public AccountID AccountID;
        public TransactionID BatchID;
        public RequestID RequestID;
        public TransactionType Type; // STOP_LOSS_ORDER
        public TradeID TradeID;
        public ClientID ClientTradeID;
        public PriceValue Price;
        public double Distance;
        public TimeInForce TimeInForce; // GTC
        public DateTime GTDTime;
        public OrderTriggerCondition TriggerCondition; // DEFAULT
        public bool Guaranteed;
        public double GuaranteedExecutionPremium;
        public StopLossOrderReason Reason;
        public ClientExtensions ClientExtensions;
        public TransactionID OrderFillTransactionID;
        public OrderID ReplacesOrderID;
        public TransactionID CancellingTransactionID;

        public StopLossOrderTransaction()
        {
            this.Id = new TransactionID();
            this.Time = new DateTime();
            this.AccountID = new AccountID();
            this.BatchID = new TransactionID();
            this.RequestID = new RequestID();
            this.Type = new TransactionType(ETransactionType.STOP_LOSS_ORDER);
            this.TradeID = new TradeID();
            this.ClientTradeID = new ClientID();
            this.Price = new PriceValue();
            this.TimeInForce = new TimeInForce(ETimeInForce.GTC);
            this.GTDTime = new DateTime();
            this.TriggerCondition = new OrderTriggerCondition(EOrderTriggerCondition.DEFAULT);
            this.Reason = new StopLossOrderReason();
            this.ClientExtensions = new ClientExtensions();
            this.OrderFillTransactionID = new TransactionID();
            this.ReplacesOrderID = new OrderID();
            this.CancellingTransactionID = new TransactionID();
        }

        public StopLossOrderTransaction(TransactionID id, DateTime time, int userID, AccountID accountID, TransactionID batchID, RequestID requestID, TransactionType type, TradeID tradeID, ClientID clientTradeID, PriceValue price, double distance, TimeInForce timeInForce, DateTime gTDTime, OrderTriggerCondition triggerCondition, bool guaranteed, double guaranteedExecutionPremium, StopLossOrderReason reason, ClientExtensions clientExtensions, TransactionID orderFillTransactionID, OrderID replacesOrderID, TransactionID cancellingTransactionID)
        {
            this.Id = id;
            this.Time = time;
            this.UserID = userID;
            this.AccountID = accountID;
            this.BatchID = batchID;
            this.RequestID = requestID;
            this.Type = type;
            this.TradeID = tradeID;
            this.ClientTradeID = clientTradeID;
            this.Price = price;
            this.Distance = distance;
            this.TimeInForce = timeInForce;
            this.GTDTime = gTDTime;
            this.TriggerCondition = triggerCondition;
            this.Guaranteed = guaranteed;
            this.GuaranteedExecutionPremium = guaranteedExecutionPremium;
            this.Reason = reason;
            this.ClientExtensions = clientExtensions;
            this.OrderFillTransactionID = orderFillTransactionID;
            this.ReplacesOrderID = replacesOrderID;
            this.CancellingTransactionID = cancellingTransactionID;
        }
    }
}
