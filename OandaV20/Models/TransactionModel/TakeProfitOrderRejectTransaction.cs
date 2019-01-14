using OandaV20.Models.AccountModel;
using OandaV20.Models.OrderModel.Definitions;
using OandaV20.Models.PricingModel;
using OandaV20.Models.TradeModel;
using OandaV20.Models.TransactionModel.Definitions;
using System;

namespace OandaV20.Models.TransactionModel
{
    public class TakeProfitOrderRejectTransaction
    {
        public TransactionID Id;
        public DateTime Time;
        public int UserID;
        public AccountID AccountID;
        public TransactionID BatchID;
        public RequestID RequestID;
        public TransactionType Type; // TAKE_PROFIT_ORDER_REJECT
        public TradeID TradeID;
        public ClientID ClientTradeID;
        public PriceValue Price;
        public TimeInForce TimeInForce; // GTC
        public DateTime GTDTime;
        public OrderTriggerCondition TriggerCondition; // DEFAULT
        public TakeProfitOrderReason Reason;
        public ClientExtensions ClientExtensions;
        public TransactionID OrderFillTransactionID;
        public OrderID IntendedReplacesOrderID;
        public TransactionRejectReason RejectReason;

        public TakeProfitOrderRejectTransaction()
        {
            this.Id = new TransactionID();
            this.Time = new DateTime();
            this.AccountID = new AccountID();
            this.BatchID = new TransactionID();
            this.RequestID = new RequestID();
            this.Type = new TransactionType(ETransactionType.TAKE_PROFIT_ORDER_REJECT);
            this.TradeID = new TradeID();
            this.ClientTradeID = new ClientID();
            this.Price = new PriceValue();
            this.TimeInForce = new TimeInForce(ETimeInForce.GTC);
            this.GTDTime = new DateTime();
            this.TriggerCondition = new OrderTriggerCondition(EOrderTriggerCondition.DEFAULT);
            this.Reason = new TakeProfitOrderReason();
            this.ClientExtensions = new ClientExtensions();
            this.OrderFillTransactionID = new TransactionID();
            this.IntendedReplacesOrderID = new OrderID();
            this.RejectReason = new TransactionRejectReason();
        }

        public TakeProfitOrderRejectTransaction(TransactionID id, DateTime time, int userID, AccountID accountID, TransactionID batchID, RequestID requestID, TransactionType type, TradeID tradeID, ClientID clientTradeID, PriceValue price, TimeInForce timeInForce, DateTime gTDTime, OrderTriggerCondition triggerCondition, TakeProfitOrderReason reason, ClientExtensions clientExtensions, TransactionID orderFillTransactionID, OrderID intendedReplacesOrderID, TransactionRejectReason rejectReason)
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
            this.TimeInForce = timeInForce;
            this.GTDTime = gTDTime;
            this.TriggerCondition = triggerCondition;
            this.Reason = reason;
            this.ClientExtensions = clientExtensions;
            this.OrderFillTransactionID = orderFillTransactionID;
            this.IntendedReplacesOrderID = intendedReplacesOrderID;
            this.RejectReason = rejectReason;
        }
    }
}
