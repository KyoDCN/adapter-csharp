using OandaV20.Models.AccountModel;
using OandaV20.Models.OrderModel.Definitions;
using OandaV20.Models.PricingModel;
using OandaV20.Models.Primitives;
using OandaV20.Models.TradeModel;
using OandaV20.Models.TransactionModel.Definitions;
using System;

namespace OandaV20.Models.TransactionModel
{
    public class StopLossOrderRejectTransaction
    {
        public TransactionID Id;
        public DateTime Time;
        public int UserID;
        public AccountID AccountID;
        public TransactionID BatchID;
        public RequestID RequestID;
        public TransactionType Type; // STOP_LOSS_ORDER_REJECT
        public TradeID TradeID;
        public ClientID ClientTradeID;
        public PriceValue Price;
        public double Distance;
        public TimeInForce TimeInForce; // GTC
        public DateTime GTDTime;
        public OrderTriggerCondition TriggerCondition; // DEFAULT
        public bool Guaranteed;
        public StopLossOrderReason Reason;
        public ClientExtensions ClientExtensions;
        public TransactionID OrderFillTransactionID;
        public OrderID IntendedRepalcesOrderID;
        public TransactionRejectReason RejectReason;

        public StopLossOrderRejectTransaction()
        {
            this.Id = new TransactionID();
            this.Time = new DateTime();
            this.AccountID = new AccountID();
            this.BatchID = new TransactionID();
            this.RequestID = new RequestID();
            this.Type = new TransactionType(ETransactionType.STOP_LOSS_ORDER_REJECT);
            this.TradeID = new TradeID();
            this.ClientTradeID = new ClientID();
            this.Price = new PriceValue();
            this.TimeInForce = new TimeInForce(ETimeInForce.GTC);
            this.GTDTime = new DateTime();
            this.TriggerCondition = new OrderTriggerCondition();
            this.Reason = new StopLossOrderReason();
            this.ClientExtensions = new ClientExtensions();
            this.OrderFillTransactionID = new TransactionID();
            this.IntendedRepalcesOrderID = new OrderID();
            this.RejectReason = new TransactionRejectReason();
        }

        public StopLossOrderRejectTransaction(TransactionID id, DateTime time, int userID, AccountID accountID, TransactionID batchID, RequestID requestID, TransactionType type, TradeID tradeID, ClientID clientTradeID, PriceValue price, double distance, TimeInForce timeInForce, DateTime gTDTime, OrderTriggerCondition triggerCondition, bool guaranteed, StopLossOrderReason reason, ClientExtensions clientExtensions, TransactionID orderFillTransactionID, OrderID intendedRepalcesOrderID, TransactionRejectReason rejectReason)
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
            this.Reason = reason;
            this.ClientExtensions = clientExtensions;
            this.OrderFillTransactionID = orderFillTransactionID;
            this.IntendedRepalcesOrderID = intendedRepalcesOrderID;
            this.RejectReason = rejectReason;
        }
    }
}
