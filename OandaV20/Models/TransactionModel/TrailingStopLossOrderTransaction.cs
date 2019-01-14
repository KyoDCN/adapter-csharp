using OandaV20.Models.AccountModel;
using OandaV20.Models.OrderModel.Definitions;
using OandaV20.Models.Primitives;
using OandaV20.Models.TradeModel;
using OandaV20.Models.TransactionModel.Definitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OandaV20.Models.TransactionModel
{
    public class TrailingStopLossOrderTransaction
    {
        public TransactionID Id;
        public DateTime Time;
        public int UserID;
        public AccountID AccountID;
        public TransactionID BatchID;
        public RequestID RequestID;
        public TransactionType Type; // TRAILING_STOP_LOSS_ORDER
        public TradeID TradeID;
        public ClientID ClientTradeID;
        public double Distance;
        public TimeInForce TimeInForce; // GTC
        public DateTime GTDTime;
        public OrderTriggerCondition TriggerCondition; // Default
        public TrailingStopLossOrderReason Reason;
        public ClientExtensions ClientExtensions;
        public TransactionID OrderFillTransactionID;
        public OrderID ReplacesOrderID;
        public TransactionID CancellingTransactionID;

        public TrailingStopLossOrderTransaction()
        {
            this.Id = new TransactionID();
            this.Time = new DateTime();
            this.AccountID = new AccountID();
            this.BatchID = new TransactionID();
            this.RequestID = new RequestID();
            this.Type = new TransactionType(ETransactionType.TRAILING_STOP_LOSS_ORDER);
            this.TradeID = new TradeID();
            this.ClientTradeID = new ClientID();
            this.TimeInForce = new TimeInForce(ETimeInForce.GTC);
            this.GTDTime = new DateTime();
            this.TriggerCondition = new OrderTriggerCondition(EOrderTriggerCondition.DEFAULT);
            this.Reason = new TrailingStopLossOrderReason();
            this.ClientExtensions = new ClientExtensions();
            this.OrderFillTransactionID = new TransactionID();
            this.ReplacesOrderID = new OrderID();
            this.CancellingTransactionID = new TransactionID();
        }

        public TrailingStopLossOrderTransaction(TransactionID id, DateTime time, int userID, AccountID accountID, TransactionID batchID, RequestID requestID, TransactionType type, TradeID tradeID, ClientID clientTradeID, double distance, TimeInForce timeInForce, DateTime gTDTime, OrderTriggerCondition triggerCondition, TrailingStopLossOrderReason reason, ClientExtensions clientExtensions, TransactionID orderFillTransactionID, OrderID replacesOrderID, TransactionID cancellingTransactionID)
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
            this.Distance = distance;
            this.TimeInForce = timeInForce;
            this.GTDTime = gTDTime;
            this.TriggerCondition = triggerCondition;
            this.Reason = reason;
            this.ClientExtensions = clientExtensions;
            this.OrderFillTransactionID = orderFillTransactionID;
            this.ReplacesOrderID = replacesOrderID;
            this.CancellingTransactionID = cancellingTransactionID;
        }
    }
}
