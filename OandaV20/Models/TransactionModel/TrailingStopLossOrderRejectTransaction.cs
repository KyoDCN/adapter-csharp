using OandaV20.Models.AccountModel;
using OandaV20.Models.OrderModel.Definitions;
using OandaV20.Models.TradeModel;
using OandaV20.Models.TransactionModel.Definitions;
using System;

namespace OandaV20.Models.TransactionModel
{
    public class TrailingStopLossOrderRejectTransaction
    {
        public TransactionID TransactionID;
        public DateTime Time;
        public int UserID;
        public AccountID AccountID;
        public TransactionID BatchID;
        public RequestID RequestID;
        public TransactionType Type; // TRAILING_STOP_LOSS_ORDER_REJECT
        public TradeID TradeID;
        public ClientID ClientTradeID;
        public double Distance;
        public TimeInForce TimeInForce; // GTC
        public DateTime GTDTime;
        public OrderTriggerCondition TriggerCondition; // Default
        public TrailingStopLossOrderReason Reason;
        public ClientExtensions ClientExtensions;
        public TransactionID OrderFillTransactionID;
        public OrderID IntendedReplacesOrderID;
        public TransactionRejectReason RejectReason;

        public TrailingStopLossOrderRejectTransaction()
        {
            this.TransactionID = new TransactionID();
            this.Time = new DateTime();
            this.AccountID = new AccountID();
            this.BatchID = new TransactionID();
            this.RequestID = new RequestID();
            this.Type = new TransactionType(ETransactionType.TRAILING_STOP_LOSS_ORDER_REJECT);
            this.TradeID = new TradeID();
            this.ClientTradeID = new ClientID();
            this.TimeInForce = new TimeInForce(ETimeInForce.GTC);
            this.GTDTime = new DateTime();
            this.TriggerCondition = new OrderTriggerCondition(EOrderTriggerCondition.DEFAULT);
            this.Reason = new TrailingStopLossOrderReason();
            this.ClientExtensions = new ClientExtensions();
            this.OrderFillTransactionID = new TransactionID();
            this.IntendedReplacesOrderID = new OrderID();
            this.RejectReason = new TransactionRejectReason();
        }

        public TrailingStopLossOrderRejectTransaction(TransactionID transactionID, DateTime time, int userID, AccountID accountID, TransactionID batchID, RequestID requestID, TransactionType type, TradeID tradeID, ClientID clientTradeID, double distance, TimeInForce timeInForce, DateTime gTDTime, OrderTriggerCondition triggerCondition, TrailingStopLossOrderReason reason, ClientExtensions clientExtensions, TransactionID orderFillTransactionID, OrderID intendedReplacesOrderID, TransactionRejectReason rejectReason)
        {
            this.TransactionID = transactionID;
            this.Time = time;
            this.UserID = userID;
            this.AccountID = accountID;
            this.BatchID = batchID;
            this.RequestID = requestID;
            this.Type = type;
            this.TradeID = tradeID;
            this.ClientTradeID = clientTradeID;
            this.Distance = distance;
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
